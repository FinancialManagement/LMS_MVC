using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alipay.AopSdk.AspnetCore;
using Alipay.AopSdk.Core.Domain;
using Alipay.AopSdk.Core.Request;
using LMS_MVC.comfing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LMS_MVC.Controllers.Wzb
{
    public class PayController : Controller
    {
        public IActionResult Index(int a)
        {
            ViewBag.a = a;
            return View();
        }

        private readonly IAlipayService _alipayService;
        private readonly ILogger _logger;
        public PayController(IAlipayService alipayService, ILogger<PayController> logger)
        {
            _alipayService = alipayService;

            _logger = logger;
        }

        /// <summary>
        /// 发起支付请求
        /// </summary>
        /// <param name="tradeno">外部订单号，商户网站订单系统中唯一的订单号</param>
        /// <param name="subject">订单名称</param>
        /// <param name="totalAmout">付款金额</param>
        /// <param name="itemBody">商品描述</param>
        /// <returns></returns>
        [HttpPost]
        public void PayRequest(string tradeno, string subject, string totalAmout, string itemBody)
        {
            //    DefaultAopClient client = new DefaultAopClient(Config.Gatewayurl, Config.AppId, Config.PrivateKey, "json", "2.0",
            //Config.SignType, Config.AlipayPublicKey, Config.CharSet, false);
            // 组装业务参数model
            AlipayTradePagePayModel model = new AlipayTradePagePayModel
            {
                Body = itemBody,
                Subject = subject,
                TotalAmount = totalAmout,
                OutTradeNo = tradeno,
                ProductCode = "FAST_INSTANT_TRADE_PAY"
            };

            AlipayTradePagePayRequest request = new AlipayTradePagePayRequest();
            // 设置同步回调地址 可以是调试模式地址 并非公网或域名地址 Pay走的是控制器的
            request.SetReturnUrl("http://190.120.120.01:110/Pay/Callback");
            // 设置异步通知接收地址 必须是公网或域名地址 Pay走的是控制器的方法
            request.SetNotifyUrl("http://50.200.50.10:110/Pay/AlipayNotify");
            // 将业务model载入到request
            request.SetBizModel(model);
            var response = _alipayService.SdkExecute(request);
            Console.WriteLine($"订单支付发起成功，订单号：{tradeno}");
            //跳转支付宝支付 支付网关地址
            Response.Redirect(Config.Gatewayurl + "?" + response.Body);
        }

        /// <summary>
        /// 异步通知即支付宝主动请求我们提供的地址，我们根据请求数据来校验，获取支付结果。
        /// 支付异步回调通知 需配置域名 因为是支付宝主动post请求这个action 所以要通过域名访问或者公网ip
        /// </summary>//public  async Task<IActionResult> AlipayNotify([FromForm]Dictionary<string,string> NotifyArray)
        public async Task<IActionResult> AlipayNotify()
        {
            /* 实际验证过程建议商户添加以下校验。
            1、商户需要验证该通知数据中的out_trade_no是否为商户系统中创建的订单号，
            2、判断total_amount是否确实为该订单的实际金额（即商户订单创建时的金额），
            3、校验通知中的seller_id（或者seller_email) 是否为out_trade_no这笔单据的对应的操作方（有的时候，一个商户可能有多个seller_id/seller_email）
            */
            Dictionary<string, string> NotifyArray = GetRequestPost();
            //通知验证ID
            string notifyId = NotifyArray["notify_id"];
            try
            {
                if (NotifyArray.Count != 0)
                {   //验签以及验证合作伙伴ID
                    bool flag = _alipayService.RSACheckV1(NotifyArray);
                    if (await Config.VerifyNotifyAsync(notifyId) == "true" && flag)
                    {
                        //交易状态
                        if (NotifyArray["trade_status"] == "TRADE_FINISHED" ||
                           NotifyArray["trade_status"] == "TRADE_SUCCESS")
                        {
                            if (NotifyArray["app_id"] == Config.AppId)

                            {  // 修改支付信息以及状态
                                //return await UpdateAliPayAsyn(NotifyArray);
                            }
                        }

                        await Response.WriteAsync("success");
                    }
                    else
                    {
                        await Response.WriteAsync("fail");
                    }
                }
            }
            catch (Exception e)
            {
                _logger.LogError("Alipay notify fail, {0}", e);
            }
            return View();
            //string msg = null;
            //return new ContentResult
            //{
            //    Content = msg ?? "fail"
            //};
        }

        [HttpGet]
        public IActionResult Callback()
        {
            /* 实际验证过程建议商户添加以下校验。
            1、商户需要验证该通知数据中的out_trade_no是否为商户系统中创建的订单号，
            2、判断total_amount是否确实为该订单的实际金额（即商户订单创建时的金额），
            3、校验通知中的seller_id（或者seller_email) 是否为out_trade_no这笔单据的对应的操作方（有的时候，一个商户可能有多个seller_id/seller_email）
            4、验证app_id是否为该商户本身。
            */
            Dictionary<string, string> sArray = GetRequestGet();
            if (sArray.Count != 0)
            {
                bool flag = _alipayService.RSACheckV1(sArray);
                if (flag)
                {
                    Console.WriteLine($"同步验证通过，订单号：{sArray["out_trade_no"]}");
                    ViewData["PayResult"] = "同步验证通过";
                    UserController user = new UserController();
                    user.KeIndex(10);
                }
                else
                {
                    Console.WriteLine($"同步验证失败，订单号：{sArray["out_trade_no"]}");
                    ViewData["PayResult"] = "同步验证失败";
                    UserController user = new UserController();
                    user.KeIndex(10);

                }
            }
            return View();
        }


        private Dictionary<string, string> GetRequestGet()
        {
            Dictionary<string, string> sArray = new Dictionary<string, string>();

            ICollection<string> requestItem = Request.Query.Keys;
            foreach (var item in requestItem)
            {
                sArray.Add(item, Request.Query[item]);

            }
            return sArray;
        }
        private Dictionary<string, string> GetRequestPost()
        {
            Dictionary<string, string> sArray = new Dictionary<string, string>();

            ICollection<string> requestItem = Request.Form.Keys;
            foreach (var item in requestItem)
            {
                sArray.Add(item, Request.Form[item]);

            }
            return sArray;

        }

    }
}

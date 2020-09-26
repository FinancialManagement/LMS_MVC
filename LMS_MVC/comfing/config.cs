using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LMS_MVC.comfing
{
    public class Config
    {
        public Config()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        // 应用ID,您的APPID
        public static string AppId = "2021000116693943";

        public static string Uid = "2021000116693943";
        // 支付宝网关
        public static string Gatewayurl = "https://openapi.alipaydev.com/gateway.do";

        // 商户私钥，您的原始格式RSA私钥
        public static string PrivateKey = "MIIEpAIBAAKCAQEAosVA0IM68QuHv3qagwUNbWWkDGCSH8vwAdXgKNM1apXCS3nFL01J9bbeqZCaGHH5fIoDaafEXBOo6w6NTiGoGaZU7W/wRE8jzod4uBna+MThzsRapoQbBjuAKIUy72ShoBqE2VHNsmybcJ/LQv+T7SkRLCXM29mjXXGcUr102CsfBmJk+oPNcfOITyoMSqxSaLRqH4T33EpQExiZTPSwSK8Idr2E3POlM17ExYCvuI+Zp5U9aAenN6pHtWrNWZMCC4gnDwRdYUpQE2XBAMeVf7MVwIv60FvD/x9ym8PQ8dBeCmmYHhDpy2TqMUDJijTYftzQ5Bv4BvPclJwSC3uA+QIDAQABAoIBAQCOPFqwGw0FmHLOU1/0ABVEtJ4PJtBqMrcPk4rngfFaq3V2qPkzpZFsw5l9iVvu4qIGP0BOMol3gMKKbVPzo5uWlm/+cGP//Twn/N/z2LwtyTYdjh49BpHq91G9lu/0m/ZUxveyRDbApQGMAEcJy/bDNrDH6FxE/cExJddZwi75uf8z5BzENVVkEYCBPxouLlUsijnhVPC6PULCuceBBa3l85FjFz2oMSZkp9DRUDLDnc/yZRuWLqfHRgWGL0Gw3fZp/LPHT2FXyBZrAa5P6k/QFwRXlFBHrBZxkVswu9fYbRtGS0/EqoJ+YthICJK9iM84bsa+HWWUznznbRU/ScsFAoGBAP7brUGfxZZWNg+W63/y4jADj61Z0bTkGWoaXfDyMhIrYM4EOjwJQbpv6JXZeEpmdWJm0Gnkxk6B4w83qogLGvGlTL5UkbJB8t2F2+NkfkSaiwv9uzttWQK1HumZPZnTbXV7mKNCyupNrrqKciVX1bPQl9MvujMbBpsKLIVRDWUvAoGBAKN/85ryayvC6P6jFaBwevUxlU1o60I44Nsr/FhfEGuvIM5H1EaEtozJ7vf3Mvkz0/30NEVrWRCyUbg82+/a3AmNI7taq4+1+ojuEO3loSjnTqrFwiBdyJWuFI7Y8oq6EoTXQa8ZqEg3Us2c+l+rTdzjq3IYDB9zJeFm6odrqEJXAoGAa6kXLqK00EZI/hruDxXmcQwAFOXdjcHR7p2G07Msbbp/YWgtxZDPgFen9C1zAFL6AYCXSDSJhT6fUZ1dX6z5S91dZwXIqnnrg6L5ebzJDmgOlxkvj/IoaNlkXqAKgsHq+nckysr7dzErv8eeYqIRN63FhUQjL1WaW8JXflX4B6cCgYEAlb8C5s9QyOvjahUEIcXjV97p19RYZHajuxk2Ldojt/zWFxhCm7PBXoE0lXebABMv/lBD77C6CkjH/+39oljZXwYdy+LnbuBFblRcvQar7EKuEkq92dcLd8vQmGSq/9QcUf608iKVtk61UAyOZEEJN15uEDlmIQfdkewosY8wtFECgYAGov/C08EDlBI3wG1iY8mbIDab5mqUlkFt/tRHJJKskGOIV0G/zRuZqiHYjAMKii4GHPQZGqT8BOz+tqk6bWl01pRwe/c+a0/iFMWLHcyKW8u5nD0FE/zNisxHB9KmAwOccn7ht1pTvZtUmD6YEVoCP5ywpJT3oN73OmB+rpHI4w==";

        // 支付宝公钥,查看地址：https://openhome.alipay.com/platform/keyManage.htm 对应APPID下的支付宝公钥。
        public static string AlipayPublicKey = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAlFs+wlnbFD02Zes2/DdlGfLs/om1t4F9ZvejvjbEmvwKsTI6D+GPpgfZ/9nel8jKxBqsD5ocT+GP9D4wDwi3kSnvph4z3CBTDFaFxMiAkEovoz5F8qstH/Q3PAXNiqxrMzuZJWjHg+TIvQI49EQexqGC2ygkOFVRIPtFbCiOtcJ+jiFiDUk8rzRy2nKx7AdTtpaQhKOp+ULEduyvg8lSB39O2o7FlaX8odydRUHCb7uF7/t0HYuxlrKhrXQECVPhAGNT+DaAOcghjsdi8moE1jdGrmwOrRDg9GNsErasC9or3bzryHJ+xw7Wb+r4zFoH5Y8GEU0G+teye9DX8I2yNQIDAQAB";

        // 签名方式
        public static string SignType = "RSA2";

        // 编码格式
        public static string CharSet = "UTF-8";


        /// <summary>
        /// 异步通知 处理支付宝接口通知返回 获取是否是支付宝服务器发来的请求的验证结果
        /// </summary>
        /// <param name="notifyId">通知验证ID</param>
        /// <returns>验证结果</returns>
        public static async Task<string> VerifyNotifyAsync(string notifyId)
        {
            return await SendAsync(Uid, notifyId);
        }
        /// <summary>
        ///  //支付宝消息验证地址
        /// </summary>
        private const string API_URL = "https://mapi.alipay.com/gateway.do?service=notify_verify&";

        /// <summary>
        /// 获取是否是支付宝服务器发来的请求的验证结果
        /// </summary>
        /// <param name="partner">partner 合作身份ID</param>
        /// <param name="notify_id">通知验证ID</param>
        /// <returns>验证结果</returns>
        public static async Task<string> SendAsync(string partner, string notify_id)
        {
            string strResult;
            string verifyUrl = API_URL + "partner=" + partner + "&notify_id=" + notify_id;
            //获取远程服务器ATN结果，验证是否是支付宝服务器发来的请求
            try
            {
                using (var client = new HttpClient())
                {

                    //client.Timeout = 120000;
                    var response = await client.GetAsync(verifyUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        byte[] data = await response.Content.ReadAsByteArrayAsync();
                        Encoding.UTF8.GetString(data);
                        return strResult = "true";
                    }

                }
            }
            catch (Exception exp)
            {
                strResult = "错误信息：" + exp.Message;
            }
            return string.Empty;
        }

        public static ContentResult Response_Success(string msg = null)
        {
            return new ContentResult
            {
                Content = msg ?? "success"
            };
        }
        public static ContentResult ResponseFail(string msg = null)
        {
            return new ContentResult
            {
                Content = msg ?? "fail"
            };
        }

    }
}

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pagepay.aspx.cs" Inherits="Bao.pagepay.pagepay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <div id="body1" class="show" name="divcontent">
                <dl class="content">
                    <dt>商户订单号
：</dt>
                    <dd>
                        <asp:TextBox ID="WIDout_trade_no" name="WIDout_trade_no" runat="server"></asp:TextBox>
                    </dd>
                    <hr class="one_line">
                    <dt>订单名称
：</dt>
                    <dd>
                         <asp:TextBox ID="WIDsubject" name="WIDsubject" runat="server"></asp:TextBox>
                    </dd>
                    <hr class="one_line">
                    <dt>付款金额
：</dt>
                    <dd>
                         <asp:TextBox ID="WIDtotal_amount" name="WIDtotal_amount" runat="server"></asp:TextBox>
                    </dd>
                    <hr class="one_line">
                    <dt>商品描述：</dt>
                    <dd>
                         <asp:TextBox ID="WIDbody" name="WIDbody" runat="server"></asp:TextBox>
                    </dd>
                    <hr class="one_line">
                    <dt></dt>
                    <dd id="btn-dd">
                        <span class="new-btn-login-sp">
                            <asp:Button ID="BtnAlipay" name="BtnAlipay" class="new-btn-login" Text="确 认" Style="text-align: center;" runat="server" OnClick="BtnAlipay_Click"/>
                        </span>
                        <span class="note-help">如果您点击“付款”按钮，即表示您同意该次的执行操作。</span>
                    </dd>
                </dl>
            </div>
    </div>
    </form>
</body>
</html>

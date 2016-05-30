<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ContactUs.aspx.vb" Inherits="OrderConfirmation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 249px;
            height: 222px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Contact us at&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <img alt="" class="auto-style1" src="clipart-book-03.jpg" /><br />
        <br />
        Email: <a href="mailto:webmaster@rnrbooks.com">webmaster@rnrbooks.com</a><br />
        <br />
        Phone: 1-800-555-1111<br />
        <br />
    
    </div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Return to order form</asp:HyperLink>
    </form>
</body>
</html>

<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
            font-size: xx-large;
            color: #FF9900;
            font-style: italic;
            font-weight: bold;
        }
        .auto-style3 {
            font-size: large;
            font-style: italic;
            text-align: center;
        }
        .auto-style4 {
            width: 131px;
            text-align: right;
        }
        .auto-style6 {
            height: 23px;
            width: 154px;
        }
        .auto-style5 {
            width: 113px;
            text-align: right;
        }
        .auto-style7 {
            width: 154px;
        }
    </style>
</head>
<body style="background-color: #FFCC66">
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="3">R &#39;n R Book Sales</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="QuantityLabel" runat="server" Text="Quantity"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="QuantityTextBox" runat="server" Width="75px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvQuantityTextBox" runat="server" ControlToValidate="QuantityTextBox" ErrorMessage="Must be a number quantity" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="TitleLabel" runat="server" Text="Title"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="TitleTextBox" runat="server" Width="200px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="PriceLabel" runat="server" Text="Price"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="PriceTextBox" runat="server" Width="75px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvPriceTextBox" runat="server" ControlToValidate="PriceTextBox" ErrorMessage="Price must be a decimal value" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="ExtPriceLabel" runat="server" Text="Extended Price"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="ExtPriceTextBox" runat="server" BackColor="#FFCC99" ForeColor="White" ReadOnly="True"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="DiscountLabel" runat="server" Text="15% Discount"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="DiscountTextBox" runat="server" BackColor="#FFCC99" ReadOnly="True"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="DiscountPriceLabel" runat="server" Text="Discounted Price"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="DiscountedPriceTextBox" runat="server" BackColor="#FFCC99" ReadOnly="True"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="DiscountSummaryTextBox" runat="server" BackColor="#FFCC66" BorderColor="#FFCC66" BorderStyle="None" ReadOnly="True" Width="157px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Button ID="SubmitButton" runat="server" Text="Submit" Width="125px" />
                </td>
                <td rowspan="2">
                    <asp:Button ID="DiscountSummaryButton" runat="server" Text="Discount Summary" Width="125px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Button ID="ClearButton" runat="server" Text="Clear" Width="125px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>
                    <asp:HyperLink ID="ContactUsHyperLink" runat="server" NavigateUrl="~/ContactUs.aspx">Contact Us</asp:HyperLink>
                </td>
            </tr>
        </table>
    
    </div>
        <asp:HiddenField ID="DiscountSummaryHiddenField" runat="server" />
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </form>
</body>
</html>

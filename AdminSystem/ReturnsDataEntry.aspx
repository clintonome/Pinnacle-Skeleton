<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReturnsDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="lblReturnsNo" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Returns Number"></asp:Label>
            <asp:TextBox ID="txtReturnsNo" runat="server" style="z-index: 1; left: 133px; top: 29px; position: absolute"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtCustomerName" runat="server" style="z-index: 1; left: 133px; top: 55px; position: absolute"></asp:TextBox>
            &nbsp;<asp:TextBox ID="txtReturnDescription" runat="server" style="z-index: 1; left: 133px; top: 82px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblReturnDescription" runat="server" style="z-index: 1; left: 9px; top: 85px; position: absolute; bottom: 658px" Text="Description"></asp:Label>
            <asp:Label ID="lblReturnQuantity" runat="server" style="z-index: 1; left: 11px; top: 112px; position: absolute" Text="Quantity"></asp:Label>
            <asp:TextBox ID="txtReturnQuantity" runat="server" style="z-index: 1; left: 133px; top: 110px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblDateReturned" runat="server" style="z-index: 1; left: 13px; top: 139px; position: absolute" Text="Date Returned"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 131px; top: 137px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 10px; top: 163px; position: absolute" Text="Price"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 131px; top: 161px; position: absolute"></asp:TextBox>
            <asp:CheckBox ID="lblReturnedOnTime" runat="server" style="z-index: 1; left: 9px; top: 231px; position: absolute" Text="Returned On Time" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 14px; top: 278px; position: absolute"></asp:Label>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 13px; top: 316px; position: absolute" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 51px; top: 316px; position: absolute" Text="Cancel" />
            <asp:Label ID="lblCustomerName" runat="server" style="z-index: 1; left: 8px; top: 58px; position: absolute" Text="Customer Name"></asp:Label>
        </div>
    </form>
</body>
</html>

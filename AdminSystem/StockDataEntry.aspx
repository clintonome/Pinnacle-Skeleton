<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStockID" runat="server" height="22px" Text="StockID" width="52px"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStockID" runat="server" height="25px" TextMode="Number" width="168px"></asp:TextBox>
            <asp:Button ID="ButtonFind" runat="server" OnClick="ButtonFind_Click" Text="Find" />
            <br />
            <asp:Label ID="lblDescription" runat="server" Text="Description" width="52px"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDescription" runat="server" height="25px" width="168px"></asp:TextBox>
            <br />
            <asp:Label ID="lblColour" runat="server" height="22px" Text="Colour" width="52px"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtColour" runat="server" height="25px" width="168px"></asp:TextBox>
            <br />
            <asp:Label ID="lblDateAdded" runat="server" height="22px" Text="Date " width="52px"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDate" runat="server" height="25px" width="168px"></asp:TextBox>
            <br />
            <asp:Label ID="lblPrice" runat="server" height="22px" Text="Price" width="52px"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPrice" runat="server" height="25px" width="168px"></asp:TextBox>
            &nbsp;
            <br />
            <asp:Label ID="lblQuantity" runat="server" height="22px" Text="Quantity" width="52px"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtQuantity" runat="server" height="25px" width="168px"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="Availability" runat="server" />
            <asp:Label ID="lblAvailability" runat="server" Text="Availability"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="ButtonOK" runat="server" OnClick="ButtonOK_Click" Text="OK" />
            <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" UseSubmitBehavior="False" />
        </div>
    </form>
</body>
</html>

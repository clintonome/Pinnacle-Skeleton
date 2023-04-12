<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCusId" runat="server" style="z-index: 1; left: 10px; top: 42px; position: absolute" Text="Customer ID"></asp:Label>
        <asp:TextBox ID="txtCusId" runat="server" style="z-index: 1; left: 169px; top: 42px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCusDob" runat="server" style="z-index: 1; left: 169px; top: 83px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCusDob" runat="server" style="z-index: 1; left: 10px; top: 83px; position: absolute" Text="Customer DOB"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblCusEmail" runat="server" style="z-index: 1; left: 10px; top: 119px; position: absolute" Text="Email"></asp:Label>
        <asp:Label ID="lblCusPassword" runat="server" style="z-index: 1; left: 10px; top: 237px; position: absolute" Text="Password"></asp:Label>
        <asp:TextBox ID="txtCusPassword" runat="server" style="z-index: 1; left: 167px; top: 235px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkEmailAlerts" runat="server" style="z-index: 1; left: 10px; top: 278px; position: absolute" Text="Email Alerts" />
        <asp:TextBox ID="txtCusEmail" runat="server" style="z-index: 1; left: 168px; top: 119px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="lblCusAdress" runat="server" style="z-index: 1; left: 10px; top: 165px; position: absolute" Text="Address"></asp:Label>
            <asp:TextBox ID="txtCusAdress" runat="server" style="z-index: 1; left: 167px; top: 163px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblCusUsername" runat="server" style="z-index: 1; left: 10px; top: 200px; position: absolute" Text="Username"></asp:Label>
            <asp:TextBox ID="txtCusUsername" runat="server" style="z-index: 1; left: 168px; top: 200px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 317px; position: absolute"></asp:Label>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 10px; top: 362px; position: absolute; height: 35px" Text="Ok" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 67px; top: 360px; position: absolute" Text="Cancel" />
    </form>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>

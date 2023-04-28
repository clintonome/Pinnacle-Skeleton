<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are You sureYou Want To Delete This Record</div>
        <p>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 9px; top: 73px; position: absolute; right: 984px" Text="Yes" />
        </p>
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 96px; top: 75px; position: absolute" Text="No" />
    </form>
</body>
</html>

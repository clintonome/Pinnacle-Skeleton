<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 619px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 11px; top: 448px; position: absolute; width: 49px" Text="Add" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 193px; top: 449px; position: absolute" Text="Delete" />
            <asp:ListBox ID="lstCustomerList" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 424px; width: 427px"></asp:ListBox>
        </div>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 97px; top: 448px; position: absolute; width: 49px" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 576px; position: absolute; height: 30px;"></asp:Label>
        g<br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
&nbsp;Enter A Username<asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 149px; top: 509px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 30px; top: 536px; position: absolute; right: 944px" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 116px; top: 537px; position: absolute" Text="Clear" />
    </form>
</body>
</html>

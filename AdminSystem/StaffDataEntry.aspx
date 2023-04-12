<form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaffID" runat="server" Text="StaffID" width="78px"></asp:Label>
            <asp:TextBox ID="txtStaffID" runat="server"></asp:TextBox>
        </div>
    <p>
        <asp:Label ID="lblName" runat="server" Text="Name" width="78px"></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblPassword" runat="server" Text="Password" width="78px"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblRole" runat="server" Text="Role" width="78px"></asp:Label>
        <asp:TextBox ID="txtRole" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblDOB" runat="server" Text="Date of Birth"></asp:Label>
        <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblSalary" runat="server" Text="Salary" width="78px"></asp:Label>
        <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </p>
    <p>
        <asp:CheckBox ID="chkPermission" runat="server" Text="Permission" />
    </p>
    <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="OK" />

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

    <asp:Button ID="btnCancel" runat="server" Text="Cancel" />

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        &nbsp;</p>
</form>
</body>
</html>

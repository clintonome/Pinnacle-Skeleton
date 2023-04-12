<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtOrderID" runat="server" height="22px" style="z-index: 1; left: 93px; top: 15px; position: absolute" width="128px"></asp:TextBox>
            <asp:TextBox ID="CustName" runat="server" style="z-index: 1; left: 93px; top: 60px; position: absolute; height: 22px; width: 128px"></asp:TextBox>
            <br />
            <asp:Label ID="lblCustName" runat="server" style="z-index: 1; left: 11px; top: 58px; position: absolute; height: 19px; bottom: 381px;" Text="CustName" width="65px"></asp:Label>
            <br />
            <asp:Label ID="lblOrderID0" runat="server" height="19px" style="z-index: 1; left: 11px; top: 15px; position: absolute; bottom: 530px" Text="OrderID" width="65px"></asp:Label>
            <br />
            <asp:Label ID="lblQuantity" runat="server" height="19px" style="z-index: 1; left: 11px; top: 98px; position: absolute" Text="Quantity" width="65px"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 11px; top: 134px; position: absolute; height: 22px;" Text="DateAdded" width="65px"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 11px; top: 163px; position: absolute; height: 22px;" Text="Price" width="65px"></asp:Label>
            <asp:TextBox ID="Price" runat="server" style="z-index: 1; left: 93px; top: 160px; position: absolute; width: 128px; height: 28px;"></asp:TextBox>
            <br />
            <asp:Label ID="lblShipAddress" runat="server" style="z-index: 1; left: 11px; top: 201px; position: absolute; height: 20px" Text="ShipAddress" width="65px"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtShipAdd" runat="server" style="z-index: 1; left: 93px; top: 201px; position: absolute; height: 22px;" width="128px"></asp:TextBox>
            <br />
            <asp:TextBox ID="Quantity" runat="server" style="z-index: 1; left: 93px; top: 93px; position: absolute; height: 22px;" width="128px"></asp:TextBox>
            <asp:TextBox ID="txtdatetime" runat="server" style="z-index: 1; left: 93px; top: 131px; position: absolute; height: 22px;" width="128px"></asp:TextBox>
            &nbsp; &nbsp;&nbsp;
            <br />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 28px; top: 272px; position: absolute; width: 72px; height: 20px" Text="lblError"></asp:Label>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="chkdelivered" runat="server" Text="Delivered" />
            &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 38px; top: 317px; position: absolute; height: 26px; right: 488px; margin-bottom: 21px;" Text="OK" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Button ID="btnCancel" runat="server" Height="30px" Text="Cancel" Width="64px" />
        </div>
    </form>
</body>
</html>

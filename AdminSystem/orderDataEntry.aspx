<%@ Page Language="C#" AutoEventWireup="true" CodeFile="orderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 79px; top: 23px; position: absolute; height: 18px"></asp:TextBox>
        <div style="height: 312px; margin-top: 0px">
            <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 15px; top: 140px; position: absolute" Text="Price"></asp:Label>
            <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 82px; top: 166px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 83px; top: 136px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 14px; top: 162px; position: absolute" Text="Quantity"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:CheckBox ID="chkShipped" runat="server" style="z-index: 1; left: 14px; top: 200px; position: absolute" Text="Shipped" />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 10px; top: 262px; position: absolute" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 51px; top: 261px; position: absolute" Text="Cancel" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 239px; position: absolute; height: 15px; width: 43px"></asp:Label>
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
        </div>
        <p>
            <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 11px; top: 32px; position: absolute" Text="Order Id"></asp:Label>
            <asp:Label ID="lblOrderLine" runat="server" style="z-index: 1; left: 11px; top: 59px; position: absolute; right: 720px" Text="Order Line"></asp:Label>
            <asp:TextBox ID="txtOrderLine" runat="server" style="z-index: 1; left: 81px; top: 53px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtBookTitle" runat="server" style="z-index: 1; left: 81px; top: 81px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblBookTitle" runat="server" style="z-index: 1; left: 12px; top: 88px; position: absolute" Text="Book Title"></asp:Label>
            <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 9px; top: 116px; position: absolute" Text="Order Date"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 84px; top: 109px; position: absolute"></asp:TextBox>
        </p>
    </form>
</body>
</html>

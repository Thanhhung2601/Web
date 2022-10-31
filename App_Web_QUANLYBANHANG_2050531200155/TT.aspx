<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TT.aspx.cs" Inherits="App_Web_QUANLYBANHANG_2050531200155.TT" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="ListBox1" runat="server" Height="120px" Width="259px"></asp:ListBox>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>Hehe</asp:ListItem>
            <asp:ListItem>kaka</asp:ListItem>
        </asp:CheckBoxList>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>12</asp:ListItem>
        </asp:RadioButtonList>
        <asp:DropDownList ID="gridTest" runat="server">
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
    </form>
</body>
</html>

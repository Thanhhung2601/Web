<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGE_USER.Master" AutoEventWireup="true" CodeFile="chiTiet2.aspx.cs" Inherits="App_Web_QUANLYBANHANG_2050531200155.chiTiet2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    
    <asp:Repeater ID="Repeater3" runat="server">
        <ItemTemplate>
            <img src="IMAGES/<%# Eval("HINHANH") %>" width="150px" height="150px" />
        <h1>Ten san pham : <%# Eval("TENSANPHAM") %></h1>
        </ItemTemplate>
    </asp:Repeater>
    <asp:DropDownList ID="drlGioHangg" runat="server">
    </asp:DropDownList>
    <asp:Button ID="btnGioHangg" runat="server" Text="Mua hang" OnClick="btnGioHangg_Click" />
</asp:Content>

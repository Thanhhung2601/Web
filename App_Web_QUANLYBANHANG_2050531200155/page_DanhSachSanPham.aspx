<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGE_USER.Master" AutoEventWireup="true" CodeFile="page_DanhSachSanPham.aspx.cs" Inherits="App_Web_QUANLYBANHANG_2050531200155.page_DanhSachSanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
             <a href='chiTiet2.aspx?MSP=<%# Eval("MASANPHAM") %>'>
            <img alt="" src='IMAGES/<%# Eval("HINHANH") %>' width="150px" height="150px" />
            </a>
             Ten San Pham :<%# Eval("TENSANPHAM") %><br />Don Gia : <%# Eval("DONGIA") %>
        </ItemTemplate> 
        
    </asp:DataList>
</asp:Content>

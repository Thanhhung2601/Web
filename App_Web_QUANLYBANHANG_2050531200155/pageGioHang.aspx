<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_PAGE_USER.Master" AutoEventWireup="true" CodeFile="pageGioHang.aspx.cs" Inherits="App_Web_QUANLYBANHANG_2050531200155.pageGioHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <asp:GridView ID="gridviewGiohang" runat="server" AutoGenerateColumns="False" ShowFooter="True">
        <Columns>
            <asp:BoundField DataField="MASANPHAM" HeaderText="Mã sản phẩm" />
            <asp:BoundField DataField="TENSANPHAM" HeaderText="Tên sản phẩm" />
            <asp:BoundField DataField="SOLUONG" HeaderText="Số lượng" />
            <asp:BoundField DataField="DONGIA" HeaderText="Đơn giá" />
            <asp:BoundField DataField="THANHTIEN" HeaderText="Thành tiền" />
            <asp:ImageField DataAlternateTextField="HINHANH" DataImageUrlField="HINHANH" DataImageUrlFormatString="IMAGES/{0}" HeaderText="Ảnh" ControlStyle-Width="100px" ControlStyle-Height="100px">
            </asp:ImageField>
            
        </Columns>
        <EmptyDataTemplate>
            <asp:CheckBox ID="ckbRemoveItem" runat="server" />
        </EmptyDataTemplate>
    </asp:GridView>

</asp:Content>

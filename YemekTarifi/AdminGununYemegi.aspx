<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminGununYemegi.aspx.cs" Inherits="YemekTarifi.AdminGununYemegi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="admin-yemekler-header">
        <h1>Yemek Listesi</h1>
    </div>
    <asp:DataList CssClass="admin-yemekler-datalist" ID="DataList1" runat="server">
        <ItemTemplate>
            <div class="yemek-ad">
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("YemekAd") %>'></asp:Label>
                <div class="yemekler-icons">
                    <a href="AdminGununYemegiDetay.aspx?Yemekid=<%# Eval("Yemekid") %>">
                        <i class="far fa-edit"></i>
                    </a>
                </div>
            </div>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>

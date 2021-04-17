<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminMesajlar.aspx.cs" Inherits="YemekTarifi.AdminMesajlar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="admin-yemekler-header">
        <h1>Mesajlar</h1>
    </div>
    <asp:DataList  CssClass="admin-yemekler-datalist" ID="DataList1" runat="server">
        <ItemTemplate>
            <div class="yemek-ad">
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("MesajGonderen") %>'></asp:Label>
                 <div class="yemekler-icons">
                    <a href="AdminMesajlarDetay.aspx?Mesajid=<%# Eval("Mesajid") %>">
                        <i class="far fa-edit"></i>
                    </a>
                </div>
            </div>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>

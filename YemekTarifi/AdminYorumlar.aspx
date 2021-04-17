<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminYorumlar.aspx.cs" Inherits="YemekTarifi.AdminYorumlar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="admin-yemekler-header">
        <h1>Onaylanan Yorumlar</h1>
    </div>
    <asp:DataList CssClass="admin-yemekler-datalist" ID="DataList1" runat="server">
        <itemtemplate>
            <div class="yemek-ad">
            <asp:Label ID="Label1" runat="server" Text='<%# Eval("YorumAdSoyad") %>'></asp:Label>
                <div class="yemekler-icons">
                    <a href="AdminYorumlarDetay.aspx?Yorumid=<%# Eval("Yorumid") %>">
                        <i class="far fa-edit"></i>
                    </a>
                    <a href="AdminYorumlar.aspx?Yorumid=<%# Eval("Yorumid") %>&islem=sil">
                        <i class="far fa-trash-alt"></i>
                    </a>
                </div>
            </div>
        </itemtemplate>
    </asp:DataList>
     <div class="admin-yemekler-header">
        <h1>Onay Bekleyen Yorumlar</h1>
    </div>
    <asp:DataList CssClass="admin-yemekler-datalist" ID="DataList2" runat="server">
        <ItemTemplate>
            <div class="yemek-ad">
                <asp:Label ID="Label2" runat="server" Text='<%# Eval("YorumAdSoyad") %>'></asp:Label>
                <div class="yemekler-icons">
                    <a href="AdminYorumlarDetay.aspx?Yorumid=<%# Eval("Yorumid") %>">
                        <i class="far fa-edit"></i>
                    </a>
                    <a href="AdminYorumlar.aspx?Yorumid=<%# Eval("Yorumid") %>&islem=sil">
                        <i class="far fa-trash-alt"></i>
                    </a>
                </div>
            </div>
        </ItemTemplate>
    </asp:DataList>

</asp:Content>

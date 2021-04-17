<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminTarifOner.aspx.cs" Inherits="YemekTarifi.AdminTarifOner" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="admin-yemekler-header">
        <h1>Onaylanmayan Tarifler</h1>
    </div>

    <asp:DataList CssClass="admin-yemekler-datalist" ID="DataList1" runat="server">
        <ItemTemplate>
            <div class="yemek-ad">
            <asp:Label ID="Label1" runat="server" Text='<%# Eval("TarifAd") %>'></asp:Label>
                 <div class="yemekler-icons">
                    <a href="AdminTarifOnerDetay.aspx?Tarifid=<%#Eval("Tarifid") %>">
                        <i class="far fa-edit"></i>
                    </a>
                    <a href="AdminTarifOner.aspx?Tarifid=<%# Eval("Tarifid")%>&islem=sil">
                        <i class="far fa-trash-alt"></i>
                    </a>
                </div>
            </div>
        </ItemTemplate>
    </asp:DataList>
    <div class="admin-yemekler-header">
        <h1>Onaylanan Tarifler</h1>
    </div>

    <asp:DataList CssClass="admin-yemekler-datalist" ID="DataList2" runat="server">
        <ItemTemplate>
            <div class="yemek-ad">
            <asp:Label ID="Label2" runat="server" Text='<%# Eval("TarifAd") %>'></asp:Label>
                <div class="yemekler-icons">
                    <a href="AdminTarifOnerDetay.aspx?Tarifid=<%#Eval("Tarifid") %>">
                        <i class="far fa-edit"></i>
                    </a>
                    <a href="AdminTarifOner.aspx?Tarifid=<%# Eval("Tarifid")%>&islem=sil">
                        <i class="far fa-trash-alt"></i>
                    </a>
                </div>
            </div>
        </ItemTemplate>
    </asp:DataList>

</asp:Content>

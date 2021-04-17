<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="KategoriDetay.aspx.cs" Inherits="YemekTarifi.KategoriDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
   

    
    
    <div class="tbl">
    <asp:DataList ID="DataList2" runat="server">
        <ItemTemplate>
            <div class="kategori-detay-section">
                <div class="kategori-baslik">
                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("YemekAd") %>'></asp:Label>
                </div>
                <div class="kategori-malzeme">
                    <h3>Malzemeler</h3>
                    <asp:Label ID="Label5" runat="server" Text='<%# Eval("YemekMalzeme") %>'></asp:Label>
                </div>
                <div class="kategori-tarif">
                    <h3>Tarif</h3>
                    <asp:Label ID="Label6" runat="server" Text='<%# Eval("YemekTarif") %>'></asp:Label>
                </div>
                <div class="kategori-resim">
                    <asp:Label ID="Label7" runat="server" Text='<%# Eval("YemekResim") %>'></asp:Label>
                </div>
                <div class="kategori-tarih">
                    Eklenme Tarihi:
                    <asp:Label ID="Label8" runat="server" Text='<%# Eval("YemekTarih") %>'></asp:Label>
                </div>
                <div class="kategori-puan">
                    Puanı:
                    <asp:Label ID="Label9" runat="server" Text='<%# Eval("YemekPuan") %>'></asp:Label>
                </div>

            </div>
        </ItemTemplate>
    </asp:DataList>
    </div>
   

    
    
    
</asp:Content>

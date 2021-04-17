<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="GununYemegi.aspx.cs" Inherits="YemekTarifi.GununYemegi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:DataList ID="DataList2" runat="server">
        <ItemTemplate>
            <div class="gunun-yemegi">
                <div class="gunun-yemegi-header">
                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("YemekAd") %>'></asp:Label>
                </div>
                <hr />
                 <div class="gunun-yemegi-malzemeler">
                     <b><i>Malzemeler: </i></b><asp:Label ID="Label5" runat="server" Text='<%# Eval("YemekMalzeme") %>'></asp:Label>
                 </div>
               <div class="gunun-yemegi-yapisilisi">
                    <b><i style="font-size:1.2rem">Yapılışı: </i></b>
                    <asp:Label ID="Label6" runat="server" Text='<%# Eval("YemekTarif") %>'></asp:Label>
                </div>
                <div class="yanyana-getir">
                <div class="gunun-yemegi-img">
                    <asp:Image ID="Image1" runat="server" Heigth="200" ImageUrl="~/Resimler/nezaket-kebabi-tarifi.jpg" Width="400" />
                </div>
                <div class="gunun-yemegi-puan">
                    <b><i>Puanı: </i></b>
                    <asp:Label ID="Label7" runat="server" Text='<%# Eval("YemekPuan") %>'></asp:Label>
               <br />
                
                    <b><i>Eklendiği Tarihi: </i></b><asp:Label ID="Label8" runat="server" Text='<%# Eval("YemekTarih") %>'></asp:Label>
                  </div>
                    </div>
               </div>
        </ItemTemplate>
    </asp:DataList>
    
</asp:Content>

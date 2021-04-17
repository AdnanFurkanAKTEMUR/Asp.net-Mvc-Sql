<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="YemekDetay.aspx.cs" Inherits="YemekTarifi.YemekDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList3" runat="server">
        <ItemTemplate>
            <table class="anasayfa-table">
                <tr>
                    <td class="yemek-adi">
                        <asp:Label ID="Label8" runat="server" Text='<%# Eval("YemekAd") %>'></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="yemek-malzemeler">
                        <asp:Label ID="Label9" runat="server" Text='<%# Eval("YemekMalzeme") %>'></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="yemek-yapilisi">
                        <asp:Label ID="Label10" runat="server" Text='<%# Eval("YemekTarif") %>'></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label11" runat="server" Text='<%# Eval("YemekResim") %>'></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label12" runat="server" Text='<%# Eval("YemekTarih") %>'></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label13" runat="server" Text='<%# Eval("YemekPuan") %>'></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
    <h1>Yorumlar</h1>
    <div class="yorumlar">
        <asp:DataList CssClass="ver" ID="DataList2" runat="server">
            <ItemTemplate>
            <div class="yorum-yazar">
                <asp:Label ID="Label5" runat="server" Text='<%# Eval("YorumAdSoyad") %>'></asp:Label>
            </div>
            <div class="yorum-mesaj">
                <asp:Label ID="Label6" CssClass="yorum-yazi" runat="server" Text='<%# Eval("YorumIcerik") %>'></asp:Label>
            </div>
            <div class="yorum-tarih">
                Eklenme Tarihi: <asp:Label ID="Label7" CssClass="yorum-tarih" runat="server" Text='<%# Eval("YorumTarih") %>'></asp:Label>
            </div>
            </ItemTemplate>
        </asp:DataList>
     </div>
     <div class="yorum-yap">
         <table class="tbl">
             <tr>
                 <td style="text-align:right"><asp:Label ID="Label14" runat="server" Text="Adınız ve Soyadınız"></asp:Label></td>
                 <td><asp:TextBox CssClass="inpt" ID="TextBox1" runat="server"></asp:TextBox></td>
             </tr>
             <tr>
                 <td style="text-align:right"><asp:Label ID="Label15" runat="server" Text="Mail Adresiniz"></asp:Label></td>
                 <td><asp:TextBox CssClass="inpt" ID="TextBox2" runat="server"></asp:TextBox></td>
             </tr>
             <tr>
                 <td style="text-align:right"><asp:Label ID="Label16" runat="server" Text="Yorumunuz"></asp:Label></td>
                 <td><asp:TextBox CssClass="inpt" ID="TextBox3" runat="server" TextMode="MultiLine"></asp:TextBox></td>
             </tr>
            <tr>
                <td></td>
                <td><asp:Button CssClass="btn inpt" ID="Button1" runat="server" OnClick="Button1_Click" Text="Gönder" /></td>
            </tr>
         </table>
      </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="AnaSayfa.aspx.cs" Inherits="YemekTarifi.AnaSayfa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content  ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <asp:DataList ID="DataList2" runat="server">
        <ItemTemplate>
            <table class="anasayfa-table">
                <tr>
                    <td class="yemek-adi">
                        
                      <a href="YemekDetay.aspx?Yemekid=<%# Eval("Yemekid") %>"><asp:Label ID="Label4" runat="server" Text='<%# Eval("YemekAd") %>'></asp:Label>
                        </a>
                    </td>
                </tr>
                <tr>
                    <td class="yemek-malzemeler">
                        <bold><i style="font-size:1.2rem;font-weight:bolder;color:red;">Malzemeler: </i></bold><asp:Label ID="Label5" runat="server" Text='<%# Eval("YemekMalzeme") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="yemek-yapilisi">
                        <bold><i style="font-size:1.2rem;font-weight:bolder;color:red;">Yapılışı: </i></bold><asp:Label ID="Label6" runat="server" Text='<%# Eval("YemekTarif") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text='<%# Eval("YemekTarih") %>'></asp:Label>
                        <asp:Label ID="Label8" runat="server" Text='<%# Eval("YemekPuan") %>'></asp:Label>
                        <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
   
</asp:Content>

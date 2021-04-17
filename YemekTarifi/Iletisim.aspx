<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="Iletisim.aspx.cs" Inherits="YemekTarifi.Iletisim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="tbl">
    <div class="baslik">
        <h1>Bize Yaz</h1>
    </div>

    <table class="ver">
        <tr>
            <td style="text-align:right">Ad Soyad:</td>
            <td>
                <asp:TextBox CssClass="inpt" ID="txtAdSoyad" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align:right">Mail Adresi:</td>
            <td>
                <asp:TextBox CssClass="inpt" ID="TxtMail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align:right">Konu:</td>
            <td>
                <asp:TextBox CssClass="inpt" ID="txtKonu" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align:right">Mesaj:</td>
            <td>
                <asp:TextBox CssClass="inpt" ID="txtMesaj" runat="server" Height="70px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button CssClass="inpt btn" ID="Button1" runat="server" Text="Gönder" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
    </div>
</asp:Content>

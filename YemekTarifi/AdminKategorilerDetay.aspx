<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminKategorilerDetay.aspx.cs" Inherits="YemekTarifi.AdminKategorilerDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="kategori-detay-tabel">
        <tr>
            <td class="kategori-detay-left">Kategori Ad:</td>
            <td>
                <asp:TextBox CssClass="input" ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="kategori-detay-left">Adet:</td>
            <td>
                <asp:TextBox CssClass="input" ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="kategori-detay-left">Resim:</td>
            <td class="auto-style2">
                <asp:FileUpload CssClass="input" ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button CssClass="kategori-detay-btn" ID="Button1" runat="server" Text="Güncelle" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>

</asp:Content>

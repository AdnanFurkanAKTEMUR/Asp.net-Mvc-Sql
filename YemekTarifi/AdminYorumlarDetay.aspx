<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminYorumlarDetay.aspx.cs" Inherits="YemekTarifi.AdminYorumlarDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="admin-yemekler-header">
        <h1>Yorum Düzenle</h1>
    </div>
    <table class="yemek-detay-tbl">
        <tr>
            <td class="ilk-td">Ad Soyad:</td>
            <td>
                <asp:TextBox CssClass="input" ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="ilk-td">Mail:</td>
            <td>
                <asp:TextBox CssClass="input" ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="ilk-td">Tarih:</td>
            <td>
                <asp:TextBox CssClass="input" ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="ilk-td">Onay Durumu:</td>
            <td>
                <asp:TextBox CssClass="input" ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="ilk-td">İçerik:</td>
            <td>
                <asp:TextBox CssClass="input" Height="200px" ID="TextBox5" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td class="ilk-td">Yemek:</td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server" CssClass="input"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td class="ilk-td">&nbsp;</td>
            <td>
                <asp:Button CssClass="yemekekle-eklebtn" ID="Button1" runat="server" Text="Onayla" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

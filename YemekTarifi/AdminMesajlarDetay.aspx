<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminMesajlarDetay.aspx.cs" Inherits="YemekTarifi.AdminMesajlarDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="admin-yemekler-header">
        <h1>Mesaj Düzenle</h1>
    </div>
    <table class="yemek-detay-tbl">
        <tr>
            <td class="ilk-td">Mesaj Gönderen:</td>
            <td>
                <asp:TextBox CssClass="input" ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="ilk-td">Başlık:</td>
            <td>
                <asp:TextBox CssClass="input" ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="ilk-td">Mail Adresi:</td>
            <td>
                <asp:TextBox CssClass="input" ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="ilk-td">Mesaj İçeriği:</td>
            <td>
                <asp:TextBox CssClass="input" Height="300px" ID="TextBox4" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="ilk-td">&nbsp;</td>
            <td>
                <asp:Button CssClass="yemekekle-eklebtn" ID="Button1" runat="server" Text="Sil" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>

</asp:Content>

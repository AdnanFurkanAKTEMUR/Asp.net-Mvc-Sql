<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminGununYemegiDetay.aspx.cs" Inherits="YemekTarifi.AdminGununYemegiDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 25px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="admin-yemekler-header">
        <h1>Günün Yemeği</h1>
    </div>

    <table class="yemek-detay-tbl">
        <tr>
            <td class="ilk-td">Yemek Adı:</td>
            <td class="auto-style1">
                <asp:TextBox CssClass="input" ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="ilk-td">Yemek Malzemeleri:</td>
            <td>
                <asp:TextBox CssClass="input" Height="150px" ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="ilk-td">Yemek Tarifi:</td>
            <td>
                <asp:TextBox CssClass="input" Height="200px" ID="TextBox3" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="ilk-td">Yemek Eklenme Tarihi:</td>
            <td>
                <asp:TextBox CssClass="input" ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="ilk-td">Yemek Puanı:</td>
            <td class="auto-style1">
                <asp:TextBox CssClass="input" ID="TextBox5" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="ilk-td">Yemek Durumu:</td>
            <td>
                <asp:TextBox CssClass="input"  ID="TextBox6" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="ilk-td">&nbsp;</td>
            <td>
                <asp:Button CssClass="show-btn" Width="300px" ID="Button1" runat="server" Text="Günün Yemeği Yap" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="TarifOner.aspx.cs" Inherits="YemekTarifi.TarifOner" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: right;
        }
        .auto-style3 {
            text-align: center;
            width: 1076px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1 tbl">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Tarif Adı:</td>
            <td>
                <asp:TextBox CssClass="inpt" ID="TxtTarifAd" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Malzemeler:</td>
            <td>
                <asp:TextBox CssClass="inpt" ID="TxtTarifMalzeme" runat="server" Height="45px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Yapılışı:</td>
            <td>
                <asp:TextBox CssClass="inpt" ID="TxtTarifYapilisi" runat="server" Height="59px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Resim:</td>
            <td>
                <asp:FileUpload CssClass="inpt" ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Tarif Öneren:</td>
            <td>
                <asp:TextBox CssClass="inpt" ID="TxtTarifOneren" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Mail Adresi</td>
            <td>
                <asp:TextBox CssClass="inpt" ID="TxtTarifMail" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <table class="tbl" style="width:100%">
        <tr>
            <td>
                <asp:Button CssClass="btn inpt" ID="TarifGonder" runat="server" Text="Tarifi Gönder" OnClick="TarifGonder_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

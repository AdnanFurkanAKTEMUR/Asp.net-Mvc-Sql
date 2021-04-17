<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminTarifOnerDetay.aspx.cs" Inherits="YemekTarifi.AdminTarifOnerDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="admin-yemekler-header">
        <h1>Tarif Önerileri</h1>
    </div>
    <table class="yemek-detay-tbl">
        <tr>
            <td class="ilk-td">Tarif Adı:</td>
            <td>
                <asp:TextBox CssClass="input" ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="ilk-td">Tarif Malzemeleri:</td>
            <td>
                <asp:TextBox CssClass="input" ID="TextBox2" runat="server" Height="150px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="ilk-td">Yapılışı:</td>
            <td>
                <asp:TextBox CssClass="input" ID="TextBox3" runat="server" Height="200px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="ilk-td">Tarif Resmi:</td>
            <td>
                <asp:FileUpload CssClass="input" ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="ilk-td">Tarif Öneren:</td>
            <td>
                <asp:TextBox CssClass="input" ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="ilk-td">Öneren Mail:</td>
            <td>
                <asp:TextBox CssClass="input" ID="TextBox5" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="ilk-td">Kategori:</td>
            <td>
                <asp:DropDownList CssClass="input" ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="ilk-td">&nbsp;</td>
            <td>
                <asp:Button CssClass="show-btn" ID="Button1" runat="server" Text="Onayla" OnClick="Button1_Click" Width="300px" />
            </td>
        </tr>
    </table>
</asp:Content>

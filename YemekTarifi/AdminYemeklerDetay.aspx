<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminYemeklerDetay.aspx.cs" Inherits="YemekTarifi.AdminYemeklerDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="admin-yemekler-header">
        <h1>Yemek Detayları</h1>
    </div>
    <table class="yemek-detay-tbl">
        <tr>
            <td class="ilk-td">Yemek Adı:</td>
            <td>
                <asp:TextBox CssClass="input" ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="ilk-td">Yemek Malzemeleri:</td>
            <td>
                <asp:TextBox CssClass="input"  Height="200px" ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="ilk-td">Yemek Tarifi:</td>
            <td>
                <asp:TextBox CssClass="input" Height="200px" ID="TextBox3" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="ilk-td">Yemek Kategorisi:</td>
            <td>
                <asp:DropDownList CssClass="input" ID="DropDownList1" runat="server"  AppendDataBoundItems="False">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="ilk-td">&nbsp;</td>
            <td>
                <asp:Button CssClass="yemekekle-eklebtn" ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>

</asp:Content>

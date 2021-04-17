<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminYemekler.aspx.cs" Inherits="YemekTarifi.AdminYemekler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="admin-yemekler-header">
        <h1>Yemekler</h1>
        <button class="show-btn">Göster</button>
    </div> 

    <asp:DataList CssClass="admin-yemekler-datalist" ID="DataList1" runat="server">
        <ItemTemplate>
            <div class="yemek-ad">
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("YemekAd") %>'></asp:Label>
                <div class="yemekler-icons">
                    <a href="AdminYemeklerDetay.aspx?Yemekid=<%#Eval("Yemekid") %>&Kategoriid=<%#Eval("Kategoriid") %>">
                        <i class="far fa-edit"></i>
                    </a>
                    <a href="AdminYemekler.aspx?Yemekid=<%# Eval("Yemekid") %>&Kategoriid=<%#Eval("Kategoriid")%>&islem=sil">
                        <i class="far fa-trash-alt"></i>
                    </a>
                </div>
            </div>
        </ItemTemplate>
    </asp:DataList>
    <div class="admin-yemekler-yemekekle">
        <div class="yemekekle-header">
            <h1>Yemek Ekle</h1>
            <button class="show-btn">Göster</button>
        </div>
        <table class="yemekekle-tbl">
            <tr>
                <td class="ilk-td">Yemek Adı:</td>
                <td>
                    <asp:TextBox CssClass="input" ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="ilk-td">Yemek Malzemeleri:</td>
                <td>
                    <asp:TextBox CssClass="input" Height="200px" ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="ilk-td">Yemek Tarifi:</td>
                <td>
                    <asp:TextBox CssClass="input" ID="TextBox3" Height="300px" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="ilk-td">Yemek Kategorisi:</td>
                <td>
                    <asp:DropDownList CssClass="input" ID="DropDownList1" runat="server" AppendDataBoundItems="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="ilk-td">&nbsp;</td>
                <td>
                    <asp:Button CssClass="yemekekle-eklebtn" ID="Button1" runat="server" Text="Kaydet" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

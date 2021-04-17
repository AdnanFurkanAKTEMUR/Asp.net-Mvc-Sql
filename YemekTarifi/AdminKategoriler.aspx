<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminKategoriler.aspx.cs" Inherits="YemekTarifi.AdminKategoriler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="kategoriler-header">
        <h1>Kategoriler</h1>
        <button class="goster-gizle">Göster</button>
    </div>
    <asp:DataList CssClass="kategoriler-datalist" ID="DataList1" runat="server">
        <ItemTemplate>
            <div class="gelen-kategori">

                <asp:Label ID="Label1" runat="server" Text='<%# Eval("KategoriAd") %>'></asp:Label>

                <div class="kategoriler-icons">
                    <a href="AdminKategorilerDetay.aspx?Kategoriid=<%#Eval("Kategoriid")%>">
                        <i class="far fa-edit"></i>
                    </a>
                    <a href="AdminKategoriler.aspx?Kategoriid=<%#Eval("Kategoriid") %>&islem=sil">
                        <i class="far fa-trash-alt"></i>
                    </a>
                </div>
            </div>
            <hr />
        </ItemTemplate>
    </asp:DataList>
    <div class="kategoriler-kategori-ekle">
        <div class="kategoriler-header">
            <h1>Kategori Ekle</h1>
            <button class="goster-gizle" id="goster-gizle">Göster</button>

        </div>
        <table class="kategoriler-tbl">
            <tr>
                <td class="kategoriler-ilk-sutun">Kategori Ad:</td>
                <td>
                    <asp:TextBox CssClass="kategoriler-inpt" ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="kategoriler-ilk-sutun">Kategori Icon:</td>
                <td>
                    <asp:FileUpload CssClass="kategoriler-inpt" ID="FileUpload1" runat="server" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    
                    <asp:Button CssClass="kategoriler-ekle-btn" ID="Button1" runat="server" Text="Gönder" OnClick="Button1_Click" />
                        
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

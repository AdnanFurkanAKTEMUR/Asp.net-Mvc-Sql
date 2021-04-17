<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="Hakkimizda.aspx.cs" Inherits="YemekTarifi.Hakkimizda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="tbl">
    <div class="baslik">
        <h1>Hakkımızda</h1>
    </div>
    <asp:DataList ID="DataList2" runat="server">
        <ItemTemplate>
            <p class="hakkimizda">
                <asp:Label ID="Label4" runat="server" Text='<%# Eval("Metin") %>'></asp:Label>
            </p>
            
        </ItemTemplate>
    </asp:DataList>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminHakkimizda.aspx.cs" Inherits="YemekTarifi.AdminHakkimizda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="admin-yemekler-header">
        <h1>Hakkımızda</h1>
    </div>
    <div class="center">
        <asp:TextBox CssClass="input" ID="TextBox1" runat="server" Height="600px" TextMode="MultiLine" Width="90%"></asp:TextBox>
        <asp:Button ID="Button1" CssClass="show-btn" runat="server" OnClick="Button1_Click" Width="90%" Text="Güncelle" />
    </div>
</asp:Content>

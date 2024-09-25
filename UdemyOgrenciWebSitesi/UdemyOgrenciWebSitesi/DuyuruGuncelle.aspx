<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.master" AutoEventWireup="true" CodeFile="DuyuruGuncelle.aspx.cs" Inherits="DuyuruGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <form id="Form1" runat="server">
<div class="form-group">
    <div>
        <asp:Label for="TxtDuyuruId" runat="server">Duyuru ID</asp:Label>
        <asp:TextBox ID="TxtDuyuruId" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label for="txtDuyuruBaslik" runat="server">Duyuru Başlık</asp:Label>
        <asp:TextBox ID="txtDuyuruBaslik" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Label for="TextArea1" runat="server">Duyuru İçerik</asp:Label>
        <textarea id="TextArea1" cols="20" rows="6" class="form-control" runat="server"></textarea>
    </div>
    </div>
    <asp:Button ID="btnDuyuruGuncelle" runat="server" Text="Güncelle" CssClass="btn btn-info" OnClick="btnDuyuruGuncelle_Click"/>
    </form>

</asp:Content>


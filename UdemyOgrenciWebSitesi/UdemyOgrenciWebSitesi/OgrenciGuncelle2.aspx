<%@ Page Title="" Language="C#" MasterPageFile="~/Ogrenci.master" AutoEventWireup="true" CodeFile="OgrenciGuncelle2.aspx.cs" Inherits="OgrenciGuncelle2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <asp:TextBox ID="textbox1" runat="server" CssClass="form-control">Numara</asp:TextBox>
            </div>
            <br />
            <div>
                <asp:TextBox ID="txtSifre1" runat="server" CssClass="form-control">Şifre</asp:TextBox>
            </div>
            <br />
        </div>
        <asp:Button ID="btnDuyuruGuncelle" runat="server" Text="Güncelle" CssClass="btn btn-success" OnClick="btnDuyuruGuncelle_Click" />
    </form>

</asp:Content>


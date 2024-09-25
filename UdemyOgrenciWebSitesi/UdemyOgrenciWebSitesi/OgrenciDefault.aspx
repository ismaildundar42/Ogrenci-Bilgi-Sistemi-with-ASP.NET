<%@ Page Title="" Language="C#" MasterPageFile="~/Ogrenci.master" AutoEventWireup="true" CodeFile="OgrenciDefault.aspx.cs" Inherits="OgrenciDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <asp:TextBox ID="textbox1" runat="server" CssClass="form-control" Enabled="False">Numara</asp:TextBox>
            </div>
            <br />
            <div>
                <asp:TextBox ID="textbox2" runat="server" CssClass="form-control" Enabled="False">Ad Soyad</asp:TextBox>
            </div>
            <br />

            <div>
                <asp:TextBox ID="textbox3" runat="server" CssClass="form-control" Enabled="False">Mail</asp:TextBox>
            </div>
            <br />

            <div>
                <asp:TextBox ID="textbox5" runat="server" CssClass="form-control" Enabled="False">Telefon</asp:TextBox>
            </div>
            <br />
            <div>
                <asp:TextBox ID="textbox6" runat="server" CssClass="form-control" Enabled="False">Şifre</asp:TextBox>
            </div>
            <br />
            <div>
                <asp:TextBox ID="textbox7" runat="server" CssClass="form-control" Enabled="False">Cinsiyet</asp:TextBox>
            </div>
            <br />
            <div>
                <asp:TextBox ID="textbox4" runat="server" CssClass="form-control" Enabled="False">Fotoğraf</asp:TextBox>
            </div>
            <br />

        </div>
         <asp:Button ID="btnDuyuruGuncelle" runat="server" Text="Şifre Güncelle" CssClass="btn btn-info" OnClick="btnDuyuruGuncelle_Click"/>
    </form>


</asp:Content>


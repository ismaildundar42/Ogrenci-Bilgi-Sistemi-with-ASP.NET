
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Dosyalar1/bootstrap.min.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 850px;
            margin: auto;
        }
        .auto-style2 {
            text-align: center;
            color: #FFFFFF;
            font-size: x-large;
            font-family: "Segoe Script";
        }
        .auto-style3 {
            color: #FFFFFF;
        }
    </style>
</head>
<body style="background-image: url('ogrenciler/space.jpg')">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <br />
            <br />
            <h4 class="auto-style2"><strong>UDEMY WEB ÖĞRENCİ NOT SİSTEMİ</strong></h4>
            <br />
            <br />
            <br />
            <div style="margin:auto" class="text-center">
                <asp:Image ID="Image1" runat="server" Height="100px" ImageUrl="~/ogrenciler/login.png" Width="100px" />
            </div>

            <br />
            <br />
            <div>
                <strong>
                <asp:Label for="txtKullaniciAdi" runat="server" CssClass="auto-style3">Kullanıcı Adı</asp:Label>
                <asp:TextBox ID="txtKullaniciAdi" runat="server" CssClass="form-control"></asp:TextBox>
                </strong>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="txtSifre" runat="server" CssClass="auto-style3">Şifre</asp:Label>
                <asp:TextBox ID="txtSifre" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                </strong>
            </div>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Giriş Yap" CssClass="btn btn-success" Width="850px" OnClick="Button1_Click" />
            <br />
            <br />
             <asp:Button ID="btnIptalEt" runat="server" Text="İptal Et" CssClass="btn btn-danger" Width="420px" />
            <asp:Button ID="btnSifremiUnuttum" runat="server" Text="Şifremi Unuttum" CssClass="btn btn-warning" Width="420px" />
            <br />
            <br />
            <asp:Button ID="btnYardim" runat="server" Text="Yardım Et" CssClass="btn btn-info" Width="850px" />
        </div>

    </form>
</body>
</html>

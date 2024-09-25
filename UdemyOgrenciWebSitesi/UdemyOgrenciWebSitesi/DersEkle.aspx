<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.master" AutoEventWireup="true" CodeFile="DersEkle.aspx.cs" Inherits="DersEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <form id="Form1" runat="server">
        <div class="form-group">
           
            <div>
                <asp:Label for="txtDersAdı" runat="server">Ders Adı</asp:Label>
                <asp:TextBox ID="txtDersAdı" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
        </div>
       <asp:Button ID="btnDersEkle" runat="server" Text="Oluştur" CssClass="btn btn-info" OnClick="btnDersEkle_Click" />
    </form>
     
</asp:Content>


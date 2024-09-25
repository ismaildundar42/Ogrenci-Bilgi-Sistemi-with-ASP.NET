<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.master" AutoEventWireup="true" CodeFile="DuyuruListesi.aspx.cs" Inherits="DuyuruListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

     <table class="table table-bordered table-hover">
     <tr>
         <th scope="col">DUYURU ID</th>
         <th scope="col">DUYURU BAŞLIK</th>
         <th scope="col">DUYURU İÇERİK</th>
         <th scope="col">ÖĞRETMEN</th>
         <th scope="col">İŞLEMLER</th>
     </tr>

     <tbody>
         <asp:Repeater ID="Repeater1" runat="server">
             <ItemTemplate>
                 <tr>
                     <td><%# Eval("DUYURUID") %></td>
                     <td><%# Eval("DUYURUBASLIK") %></td>
                     <td><%# Eval("DUYURUICERIK") %></td>
                     <td><%# Eval("DUYURUOGRT") %></td>
                     <td>
                         <asp:HyperLink NavigateUrl='<%# "Duyurusil.aspx?DUYURUID="+Eval("DUYURUID")%>' ID="HyperLink1"  runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink>
                         <asp:HyperLink NavigateUrl='<%# "DuyuruGuncelle.aspx?DUYURUID="+Eval("DUYURUID")%>' ID="HyperLink2"  runat="server" CssClass="btn btn-success">GÜNCELLE</asp:HyperLink>
                     </td>
                 </tr>
             </ItemTemplate>
         </asp:Repeater>
     </tbody>
 </table>

<%--    NavigateUrl='<%#"~/OgrenciSil.aspx?OGRID="+Eval("OGRID") %>'--%>



</asp:Content>


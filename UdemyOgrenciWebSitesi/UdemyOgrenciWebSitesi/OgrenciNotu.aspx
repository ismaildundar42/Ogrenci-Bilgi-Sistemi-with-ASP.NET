<%@ Page Title="" Language="C#" MasterPageFile="~/Ogrenci.master" AutoEventWireup="true" CodeFile="OgrenciNotu.aspx.cs" Inherits="OgrenciNotu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <table class="table table-bordered table-hover">
        <tr>
            <th scope="col">OGRENCI ID</th>
            <th scope="col">AD SOYAD</th>
            <th scope="col">DERS AD</th>
            <th scope="col">1.SINAV</th>
            <th scope="col">2.SINAV</th>
            <th scope="col">3.SINAV</th>
            <th scope="col">ORTALAMA</th>
            <th scope="col">DURUM</th>
            <th scope="col">GUNCELLE</th>
        </tr>
 <tbody>
     <asp:Repeater ID="Repeater1" runat="server">
         <ItemTemplate>
             <tr>
                 <td><%# Eval("OGRID") %></td>
                 <td><%# Eval("OGRENCİADSOYAD") %></td>
                 <td><%# Eval("DERSAD") %></td>
                 <td><%# Eval("SINAV1") %></td>
                 <td><%# Eval("SINAV2") %></td>
                 <td><%# Eval("SINAV3") %></td>
                 <td><%# Eval("ORTALAMA") %></td>
             </tr>
         </ItemTemplate>
     </asp:Repeater>
 </tbody>
    </table>

</asp:Content>


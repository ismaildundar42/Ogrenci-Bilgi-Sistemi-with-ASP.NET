<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.master" AutoEventWireup="true" CodeFile="GelenMesajlar.aspx.cs" Inherits="GelenMesajlar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <table class="table table-bordered table-hover">
        <tr>
            <th scope="col">MESAJ ID</th>
            <th scope="col">GONDEREN</th>
            <th scope="col">MESAJ BAŞLIK</th>
            <th scope="col">MESAJ İÇERİK</th>
            <th scope="col">TARIH</th>
            <th scope="col">İŞLEMLER</th>
        </tr>

        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <itemtemplate>
                    <tr>
                        <td><%# Eval("MESAJID") %></td>
                        <td><%# Eval("GONDEREN") %></td>
                        <td><%# Eval("BASLIK") %></td>
                        <td><%# Eval("ICERIK") %></td>
                        <td><%# Eval("TARIH") %></td>
                        <%-- <td>
                        <asp:HyperLink NavigateUrl='<%# "Duyurusil.aspx?DUYURUID="+Eval("DUYURUID")%>' ID="HyperLink1"  runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink>
                        <asp:HyperLink NavigateUrl='<%# "DuyuruGuncelle.aspx?DUYURUID="+Eval("DUYURUID")%>' ID="HyperLink2"  runat="server" CssClass="btn btn-success">GÜNCELLE</asp:HyperLink>
                    </td>--%>
                    </tr>
                </itemtemplate>
            </asp:Repeater>
        </tbody>
    </table>

</asp:Content>


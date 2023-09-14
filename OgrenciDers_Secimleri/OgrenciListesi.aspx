<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeFile="OgrenciListesi.aspx.cs" Inherits="OgrenciDers_Secimleri.OgrenciListesi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered table-hover">
        <tr>
            <th>OGRENCI ID</th>
            <th>OGRENCI ADI</th>
            <th>OGRENCI SOYADI</th>
            <th>OGRENCI NUMARA</th>
            <th>OGRENCI SIFRESI</th>
            <th>OGRENCI FOTORAFI</th>
            <th>OGRENCI BAKIYE</th>
            <th>İŞLEMLER</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
            <td><%#Eval("ID")%></td>
            <td><%#Eval("AD")%></td>
            <td><%#Eval("SOYAD")%></td>
            <td><%#Eval("NUMARA")%></td>
            <td><%#Eval("SIFRE")%></td>
            <td><%#Eval("FOTOGRAF") %></td>
            <td><%#Eval("BAKIYE")%></td> 
                        <td>

                            <asp:HyperLink  NavigateUrl='<%# "~/OgrenciSil.aspx?OGRID="+Eval("ID") %>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                            <asp:HyperLink  NavigateUrl='<%# "~/OgrenciGuncelle.aspx?OGRID="+Eval("ID") %>' ID="HyperLink2" CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                           
                        </td>
                        </tr>
              </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>


</asp:Content>

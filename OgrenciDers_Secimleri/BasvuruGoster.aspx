<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="BasvuruGoster.aspx.cs" Inherits="OgrenciDers_Secimleri.BasvuruGoster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered table-hover">
        <tr>
            
            <th>OGRENCI ADI</th>
            <th>OGRENCI SOYADI</th>
            <th>OGRENCI DERS</th>
            
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
            
            <td><%#Eval("OGRAD")%></td>
            <td><%#Eval("OGRSOYAD")%></td>
            <td><%#Eval("OGRDERS")%></td>
            
                        
                        </tr>
              </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>

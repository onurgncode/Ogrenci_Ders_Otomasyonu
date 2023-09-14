<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Dersler.aspx.cs" Inherits="OgrenciDers_Secimleri.Dersler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server">
        <table class="table">
            <tr><td>
                <asp:Label ID="Label1" runat="server" Text="Ders Seçiniz"></asp:Label>

                </td>
                <td>
        <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server"></asp:DropDownList>

                </td>
        </tr>
            <tr><td>
        <asp:Label ID="Label2" runat="server" Text="OGRENCI ID"></asp:Label></td>
                <td>
        <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox></td>
                </tr>
            <tr><td>
                <asp:Button ID="Button1" runat="server" CssClass="btn btn-danger" Text="Ders talep oluştur" OnClick="Button1_Click" />

                </td></tr>
            </table>
    </form>


</asp:Content>

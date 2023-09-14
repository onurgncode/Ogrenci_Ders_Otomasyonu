<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeFile="OgrenciGuncelle.aspx.cs" Inherits="OgrenciDers_Secimleri.OgrenciGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server" >
        <table class="table table-bordered">
            <tr>
            <td>Öğrenci ID</td>
            <td>
                <asp:TextBox ID="txt_id" runat="server" CssClass="w-100" Width="152px"></asp:TextBox><br />
            </td>
       </tr>
        <tr>
            <td>Öğrenci Adı :</td>
            <td>
                <asp:TextBox ID="txt_ad" runat="server" CssClass="w-100" Width="152px"></asp:TextBox><br />
            </td>
       </tr>
            <tr>
            <td>Öğrenci Soyadı :</td>
            <td>
                <asp:TextBox ID="txt_soyad" runat="server" CssClass="w-100" Width="152px"></asp:TextBox><br />
            </td>
                </tr>
            <tr>
            <td> Öğrenci Numara :</td>
            <td>
               <asp:TextBox ID="txt_numara" runat="server" CssClass="w-100" Width="152px"></asp:TextBox><br />
            </td>
                </tr>
            <tr>
            <td> Öğrenci Şifre :</td>
            <td>
               <asp:TextBox ID="txt_sifre" runat="server" CssClass="w-100" Width="152px"></asp:TextBox><br />
            </td>
                </tr>
            <tr>
            <td> Öğrenci Fotoraf :</td>
            <td>
                <asp:TextBox ID="txt_foto" runat="server" CssClass="w-100" Width="152px"></asp:TextBox><br />
            </td> 
        </tr>
            
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" CssClass="btn btn-danger" Text="Kaydet" OnClick="Button1_Click"/>
            </td>
        </tr>
         
        
            </table>
    </form>
</asp:Content>

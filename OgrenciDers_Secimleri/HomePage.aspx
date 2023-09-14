<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="OgrenciDers_Secimleri.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bg-image" 
     style="background-image: url('img/logo.gif');
            height: 100vh">
         <div class="card-body shadow text-capitalize">
        <div class="row">
            <div class="h1">
                Bu Proje Onur Doğan Tarafından Yapılmıştır.
            </div>
            <div class="p-1">
                <div class="list-group">
                <li>Öğrenci Otomasyon "curd" işlemleri yapılabiliyor.</li>
                    <li>Başvuru Kısmında iki sql tablosundan alınan veri birleştirilrek başvuru tablosu yapıldı</li>
                    </div>
                
            </div>
        </div>
    </div>
    </div>
   
</asp:Content>

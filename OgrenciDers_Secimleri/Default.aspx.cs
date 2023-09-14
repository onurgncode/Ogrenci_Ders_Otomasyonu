using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;
namespace OgrenciDers_Secimleri
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            {
                ent.Ad = txt_ad.Text;
                ent.Soyad = txt_soyad.Text;
                ent.Numara = txt_numara.Text;
                ent.Sifre = txt_sifre.Text;
                ent.Fotograf = txt_foto.Text;
                BLLOgrenci.OgrenciEkleBLL(ent);
            }
            Response.Redirect("Default.aspx");
            
            
        }
        
    }
}
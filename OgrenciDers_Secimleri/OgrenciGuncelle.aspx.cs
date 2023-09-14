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
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OGRID"].ToString());
            txt_id.Text = x.ToString();
            txt_id.Enabled = false;
            

            if(Page.IsPostBack == false)
            { 
                List<EntityOgrenci> OgrList = BLLOgrenci.BllDetay(x);
                txt_ad.Text = OgrList[0].Ad.ToString();
                txt_soyad.Text = OgrList[0].Soyad.ToString();
                txt_numara.Text = OgrList[0].Numara.ToString();
                txt_sifre.Text = OgrList[0].Sifre.ToString();
                txt_foto.Text = OgrList[0].Fotograf.ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            
            ent.Ad = txt_ad.Text;
            ent.Soyad = txt_soyad.Text;
            ent.Numara = txt_numara.Text;
            ent.Sifre = txt_sifre.Text;
            ent.Fotograf = txt_foto.Text;
            ent.Id = Convert.ToInt32(txt_id.Text);
            BLLOgrenci.OgrenciGuncelleBLL(ent);
            Response.Redirect("OgrenciListesi.aspx");
            
        }
    }
}
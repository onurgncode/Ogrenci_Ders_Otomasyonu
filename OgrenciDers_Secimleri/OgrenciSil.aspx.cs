using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using EntityLayer;
using BusinessLogicLayer;
namespace OgrenciDers_Secimleri
{
    public partial class OgrenciSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            int x = Convert.ToInt32(Request.QueryString["OGRID"]);
            EntityOgrenci ent = new EntityOgrenci();
            ent.Id = x;
            BLLOgrenci.OgrenciSilBLL(ent.Id);
            
            Response.Redirect("OgrenciListesi.aspx");

        }
    }
}
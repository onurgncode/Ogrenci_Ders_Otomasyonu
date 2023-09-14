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
    public partial class BasvuruGoster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityDersListe> OgrList = BLLDersListe.BllListele();
            Repeater1.DataSource = OgrList;
            Repeater1.DataBind();
        }
    }
}
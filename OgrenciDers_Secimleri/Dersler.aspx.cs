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
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack == false)
            { 
            List<EntityDers> entDers = BLLDers.BllListele();
            DropDownList1.DataSource = BLLDers.BllListele();
            
            DropDownList1.DataTextField = "DERSAD";
            DropDownList1.DataValueField = "ID";
            DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //TextBox1.Text = DropDownList1.SelectedValue.ToString(); Bu Drop down için value çekmek için kullandım.
            EntityBasvuruForm ent = new EntityBasvuruForm();
            ent.Basogrid = int.Parse(TextBox1.Text);
            ent.Basdersid = int.Parse(DropDownList1.SelectedValue.ToString());
            BLLDers.TalepEkleBLL(ent);

        }
    }
}
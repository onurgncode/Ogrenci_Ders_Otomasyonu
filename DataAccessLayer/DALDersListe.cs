using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public class DALDersListe
    {
        public static List<EntityDersListe> DersListesi()
        {
            

            List<EntityDersListe> degerler = new List<EntityDersListe>();
            SqlCommand komut2 = new SqlCommand("SELECT TBLOGRENCI.OGRAD,TBLOGRENCI.OGRSOYAD,TBLDERSLER.DERSAD FROM TBLBASVURUFORM inner join TBLOGRENCI  on TBLBASVURUFORM.OGRENCIID = TBLOGRENCI.OGRID inner join TBLDERSLER on TBLBASVURUFORM.DERSID = TBLDERSLER.DERSID", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityDersListe ent = new EntityDersListe();
                
                ent.Ograd = dr["OGRAD"].ToString();
                ent.Ogrsoyad = dr["OGRSOYAD"].ToString();
                ent.Ogrders = dr["DERSAD"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
    }
}

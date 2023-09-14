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
    public class DALDers
    {
        public static List<EntityDers> DersListesi()
        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand komut2 = new SqlCommand("Select * from TBLDERSLER", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.Id = Convert.ToInt32(dr["DERSID"].ToString());
                ent.DersAd = dr["DERSAD"].ToString();
                ent.Max = Convert.ToInt32(dr["DERSMAXKONTEJAN"].ToString());
                ent.Min = Convert.ToInt32(dr["DERSMINKONTENJAN"].ToString());

                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int TalepEkle(EntityBasvuruForm parametre)
        {
            SqlCommand komut = new SqlCommand("insert into TBLBASVURUFORM(OGRENCIID,DERSID) values (@P1,@P2)", Baglanti.bgl);
            komut.Parameters.AddWithValue("@P1", parametre.Basogrid);
            komut.Parameters.AddWithValue("@P2", parametre.Basdersid);
            if(komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            return komut.ExecuteNonQuery();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;
namespace BusinessLogicLayer
{
    public class BLLDersListe
    {
        public static List<EntityDersListe> BllListele()
        {
            return DALDersListe.DersListesi();
        }
    }
}

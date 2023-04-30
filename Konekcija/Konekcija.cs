using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace HAUTE_HORLOGERIE.Konekcija
{
    internal class Konekcija
    {
        public static SqlConnection Konektuj()
        {
            SqlConnection veza = new SqlConnection(ConfigurationManager.ConnectionStrings["HAUTE_HORLOGERIE"].ConnectionString);
            return veza;
        }
    }
}

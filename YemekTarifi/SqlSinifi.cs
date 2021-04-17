using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace YemekTarifi
{
    public class SqlSinifi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-94NHF6M; Initial Catalog=Dbo_yemektarifi; Integrated Security=True;");
            baglan.Open();
            return baglan;
        }
    }
}
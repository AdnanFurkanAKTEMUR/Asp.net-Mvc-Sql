using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace YemekTarifi
{
    public partial class Iletisim : System.Web.UI.Page
    {
        SqlSinifi bgl = new SqlSinifi();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_mesaj (MesajBaslik,MesajMail,MesajIcerik,MesajGonderen) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKonu.Text);
            komut.Parameters.AddWithValue("@p2", TxtMail.Text);
            komut.Parameters.AddWithValue("@p3", txtMesaj.Text);
            komut.Parameters.AddWithValue("@p4", txtAdSoyad.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            txtAdSoyad.Text = "";
            TxtMail.Text = "";
            txtMesaj.Text = "";
            txtKonu.Text = "";
        }
    }
}
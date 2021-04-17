using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace YemekTarifi
{
    public partial class AdminTarifOnerDetay : System.Web.UI.Page
    {
        SqlSinifi bgl = new SqlSinifi();
        string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["Tarifid"];
            if (Page.IsPostBack == false)
            {
                SqlCommand getir = new SqlCommand("select * from tbl_tarifler where Tarifid=@p1", bgl.baglanti());
                getir.Parameters.AddWithValue("@p1", id);
                SqlDataReader rd = getir.ExecuteReader();
                while (rd.Read())
                {
                    TextBox1.Text = rd[1].ToString();
                    TextBox2.Text = rd[2].ToString();
                    TextBox3.Text = rd[3].ToString();
                    TextBox4.Text = rd[5].ToString();
                    TextBox5.Text = rd[6].ToString();
                }
                bgl.baglanti().Close();

                SqlCommand kategorileriGetir = new SqlCommand("select * from tbl_kategoriler", bgl.baglanti());
                SqlDataReader rd2 = kategorileriGetir.ExecuteReader();

                DropDownList1.DataTextField = "KategoriAd";
                DropDownList1.DataValueField = "Kategoriid";

                DropDownList1.DataSource = rd2;
                DropDownList1.DataBind();
                bgl.baglanti().Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand tarifDurumGuncelle = new SqlCommand("update tbl_tarifler set TarifDurum=1 where Tarifid=@p1", bgl.baglanti());
            tarifDurumGuncelle.Parameters.AddWithValue("@p1", id);
            tarifDurumGuncelle.ExecuteNonQuery();
            bgl.baglanti().Close();

            SqlCommand yemekEkle = new SqlCommand("INSERT INTO tbl_yemekler (YemekAd,YemekMalzeme,YemekTarif,Kategoriid) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            yemekEkle.Parameters.AddWithValue("@p1", TextBox1.Text);
            yemekEkle.Parameters.AddWithValue("@p2", TextBox2.Text);
            yemekEkle.Parameters.AddWithValue("@p3", TextBox3.Text);
            yemekEkle.Parameters.AddWithValue("@p4", DropDownList1.SelectedValue);
            yemekEkle.ExecuteNonQuery();
            bgl.baglanti().Close();

            SqlCommand kategoriArtir = new SqlCommand("update tbl_kategoriler set KategoriAdet=KategoriAdet+1 where Kategoriid=@p1", bgl.baglanti());
            kategoriArtir.Parameters.AddWithValue("@p1", DropDownList1.SelectedValue);
            kategoriArtir.ExecuteNonQuery();
            bgl.baglanti().Close();

            Response.Redirect("AdminTarifOner.aspx");
        }
    }
}
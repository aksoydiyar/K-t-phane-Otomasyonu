using Kutuphane.enum_aration;
using Kutuphane.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.data_connect
{
    public class Repository
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        int returnvalue;
        List<loginTable> login_table_list;
        public Repository()
        {
            con = new SqlConnection("Data Source=DIYAR\\SQLEXPRESS;Initial Catalog=Kutuphane;Persist Security Info=True;User ID=sa;Password=1");
            
        }
        public void baglantı_ayarla()
        {
            if (con.State==System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            else 
            { 
                con.Close(); 
            }
            
        }
        public kullanıcıı login(string kullaniciAdi, string Sifre)
        {
            con.Open();
            cmd = new SqlCommand("select*from login_Table where Kullanici_Adi=@kulad and Sifre=@sifre", con);
            cmd.Parameters.AddWithValue("@kulad", kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre",Sifre); 
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
               kullanıcıı kullanici = new kullanıcıı();
                kullanici.id = int.Parse(dr["id"].ToString());
                kullanici.Kullanici_Adi = dr["Kullanici_Adi"].ToString();
                kullanici.Sifre = dr["sifre"].ToString();
                kullanici.yetki = dr["yetki"].ToString();
                kullanici.Eposta = dr["E-posta"].ToString();
                kullanici.guvenli_soru=dr["guvenlik_sorusu"].ToString();
                kullanici.guvenlik_cvp=dr["guvenlik_cvp"].ToString();
                kullanici.status = login_durumu.başarılı;
                return kullanici;
                
            }
            else
            {
                kullanıcıı kullanici = new kullanıcıı();
                kullanici.status = login_durumu.başarısız;
                return kullanici;
                con.Close();
            }
            
           
        }
        public List<loginTable> getLoginTable()
        {
            login_table_list = new List<loginTable>();


            try
            {
                
                con.Open();
                cmd = new SqlCommand("guvenlikSorusuGetir_sp", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    loginTable l1 = new loginTable();
                    l1.id = int.Parse(dr["id"].ToString());
                    l1.Kullanici_Adi = dr["Kullanici_Adi"].ToString();
                    l1.Sifre = dr["Sifre"].ToString();
                    l1.yetki = dr["Yetki"].ToString();
                    l1.guvenli_soru = dr["Guvenlik_sorusu"].ToString();
                    l1.guvenlik_cvp = dr["Guvenlik_cvp"].ToString();
                    login_table_list.Add(l1);
                }
                con.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("hata oluştu");

            }
            return login_table_list;

        }
            
        public login_durumu doauthentication(string kullaniciAdi, string guvenlikSoru, string guvenlikCvp)
        {
            con.Open();
            cmd = new SqlCommand("SELECT COUNT(*) FROM login_table WHERE Kullanici_Adi=@kulAd AND Guvenlik_sorusu=@gvn_soru AND Guvenlik_cvp=@gvn_cvp", con);
            cmd.Parameters.AddWithValue("@kulAd", kullaniciAdi);
            cmd.Parameters.AddWithValue("@gvn_soru", guvenlikSoru);
            cmd.Parameters.AddWithValue("@gvn_cvp", guvenlikCvp);
            returnvalue=(int) cmd.ExecuteScalar();
            con.Close();
            if (returnvalue==1)
            {
               return login_durumu.başarılı;
            }
            else
            {
                return login_durumu.başarısız;
            }
        }

        public login_durumu changePassword( string kullaniciAdi  , string sifre  )
        {
            con.Open();
            cmd = new SqlCommand("sifreGuncelle_sp", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;//stored procedur olarak tanımlar1
            cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            cmd.Parameters.AddWithValue("@Sifre", sifre);
            returnvalue= cmd.ExecuteNonQuery();
            con.Close();
            return login_durumu.başarılı;


        }
        public List<kullanıcıı> tumKullanicilariGetir()

        {
            List<kullanıcıı> userList = new List<kullanıcıı>();
            con.Open();
            cmd = new SqlCommand("select * from login_table", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                kullanıcıı user = new kullanıcıı();
                user.id = int.Parse(dr["id"].ToString());
                user.Kullanici_Adi = dr["Kullanici_Adi"].ToString();
                user.Sifre = dr["Sifre"].ToString();
                user.yetki = dr["Yetki"].ToString();
                user.Eposta = dr["E-posta"].ToString();
                user.guvenli_soru = dr["Guvenlik_sorusu"].ToString();
                user.guvenlik_cvp = dr["Guvenlik_cvp"].ToString();
                userList.Add(user);
            }
            con.Close();
            return userList;
        }
         public login_durumu kullaniciEkle(kullanıcıı user)
        {
            con.Open();
            cmd = new SqlCommand("sp_kullaniciEkle", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@kullaniciAdi", user.Kullanici_Adi);
            cmd.Parameters.AddWithValue("@sifre", user.Sifre);
            cmd.Parameters.AddWithValue("@yetki", user.yetki);
            cmd.Parameters.AddWithValue("@emailAdres", user.Eposta);
            cmd.Parameters.AddWithValue("@guvenlikSorusu", user.guvenli_soru);
            cmd.Parameters.AddWithValue("@guvenlikCevabi", user.guvenlik_cvp);
             int returnvalue=  cmd.ExecuteNonQuery();
            con.Close();

            if (returnvalue == 1)
            {
                return login_durumu.başarılı;
            }
            else
            {
                return login_durumu.başarısız;
            }
        }
        public login_durumu kullaniciGuncelle(kullanıcıı user)
        {
            con.Open();
            cmd = new SqlCommand("sp_kullaniciGuncelleme", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", user.id);
            cmd.Parameters.AddWithValue("@kullaniciAdi", user.Kullanici_Adi);
            cmd.Parameters.AddWithValue("@sifre", user.Sifre);
            cmd.Parameters.AddWithValue("@yetki", user.yetki);
            cmd.Parameters.AddWithValue("@emailAdres", user.Eposta);
            cmd.Parameters.AddWithValue("@guvenlikSorusu", user.guvenli_soru);
            cmd.Parameters.AddWithValue("@guvenlikCevabi", user.guvenlik_cvp);
            int returnvalue = cmd.ExecuteNonQuery();
            con.Close();

            if (returnvalue == 1)
            {
                return login_durumu.başarılı;
            }
            return login_durumu.başarısız;
        }
        public login_durumu kullaniciSil(int id)
        {
            con.Open();
            cmd = new SqlCommand("delete from login_table where id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            int returnValue = cmd.ExecuteNonQuery();
            con.Close();

            if (returnValue == 1)
            {
                return login_durumu.başarılı;
            }
            else
            {
                return login_durumu.başarısız;

            }
        }
        public List<urun> tumUrunleriGetir()
        {
            List<urun> urunList = new List<urun>();
            con.Open();
            cmd = new SqlCommand("select * from kitap_tablosu", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                urun urun = new urun();
                urun.id = int.Parse(dr["id"].ToString());
                urun.kitapAd = dr["Kitap_ad"].ToString();
                urun.yazarAd = dr["yazar"].ToString();
                urun.adet = dr["adet"].ToString();

                urunList.Add(urun);
            }
            con.Close();
            return urunList;




        }
        public login_durumu urunEkle(urun urun)
        {
            con.Open();
            cmd = new SqlCommand("urun_ekle_sp", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@kitapAdi", urun.kitapAd);
            cmd.Parameters.AddWithValue("@yazarAdi", urun.yazarAd);
            cmd.Parameters.AddWithValue("@adet", urun.adet);
            int returnvalue = cmd.ExecuteNonQuery();
            con.Close();
            if (returnvalue == 1)
            {
                return login_durumu.başarılı;
            }
            return login_durumu.başarısız;
        }
        public login_durumu urunGuncelle(urun urun)
        {
            con.Open();
            cmd = new SqlCommand("urun_guncelleme_sp", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", urun.id);
            cmd.Parameters.AddWithValue("@kitapAdi", urun.kitapAd);
            cmd.Parameters.AddWithValue("@yazarAdi", urun.yazarAd);
            cmd.Parameters.AddWithValue("@adet", urun.adet);
          
            int returnvalue = cmd.ExecuteNonQuery();
            con.Close();
            if (returnvalue == 1)
            {
                return login_durumu.başarılı;
            }
            else
            {
                return login_durumu.başarısız;
            }
        }
        public login_durumu urunSil(string id)
        {
            con.Open();
            cmd = new SqlCommand("delete from kitap_tablosu where id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            int returnvalue = cmd.ExecuteNonQuery();
            con.Close();

            if (returnvalue == 1)
            {
                return login_durumu.başarılı;
            }
            return login_durumu.başarısız;
        }
        public login_durumu kullanıcıYazarAra(string kitapAd, string yazarAd)
        {
            con.Open();
            cmd = new SqlCommand("SELECT COUNT(*) FROM kitap_tablosu WHERE Kitap_ad=@kitapAd AND yazar=@yazar ", con);
            cmd.Parameters.AddWithValue("@kitapAd", kitapAd);
            cmd.Parameters.AddWithValue("@yazar", yazarAd);
            
            returnvalue = (int)cmd.ExecuteScalar();
            con.Close();
            if (returnvalue == 1)
            {
                return login_durumu.başarılı;
            }
            else
            {
                return login_durumu.başarısız;
            }
        }

    }
    }


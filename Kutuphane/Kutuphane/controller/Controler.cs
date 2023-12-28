using Kutuphane.data_connect;
using Kutuphane.enum_aration;
using Kutuphane.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.controller
{
    public class Controler
    {
        Repository repository;

        public Controler()
        {
            repository = new Repository();
        }
        public kullanıcıı login(string kullaniciAdi, string Sifre)
        {
            kullanıcıı result;
            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(Sifre))
            {
                result = repository.login(kullaniciAdi, Sifre);

                return result;
            }
            else
            {
                kullanıcıı user = new kullanıcıı();
                user.status = login_durumu.eksikParametre;
                return user;
            }
        }
        public List<loginTable> getLoginTable()
        {
           List<loginTable> login_table_list = repository.getLoginTable();
            return login_table_list;
        }
        public login_durumu doauthentication(string kullaniciAdi, string guvenlikSoru, string guvenlikCvp)
        {
            if (kullaniciAdi != null && guvenlikSoru != null && guvenlikCvp != null) 
            {
               login_durumu sonuc = repository.doauthentication(kullaniciAdi, guvenlikSoru, guvenlikCvp);
                if (sonuc == login_durumu.başarılı)
                {
                    return sonuc;
                }
                else
                {
                    return login_durumu.başarısız;
                }
            }
            else
            {
                return login_durumu.eksikParametre;
            }
            
        }
        public login_durumu changePassword(string kullaniciAdi, string sifre)
        {
            if (kullaniciAdi != null && sifre != null)
            {
                return repository.changePassword(kullaniciAdi, sifre);

            }
            else
            {
                return login_durumu.başarısız;
            }
        }
        public List<kullanıcıı> tumKullanicilariGetir()
        {
            Controler controller = new Controler();
            return repository.tumKullanicilariGetir();
        }
        public login_durumu kullaniciEkle(kullanıcıı user)
        {
            if (!string.IsNullOrEmpty(user.Kullanici_Adi) && !string.IsNullOrEmpty(user.Sifre) && !string.IsNullOrEmpty(user.yetki) && !string.IsNullOrEmpty(user.Eposta) && !string.IsNullOrEmpty(user.guvenli_soru) && !string.IsNullOrEmpty(user.guvenlik_cvp))
            {
                Controler controller = new Controler();
                login_durumu sonuc = repository.kullaniciEkle(user);
                return sonuc;
            }
            else
            {
                return login_durumu.eksikParametre;
            }
        }
        public login_durumu kullaniciGuncelle(kullanıcıı user)
        {
            return repository.kullaniciGuncelle(user);
        }
        public login_durumu kullaniciSil(int id)
        {
            if (!string.IsNullOrEmpty(id.ToString()))
            {
                return repository.kullaniciSil(id);
            }
            else
            {
                return login_durumu.eksikParametre;
            }

        }
        public List<urun> tumUrunleriGetir()
        {
            return repository.tumUrunleriGetir();
        }
        public login_durumu urunEkle(urun urun)
        {
            if (!string.IsNullOrEmpty(urun.kitapAd) && !string.IsNullOrEmpty(urun.yazarAd) && !string.IsNullOrEmpty(urun.adet))
            {
                return repository.urunEkle(urun);
            }
            else
            {
                return login_durumu.eksikParametre;
            }
        }
        public login_durumu urunGuncelle(urun urun)
        {
            if (!string.IsNullOrEmpty(urun.kitapAd) && !string.IsNullOrEmpty(urun.yazarAd) && !string.IsNullOrEmpty(urun.adet))
            {
                return repository.urunGuncelle(urun);
            }
            else
            {
                return login_durumu.eksikParametre;
            }
        }
        public login_durumu urunSil(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                return repository.urunSil(id);
            }
            else
            {
                return login_durumu.eksikParametre;
            }
        }
        public login_durumu kullanıcıYazarAra(string kitapAd, string yazarAd)
        {
            if (kitapAd != null || yazarAd != null )
            {
                login_durumu sonuc = repository.kullanıcıYazarAra(kitapAd, yazarAd);
                if (sonuc == login_durumu.başarılı)
                {
                    return sonuc;
                }
                else
                {
                    return login_durumu.başarısız;
                }
            }
            else
            {
                return login_durumu.eksikParametre;
            }
        }


    }
}


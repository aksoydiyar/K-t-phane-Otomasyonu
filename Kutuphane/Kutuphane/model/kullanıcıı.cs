using Kutuphane.enum_aration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.model
{
    public class kullanıcıı
    {
        public int id { get; set; }
        public string Kullanici_Adi { get; set; }
        public string Sifre { get; set; }
        public string yetki { get; set; }
        public string Eposta { get; set; }
        public string guvenli_soru { get; set; }
        public string guvenlik_cvp { get; set; }
        public login_durumu status { get; set; }
    }
}

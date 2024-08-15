using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kumbara1
{
    public class BozukPara : Para
    {
        public double Çap { get; set; }    // Bozuk paranın çapı
        public double Yükseklik { get; set; }  // Bozuk paranın yüksekliği

        public BozukPara(string isim, double değer, double çap, double yükseklik)
            : base(isim, değer)
        {
            Çap = çap;
            Yükseklik = yükseklik;
        }

        public override double Hacim()
        {
            double yarıÇap = Çap / 2;
            return Matematik.PI * Math.Pow(yarıÇap, 2) * Yükseklik;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kumbara1
{
    public class KağıtPara : Para
    {
        public double En { get; set; }      
        public double Boy { get; set; }      
        public double Yükseklik { get; set; }
        public bool Katlandı { get; private set; } = false;

        public KağıtPara(string isim, double değer, double en, double boy, double yükseklik)
            : base(isim, değer)
        {
            En = en;
            Boy = boy;
            Yükseklik = yükseklik;
            Katlandı = false;
        }

        public override double Hacim()

        {
            
            return En * Boy * Yükseklik;
        }

        
        public void Katla()
        {
            if (!Katlandı)
            {
            En /= 4;// Eni ¼’e düşür
            Yükseklik *= 4;    // Yüksekliği 4 katına çıkar
            Katlandı = true;// kağıt para katlandı
            }
           
           
        }
    }

}

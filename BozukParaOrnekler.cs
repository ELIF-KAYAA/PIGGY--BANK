using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kumbara1
{
    public static class BozukParaÖrnekleri
    {
        public static BozukPara BirKurus = new BozukPara("1 Kuruş", 0.01, 1.0, 0.1);
        public static BozukPara BesKurus = new BozukPara("5 Kuruş", 0.05, 1.5, 0.1);
        public static BozukPara OnKurus = new BozukPara("10 Kuruş", 0.10, 2.0, 0.1);
        public static BozukPara YirmiBesKurus = new BozukPara("25 Kuruş", 0.25, 2.5, 0.1);
        public static BozukPara ElliKurus = new BozukPara("50 Kuruş", 0.50, 2.8, 0.1);
        public static BozukPara BirTL = new BozukPara("1 TL", 1.00, 3.0, 0.2);
    }

}

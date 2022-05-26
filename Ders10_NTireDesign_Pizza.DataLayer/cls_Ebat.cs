using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10_NTireDesign_Pizza.DataLayer
{
    public class cls_Ebat
    {
        public string EbatAd { get; set; }
        public decimal EbatCarpan { get; set; }

        public override string ToString()
        {
            return EbatAd;
        }
    }
}

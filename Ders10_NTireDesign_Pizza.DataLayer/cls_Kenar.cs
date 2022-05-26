using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10_NTireDesign_Pizza.DataLayer
{
    public class cls_Kenar
    {
        public string KenarAd { get; set; }
        public decimal KenarlikFiyati { get; set; }

        public override string ToString()
        {
            return KenarAd;
        }
    }
}

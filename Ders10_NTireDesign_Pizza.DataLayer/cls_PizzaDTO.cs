using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10_NTireDesign_Pizza.DataLayer
{
    public class cls_PizzaDTO
    {
        public string PizzaAd { get; set; }
        public decimal PizzaFiyati { get; set; }
        public override string ToString()
        {
            return PizzaAd.ToUpper();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10_NTireDesign_Pizza.DataLayer
{
    public class cls_Siparis
    {
        public cls_Ebat Ebat { get; set; }
        public cls_PizzaDTO SecilenPizza { get; set; }
        public cls_Kenar Kenar { get; set; }
        public string Malzemeler { get; set; }
        public int Adet { get; set; }

        private decimal _PizzanınÜretilenFiyatı = 0m;
        public decimal PizzanınÜretilenFiyatı
        {
            get 
            { 
                _PizzanınÜretilenFiyatı = (Ebat.EbatCarpan * SecilenPizza.PizzaFiyati)+ Kenar.KenarlikFiyati;
                return _PizzanınÜretilenFiyatı; 
            }
        }

        private decimal _AraToplam = 0m;
        public decimal AraToplam
        {
            get
            {
                _AraToplam = Adet * PizzanınÜretilenFiyatı;
                return _AraToplam;
            }
        }

        public override string ToString()
        {
            return Ebat.EbatAd + " , " + SecilenPizza.PizzaAd + " , " + Kenar.KenarAd + " , " + Malzemeler + " , " + Adet + " , " + PizzanınÜretilenFiyatı + " = " + AraToplam;
        }
    }
}

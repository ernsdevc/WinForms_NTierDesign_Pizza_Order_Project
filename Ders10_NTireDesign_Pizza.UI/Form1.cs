using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ders10_NTireDesign_Pizza.DataLayer;

namespace Ders10_NTireDesign_Pizza.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PizzaDoldur();
            EbatDoldur();
            KenarlıkDoldur();
            btn_Sepete_Ekle.Enabled = false;
            btn_Siparisi_onayla.Enabled = false;
        }

        private void PizzaDoldur()
        {
            List<cls_PizzaDTO> pizzaListesi = new List<cls_PizzaDTO>()
            {
                new cls_PizzaDTO()
                {
                    PizzaAd = "Klasik",
                    PizzaFiyati = 14m
                },

                new cls_PizzaDTO()
                {
                    PizzaAd = "Karışık",
                    PizzaFiyati = 17m
                },

                new cls_PizzaDTO()
                {
                    PizzaAd = "Tuna",
                    PizzaFiyati = 20m
                }
            };

            lst_Pizza.Items.AddRange(pizzaListesi.ToArray());
                    
            
        }
        private void EbatDoldur()
        {
            List<cls_Ebat> EbatListesi = new List<cls_Ebat>()
            {
                new cls_Ebat()
                {
                    EbatAd = "Küçük",
                    EbatCarpan = 1m
                },

                new cls_Ebat()
                {
                    EbatAd = "Orta",
                    EbatCarpan = 1.25m
                },

                new cls_Ebat()
                {
                    EbatAd = "Büyük",
                    EbatCarpan = 2m
                }
            };
            cmb_Ebat.Items.AddRange(EbatListesi.ToArray());
        }

        private void KenarlıkDoldur()
        {
            cls_Kenar k = new cls_Kenar()
            {
                KenarAd = "Kalın Kenar",
                KenarlikFiyati = 2m
            };
            rdb_kalınkenar.Tag = k;
            rdb_kalınkenar.Text = k.KenarAd;

            cls_Kenar k2 = new cls_Kenar()
            {
                KenarAd = "İnce Kenar",
                KenarlikFiyati = 0m
            };
            rdb_incekenar.Tag = k2;
            rdb_incekenar.Text = k2.KenarAd ;

            rdb_incekenar.Checked = true;
        }

        cls_Siparis s = null;
        
        private void btn_Hesapla_Click(object sender, EventArgs e)
        {
            btn_Sepete_Ekle.Enabled = true;

            s = new cls_Siparis();
            s.Ebat = cmb_Ebat.SelectedItem as cls_Ebat;
            s.SecilenPizza = lst_Pizza.SelectedItem as cls_PizzaDTO;
            s.Kenar = rdb_kalınkenar.Checked == true ? (cls_Kenar)
                rdb_kalınkenar.Tag : (cls_Kenar)rdb_incekenar.Tag;
            // yukarıdaki ? olana kadar şart , : dan sonraki ise else

            string SecilenMalzemeler = "";
            foreach (CheckBox item in grb_Malzemeler.Controls)
            {
                if (item.Checked) // == true olmasa da olur
                {
                    SecilenMalzemeler += item.Text; // SecilenMalzemeler = SecilenMalzemeler+ item.Text; aynı
                }
            }


            s.Malzemeler = SecilenMalzemeler;
            s.Adet = Convert.ToInt32(numericUpDown1.Value);

            txt_Tutar.Text = s.AraToplam.ToString();
        }

        private void btn_Siparisi_onayla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sepetinizde "+sayac+" adet sipariş bulunmaktadır. Toplam tutar = "+total+" TL'dir.");
        }

        private void btn_Sepete_Ekle_Click(object sender, EventArgs e)
        {
            btn_Siparisi_onayla.Enabled = true;

            if (MessageBox.Show(s.SecilenPizza.PizzaAd +"isimli pizzanın siparişini vermek istiyor musunuz?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lst_Sipariş.Items.Add(s);
                btn_Sepete_Ekle.Enabled = false;
                btn_Siparisi_onayla.Enabled = true;
                temizle();
                Hesapla();
            }
        }

        public void temizle()
        {
            cmb_Ebat.Text = "";
            rdb_incekenar.Checked = true;
            foreach (CheckBox item in grb_Malzemeler.Controls)
            {
                if (item.Checked == true)
                {
                    item.Checked = false;
                }
            }
            numericUpDown1.Value = 1;
            txt_Tutar.Text = "";
        }

        int sayac = 0;
        decimal total = 0m;

        private void Hesapla()
        {
            total = sayac = 0;
            foreach (cls_Siparis item in lst_Sipariş.Items)
            {
                sayac++;
                total = total + item.AraToplam;
            }
            lbl_Toplam_tutar.Text = total.ToString();
            lbl_siparissayisi.Text = sayac.ToString();
        }

    }
}

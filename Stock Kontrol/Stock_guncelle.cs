using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Kontrol
{
    public partial class Stock_guncelle : Form
    {
        static int indisdeger;
        public Stock_guncelle()
        {
            InitializeComponent();
        }

        private void Stock_guncelle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form a = Application.OpenForms["ana_sayfa"];
            a.Show();
       
        }

        private void Stock_guncelle_Load(object sender, EventArgs e)
        {

        }

        private void btn_tara_Click(object sender, EventArgs e)
        {
            if (txt_barkod.Text=="")
            {
                MessageBox.Show("Boş Geçilemez..");
            }
            else
            {
                for (int i = 0; i < Stock_ekle.deger1; i++)
                {
                    if (txt_barkod.Text == Stock_ekle.stocklar[i].barkod  )
                    {
                        indisdeger = i;
                        txt_ad.Text = Stock_ekle.stocklar[i].u_ad ;
                        txt_acıklama.Text = Stock_ekle.stocklar[i].u_aciklama;
                        txt_fiyat.Text = Stock_ekle.stocklar[i].fiyat.ToString();
                        txt_adet.Text=Stock_ekle.stocklar[i].adet.ToString();
                    }
                   
                }
               
            }
            
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txt_barkod.Text == "" || txt_acıklama.Text == "" || txt_ad.Text == "" || txt_adet.Text == "" || txt_fiyat.Text == "")
            {
                MessageBox.Show("Boş Geçilemez..");
            }
            else
            {
                Stock_ekle. stocklar[indisdeger] = new urunekle(txt_barkod.Text, txt_ad.Text, txt_acıklama.Text, Convert.ToInt32(txt_fiyat.Text), Convert.ToInt32(txt_adet.Text));
                MessageBox.Show("Ürün Güncellendi");
                txt_acıklama.Clear();
                txt_ad.Clear();
                txt_adet.Clear();
                txt_barkod.Clear();
                txt_fiyat.Clear ();
            }

        }
    }
}

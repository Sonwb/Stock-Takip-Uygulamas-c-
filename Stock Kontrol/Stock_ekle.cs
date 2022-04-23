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
    public partial class Stock_ekle : Form
    {
        public Stock_ekle()
        {
            InitializeComponent();
        }

        public static int deger=1000;
        public static int deger1 = 0;
 
       public static urunekle[] stocklar = new urunekle[deger];





        private void Stock_ekle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form a = Application.OpenForms["ana_sayfa"];
            a.Show();
   
        }

        private void Stock_ekle_Load(object sender, EventArgs e)
        {

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {

            if (txt_barkod.Text == "" || txt_acıklama.Text == "" || txt_ad.Text == "" || txt_adet.Text == "" || txt_fiyat.Text == "")
            {
                MessageBox.Show("boş Geçemezsin");
            }
            else
            {

                stocklar[deger1] = new urunekle(txt_barkod.Text,txt_ad.Text,txt_acıklama.Text,Convert.ToInt32(txt_fiyat.Text),Convert.ToInt32(txt_adet.Text));
                deger1++;
             
                    MessageBox.Show("Ürün Eklendi");
           
            }

        }
    }
}

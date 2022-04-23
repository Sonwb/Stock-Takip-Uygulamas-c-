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
    public partial class Stocklar : Form
    {
        

        public Stocklar()
        {
            InitializeComponent();
        }

        private void Stocklar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form a = Application.OpenForms["ana_sayfa"];
            a.Show();
          
        }

        private void Stocklar_Load(object sender, EventArgs e)
        {


            for (int i = 0; i < Stock_ekle.deger1; i++)
            {
                lst_barkod.Items.Add(Stock_ekle.stocklar[i].barkod);
                lst_urunad.Items.Add(Stock_ekle.stocklar[i].u_ad);
                lst_aciklama.Items.Add(Stock_ekle.stocklar[i].u_aciklama);
                lst_fiyat.Items.Add(Stock_ekle.stocklar[i].fiyat);
                lst_adet.Items.Add(Stock_ekle.stocklar[i].adet);
            }
                
          
         


        }
    }
}

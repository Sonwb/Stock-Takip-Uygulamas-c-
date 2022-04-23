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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (txt_kulanıcı.Text==""||txt_sifre.Text=="")
            {
                MessageBox.Show("Boş Geçilmez !!");
            }
            else {
            if (txt_kulanıcı.Text=="admin"&&txt_sifre.Text=="123")
            {
                    txt_kulanıcı.Clear();
                    txt_sifre.Clear();
                this.Hide();
                ana_sayfa a = new ana_sayfa();
                a.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı Lütfen Tekrar Deneyin..");
            }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Programdan Çıkmak istediğinize emin misiniz ?", " Uyarı !", MessageBoxButtons.YesNo);
            if (sonuc == DialogResult.Yes)
            {

                for (int i = 0; i < 100; i++)
                {
                    Environment.Exit(0);
                }
                  

             

            }

            if (sonuc == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void giris_Load(object sender, EventArgs e)
        {

        }
    }
}


namespace Stock_Kontrol
{
    partial class Stocklar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lst_barkod = new System.Windows.Forms.ListBox();
            this.lst_urunad = new System.Windows.Forms.ListBox();
            this.lst_aciklama = new System.Windows.Forms.ListBox();
            this.lst_fiyat = new System.Windows.Forms.ListBox();
            this.lst_adet = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_barkod
            // 
            this.lst_barkod.FormattingEnabled = true;
            this.lst_barkod.Location = new System.Drawing.Point(32, 70);
            this.lst_barkod.Name = "lst_barkod";
            this.lst_barkod.Size = new System.Drawing.Size(120, 290);
            this.lst_barkod.TabIndex = 0;
            // 
            // lst_urunad
            // 
            this.lst_urunad.FormattingEnabled = true;
            this.lst_urunad.Location = new System.Drawing.Point(177, 70);
            this.lst_urunad.Name = "lst_urunad";
            this.lst_urunad.Size = new System.Drawing.Size(107, 290);
            this.lst_urunad.TabIndex = 0;
            // 
            // lst_aciklama
            // 
            this.lst_aciklama.FormattingEnabled = true;
            this.lst_aciklama.Location = new System.Drawing.Point(315, 70);
            this.lst_aciklama.Name = "lst_aciklama";
            this.lst_aciklama.Size = new System.Drawing.Size(123, 290);
            this.lst_aciklama.TabIndex = 0;
            // 
            // lst_fiyat
            // 
            this.lst_fiyat.FormattingEnabled = true;
            this.lst_fiyat.Location = new System.Drawing.Point(482, 70);
            this.lst_fiyat.Name = "lst_fiyat";
            this.lst_fiyat.Size = new System.Drawing.Size(114, 290);
            this.lst_fiyat.TabIndex = 0;
            // 
            // lst_adet
            // 
            this.lst_adet.FormattingEnabled = true;
            this.lst_adet.Location = new System.Drawing.Point(618, 70);
            this.lst_adet.Name = "lst_adet";
            this.lst_adet.Size = new System.Drawing.Size(132, 290);
            this.lst_adet.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barkod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(187, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(311, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ürün Açıklama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(489, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ürün Fİyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(636, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ürün Adet";
            // 
            // Stocklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 381);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_adet);
            this.Controls.Add(this.lst_fiyat);
            this.Controls.Add(this.lst_aciklama);
            this.Controls.Add(this.lst_urunad);
            this.Controls.Add(this.lst_barkod);
            this.Name = "Stocklar";
            this.Text = "Stocklar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Stocklar_FormClosing);
            this.Load += new System.EventHandler(this.Stocklar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_barkod;
        private System.Windows.Forms.ListBox lst_urunad;
        private System.Windows.Forms.ListBox lst_aciklama;
        private System.Windows.Forms.ListBox lst_fiyat;
        private System.Windows.Forms.ListBox lst_adet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
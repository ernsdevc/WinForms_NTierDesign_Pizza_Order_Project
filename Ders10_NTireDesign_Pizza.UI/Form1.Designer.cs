
namespace Ders10_NTireDesign_Pizza.UI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Ebat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lst_Pizza = new System.Windows.Forms.ListBox();
            this.rdb_incekenar = new System.Windows.Forms.RadioButton();
            this.rdb_kalınkenar = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst_Sipariş = new System.Windows.Forms.ListBox();
            this.grb_Malzemeler = new System.Windows.Forms.GroupBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Toplam_tutar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_Hesapla = new System.Windows.Forms.Button();
            this.txt_Tutar = new System.Windows.Forms.TextBox();
            this.btn_Sepete_Ekle = new System.Windows.Forms.Button();
            this.btn_Siparisi_onayla = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_siparissayisi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grb_Malzemeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(323, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "PİZZA SİPARİŞ EKRANI";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(93, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 84);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "EBAT";
            // 
            // cmb_Ebat
            // 
            this.cmb_Ebat.FormattingEnabled = true;
            this.cmb_Ebat.Location = new System.Drawing.Point(172, 136);
            this.cmb_Ebat.Name = "cmb_Ebat";
            this.cmb_Ebat.Size = new System.Drawing.Size(121, 21);
            this.cmb_Ebat.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PİZZA";
            // 
            // lst_Pizza
            // 
            this.lst_Pizza.FormattingEnabled = true;
            this.lst_Pizza.Location = new System.Drawing.Point(172, 188);
            this.lst_Pizza.Name = "lst_Pizza";
            this.lst_Pizza.Size = new System.Drawing.Size(120, 95);
            this.lst_Pizza.TabIndex = 5;
            // 
            // rdb_incekenar
            // 
            this.rdb_incekenar.AutoSize = true;
            this.rdb_incekenar.Location = new System.Drawing.Point(172, 310);
            this.rdb_incekenar.Name = "rdb_incekenar";
            this.rdb_incekenar.Size = new System.Drawing.Size(77, 17);
            this.rdb_incekenar.TabIndex = 6;
            this.rdb_incekenar.TabStop = true;
            this.rdb_incekenar.Text = "İnce Kenar";
            this.rdb_incekenar.UseVisualStyleBackColor = true;
            // 
            // rdb_kalınkenar
            // 
            this.rdb_kalınkenar.AutoSize = true;
            this.rdb_kalınkenar.Location = new System.Drawing.Point(263, 310);
            this.rdb_kalınkenar.Name = "rdb_kalınkenar";
            this.rdb_kalınkenar.Size = new System.Drawing.Size(79, 17);
            this.rdb_kalınkenar.TabIndex = 7;
            this.rdb_kalınkenar.TabStop = true;
            this.rdb_kalınkenar.Text = "Kalın Kenar";
            this.rdb_kalınkenar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.lst_Sipariş);
            this.groupBox1.Location = new System.Drawing.Point(352, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 137);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SİPARİŞLER";
            // 
            // lst_Sipariş
            // 
            this.lst_Sipariş.FormattingEnabled = true;
            this.lst_Sipariş.Location = new System.Drawing.Point(30, 29);
            this.lst_Sipariş.Name = "lst_Sipariş";
            this.lst_Sipariş.Size = new System.Drawing.Size(598, 95);
            this.lst_Sipariş.TabIndex = 0;
            // 
            // grb_Malzemeler
            // 
            this.grb_Malzemeler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grb_Malzemeler.Controls.Add(this.checkBox8);
            this.grb_Malzemeler.Controls.Add(this.checkBox7);
            this.grb_Malzemeler.Controls.Add(this.checkBox6);
            this.grb_Malzemeler.Controls.Add(this.checkBox5);
            this.grb_Malzemeler.Controls.Add(this.checkBox4);
            this.grb_Malzemeler.Controls.Add(this.checkBox3);
            this.grb_Malzemeler.Controls.Add(this.checkBox2);
            this.grb_Malzemeler.Controls.Add(this.checkBox1);
            this.grb_Malzemeler.Location = new System.Drawing.Point(172, 360);
            this.grb_Malzemeler.Name = "grb_Malzemeler";
            this.grb_Malzemeler.Size = new System.Drawing.Size(213, 139);
            this.grb_Malzemeler.TabIndex = 9;
            this.grb_Malzemeler.TabStop = false;
            this.grb_Malzemeler.Text = "MALZEMELER";
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(118, 102);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(47, 17);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "Mısır";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(118, 78);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(66, 17);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Pastırma";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(118, 56);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(73, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Ton Balığı";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(118, 32);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(59, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Mantar";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(31, 102);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(55, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Zeytin";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(31, 78);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(51, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Sosis";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(31, 55);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(55, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Salam";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(31, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Sucuk";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "TOPLAM TUTAR";
            // 
            // lbl_Toplam_tutar
            // 
            this.lbl_Toplam_tutar.AutoSize = true;
            this.lbl_Toplam_tutar.Location = new System.Drawing.Point(548, 360);
            this.lbl_Toplam_tutar.Name = "lbl_Toplam_tutar";
            this.lbl_Toplam_tutar.Size = new System.Drawing.Size(13, 13);
            this.lbl_Toplam_tutar.TabIndex = 11;
            this.lbl_Toplam_tutar.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 528);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ADET";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(211, 526);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_Hesapla
            // 
            this.btn_Hesapla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Hesapla.Location = new System.Drawing.Point(421, 511);
            this.btn_Hesapla.Name = "btn_Hesapla";
            this.btn_Hesapla.Size = new System.Drawing.Size(157, 47);
            this.btn_Hesapla.TabIndex = 14;
            this.btn_Hesapla.Text = "HESAPLA";
            this.btn_Hesapla.UseVisualStyleBackColor = false;
            this.btn_Hesapla.Click += new System.EventHandler(this.btn_Hesapla_Click);
            // 
            // txt_Tutar
            // 
            this.txt_Tutar.Location = new System.Drawing.Point(614, 525);
            this.txt_Tutar.Name = "txt_Tutar";
            this.txt_Tutar.Size = new System.Drawing.Size(100, 20);
            this.txt_Tutar.TabIndex = 15;
            // 
            // btn_Sepete_Ekle
            // 
            this.btn_Sepete_Ekle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Sepete_Ekle.Location = new System.Drawing.Point(748, 511);
            this.btn_Sepete_Ekle.Name = "btn_Sepete_Ekle";
            this.btn_Sepete_Ekle.Size = new System.Drawing.Size(136, 47);
            this.btn_Sepete_Ekle.TabIndex = 16;
            this.btn_Sepete_Ekle.Text = "SEPETE EKLE";
            this.btn_Sepete_Ekle.UseVisualStyleBackColor = false;
            this.btn_Sepete_Ekle.Click += new System.EventHandler(this.btn_Sepete_Ekle_Click);
            // 
            // btn_Siparisi_onayla
            // 
            this.btn_Siparisi_onayla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Siparisi_onayla.Location = new System.Drawing.Point(920, 508);
            this.btn_Siparisi_onayla.Name = "btn_Siparisi_onayla";
            this.btn_Siparisi_onayla.Size = new System.Drawing.Size(149, 52);
            this.btn_Siparisi_onayla.TabIndex = 17;
            this.btn_Siparisi_onayla.Text = "SİPARİŞİ ONAYLA";
            this.btn_Siparisi_onayla.UseVisualStyleBackColor = false;
            this.btn_Siparisi_onayla.Click += new System.EventHandler(this.btn_Siparisi_onayla_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(897, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Sipariş Sayısı";
            // 
            // lbl_siparissayisi
            // 
            this.lbl_siparissayisi.AutoSize = true;
            this.lbl_siparissayisi.Location = new System.Drawing.Point(971, 310);
            this.lbl_siparissayisi.Name = "lbl_siparissayisi";
            this.lbl_siparissayisi.Size = new System.Drawing.Size(13, 13);
            this.lbl_siparissayisi.TabIndex = 19;
            this.lbl_siparissayisi.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 575);
            this.Controls.Add(this.lbl_siparissayisi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Siparisi_onayla);
            this.Controls.Add(this.btn_Sepete_Ekle);
            this.Controls.Add(this.txt_Tutar);
            this.Controls.Add(this.btn_Hesapla);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_Toplam_tutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grb_Malzemeler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdb_kalınkenar);
            this.Controls.Add(this.rdb_incekenar);
            this.Controls.Add(this.lst_Pizza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_Ebat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grb_Malzemeler.ResumeLayout(false);
            this.grb_Malzemeler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Ebat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lst_Pizza;
        private System.Windows.Forms.RadioButton rdb_incekenar;
        private System.Windows.Forms.RadioButton rdb_kalınkenar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lst_Sipariş;
        private System.Windows.Forms.GroupBox grb_Malzemeler;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Toplam_tutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_Hesapla;
        private System.Windows.Forms.TextBox txt_Tutar;
        private System.Windows.Forms.Button btn_Sepete_Ekle;
        private System.Windows.Forms.Button btn_Siparisi_onayla;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_siparissayisi;
    }
}


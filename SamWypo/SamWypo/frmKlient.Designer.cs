﻿namespace SamWypo
{
    partial class frmKlient
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.txtNazwaF = new System.Windows.Forms.TextBox();
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNip = new System.Windows.Forms.TextBox();
            this.txtUlica = new System.Windows.Forms.TextBox();
            this.txtMiasto = new System.Windows.Forms.TextBox();
            this.txtNrDomu = new System.Windows.Forms.TextBox();
            this.txtNrMieszk = new System.Windows.Forms.TextBox();
            this.txtKodPoczt = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTel2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOsobKont = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.klientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa Firmy";
            // 
            // btnZapisz
            // 
            this.btnZapisz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZapisz.Location = new System.Drawing.Point(621, 395);
            this.btnZapisz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(97, 39);
            this.btnZapisz.TabIndex = 10;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnuluj.Location = new System.Drawing.Point(621, 444);
            this.btnAnuluj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(97, 39);
            this.btnAnuluj.TabIndex = 11;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // txtNazwaF
            // 
            this.txtNazwaF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "Nazwa", true));
            this.txtNazwaF.Location = new System.Drawing.Point(202, 31);
            this.txtNazwaF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNazwaF.Name = "txtNazwaF";
            this.txtNazwaF.Size = new System.Drawing.Size(370, 29);
            this.txtNazwaF.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "NIP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ulica";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Miasto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Numer domu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 321);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Kod pocztowy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 273);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Numer mieszkania";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 370);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Telefon 1";
            // 
            // txtNip
            // 
            this.txtNip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "NIP", true));
            this.txtNip.Location = new System.Drawing.Point(201, 78);
            this.txtNip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNip.Name = "txtNip";
            this.txtNip.Size = new System.Drawing.Size(370, 29);
            this.txtNip.TabIndex = 1;
            // 
            // txtUlica
            // 
            this.txtUlica.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "Ulica", true));
            this.txtUlica.Location = new System.Drawing.Point(201, 124);
            this.txtUlica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUlica.Name = "txtUlica";
            this.txtUlica.Size = new System.Drawing.Size(370, 29);
            this.txtUlica.TabIndex = 2;
            // 
            // txtMiasto
            // 
            this.txtMiasto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "Miasto", true));
            this.txtMiasto.Location = new System.Drawing.Point(201, 171);
            this.txtMiasto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMiasto.Name = "txtMiasto";
            this.txtMiasto.Size = new System.Drawing.Size(370, 29);
            this.txtMiasto.TabIndex = 3;
            // 
            // txtNrDomu
            // 
            this.txtNrDomu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "NrDomu", true));
            this.txtNrDomu.Location = new System.Drawing.Point(201, 218);
            this.txtNrDomu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNrDomu.Name = "txtNrDomu";
            this.txtNrDomu.Size = new System.Drawing.Size(370, 29);
            this.txtNrDomu.TabIndex = 4;
            // 
            // txtNrMieszk
            // 
            this.txtNrMieszk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "NrMieszk", true));
            this.txtNrMieszk.Location = new System.Drawing.Point(201, 265);
            this.txtNrMieszk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNrMieszk.Name = "txtNrMieszk";
            this.txtNrMieszk.Size = new System.Drawing.Size(370, 29);
            this.txtNrMieszk.TabIndex = 5;
            // 
            // txtKodPoczt
            // 
            this.txtKodPoczt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "KodPoczt", true));
            this.txtKodPoczt.Location = new System.Drawing.Point(201, 312);
            this.txtKodPoczt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKodPoczt.Name = "txtKodPoczt";
            this.txtKodPoczt.Size = new System.Drawing.Size(370, 29);
            this.txtKodPoczt.TabIndex = 6;
            // 
            // txtTelefon
            // 
            this.txtTelefon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "Tel1", true));
            this.txtTelefon.Location = new System.Drawing.Point(201, 359);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(370, 29);
            this.txtTelefon.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "IdKlient", true));
            this.label9.Location = new System.Drawing.Point(680, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = " ";
            // 
            // txtTel2
            // 
            this.txtTel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "Tel2", true));
            this.txtTel2.Location = new System.Drawing.Point(201, 405);
            this.txtTel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(370, 29);
            this.txtTel2.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 418);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "Telefon 2";
            // 
            // txtOsobKont
            // 
            this.txtOsobKont.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klientBindingSource, "OsobaKont", true));
            this.txtOsobKont.Location = new System.Drawing.Point(201, 454);
            this.txtOsobKont.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOsobKont.Name = "txtOsobKont";
            this.txtOsobKont.Size = new System.Drawing.Size(370, 29);
            this.txtOsobKont.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 462);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 21);
            this.label11.TabIndex = 22;
            this.label11.Text = "Osoba kontaktowa";
            // 
            // frmKlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(756, 540);
            this.Controls.Add(this.txtOsobKont);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTel2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtKodPoczt);
            this.Controls.Add(this.txtNrMieszk);
            this.Controls.Add(this.txtNrDomu);
            this.Controls.Add(this.txtMiasto);
            this.Controls.Add(this.txtUlica);
            this.Controls.Add(this.txtNip);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNazwaF);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKlient";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Klient";
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.TextBox txtNazwaF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNip;
        private System.Windows.Forms.TextBox txtUlica;
        private System.Windows.Forms.TextBox txtMiasto;
        private System.Windows.Forms.TextBox txtNrDomu;
        private System.Windows.Forms.TextBox txtNrMieszk;
        private System.Windows.Forms.TextBox txtKodPoczt;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOsobKont;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private System.Windows.Forms.BindingSource klientBindingSource1;
    }
}
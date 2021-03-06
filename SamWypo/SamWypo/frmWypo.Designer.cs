﻿namespace SamWypo.Klasy
{
    partial class frmWypo
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
            this.cmbSamo = new System.Windows.Forms.ComboBox();
            this.samoWybBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wypoDataSet = new SamWypo.WypoDataSet();
            this.cmbKlient = new System.Windows.Forms.ComboBox();
            this.wypKlientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpStop = new System.Windows.Forms.DateTimePicker();
            this.txtStawka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.samoWybTableAdapter = new SamWypo.WypoDataSetTableAdapters.SamoWybTableAdapter();
            this.wypKlientTableAdapter = new SamWypo.WypoDataSetTableAdapters.wypKlientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.samoWybBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypKlientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSamo
            // 
            this.cmbSamo.DataSource = this.samoWybBindingSource;
            this.cmbSamo.DisplayMember = "Nazwa";
            this.cmbSamo.FormattingEnabled = true;
            this.cmbSamo.Location = new System.Drawing.Point(141, 41);
            this.cmbSamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSamo.Name = "cmbSamo";
            this.cmbSamo.Size = new System.Drawing.Size(298, 29);
            this.cmbSamo.TabIndex = 0;
            this.cmbSamo.ValueMember = "IdSam";
            // 
            // samoWybBindingSource
            // 
            this.samoWybBindingSource.DataMember = "SamoWyb";
            this.samoWybBindingSource.DataSource = this.wypoDataSet;
            // 
            // wypoDataSet
            // 
            this.wypoDataSet.DataSetName = "WypoDataSet";
            this.wypoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbKlient
            // 
            this.cmbKlient.DataSource = this.wypKlientBindingSource;
            this.cmbKlient.DisplayMember = "Nazwa";
            this.cmbKlient.FormattingEnabled = true;
            this.cmbKlient.Location = new System.Drawing.Point(141, 84);
            this.cmbKlient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbKlient.Name = "cmbKlient";
            this.cmbKlient.Size = new System.Drawing.Size(298, 29);
            this.cmbKlient.TabIndex = 1;
            this.cmbKlient.ValueMember = "IdKlient";
            // 
            // wypKlientBindingSource
            // 
            this.wypKlientBindingSource.DataMember = "wypKlient";
            this.wypKlientBindingSource.DataSource = this.wypoDataSet;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(141, 128);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(298, 29);
            this.dtpStart.TabIndex = 2;
            // 
            // dtpStop
            // 
            this.dtpStop.Location = new System.Drawing.Point(141, 170);
            this.dtpStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpStop.Name = "dtpStop";
            this.dtpStop.Size = new System.Drawing.Size(298, 29);
            this.dtpStop.TabIndex = 3;
            // 
            // txtStawka
            // 
            this.txtStawka.Location = new System.Drawing.Point(141, 212);
            this.txtStawka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStawka.Name = "txtStawka";
            this.txtStawka.Size = new System.Drawing.Size(298, 29);
            this.txtStawka.TabIndex = 4;
            this.txtStawka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStawka_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Samochód";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Od";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Do";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stawka";
            // 
            // btnZapisz
            // 
            this.btnZapisz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZapisz.Location = new System.Drawing.Point(496, 146);
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
            this.btnAnuluj.Location = new System.Drawing.Point(496, 202);
            this.btnAnuluj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(97, 39);
            this.btnAnuluj.TabIndex = 11;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // samoWybTableAdapter
            // 
            this.samoWybTableAdapter.ClearBeforeFill = true;
            // 
            // wypKlientTableAdapter
            // 
            this.wypKlientTableAdapter.ClearBeforeFill = true;
            // 
            // frmWypo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(647, 281);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStawka);
            this.Controls.Add(this.dtpStop);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.cmbKlient);
            this.Controls.Add(this.cmbSamo);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWypo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wypożyczenie";
            this.Load += new System.EventHandler(this.frmWypo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.samoWybBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypKlientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSamo;
        private System.Windows.Forms.ComboBox cmbKlient;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpStop;
        private System.Windows.Forms.TextBox txtStawka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnAnuluj;
        private WypoDataSet wypoDataSet;
        private System.Windows.Forms.BindingSource samoWybBindingSource;
        private WypoDataSetTableAdapters.SamoWybTableAdapter samoWybTableAdapter;
        private System.Windows.Forms.BindingSource wypKlientBindingSource;
        private WypoDataSetTableAdapters.wypKlientTableAdapter wypKlientTableAdapter;
    }
}
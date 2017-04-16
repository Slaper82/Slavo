namespace SamWypo
{
    partial class frmDodSamo
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
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRej = new System.Windows.Forms.TextBox();
            this.samochodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtRokProd = new System.Windows.Forms.TextBox();
            this.txtKolor = new System.Windows.Forms.TextBox();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.wypMarkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wypoDataSet = new SamWypo.WypoDataSet();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.wypModelMarkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.wypMarkaTableAdapter = new SamWypo.WypoDataSetTableAdapters.wypMarkaTableAdapter();
            this.cmbPaliwo = new System.Windows.Forms.ComboBox();
            this.wypPaliwoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wypPaliwoTableAdapter = new SamWypo.WypoDataSetTableAdapters.wypPaliwoTableAdapter();
            this.wypModelMarkTableAdapter = new SamWypo.WypoDataSetTableAdapters.wypModelMarkTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPoj = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.samochodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypMarkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypModelMarkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypPaliwoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZapisz
            // 
            this.btnZapisz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZapisz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZapisz.Location = new System.Drawing.Point(416, 208);
            this.btnZapisz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(97, 39);
            this.btnZapisz.TabIndex = 6;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnuluj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnuluj.Location = new System.Drawing.Point(416, 257);
            this.btnAnuluj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(97, 39);
            this.btnAnuluj.TabIndex = 7;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marka";
            // 
            // txtRej
            // 
            this.txtRej.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.samochodBindingSource, "TabRej", true));
            this.txtRej.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRej.Location = new System.Drawing.Point(180, 112);
            this.txtRej.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRej.Name = "txtRej";
            this.txtRej.Size = new System.Drawing.Size(180, 29);
            this.txtRej.TabIndex = 2;
            // 
            // samochodBindingSource
            // 
            this.samochodBindingSource.DataSource = typeof(SamWypo.Samochod);
            // 
            // txtRokProd
            // 
            this.txtRokProd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.samochodBindingSource, "RokProd", true));
            this.txtRokProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRokProd.Location = new System.Drawing.Point(180, 151);
            this.txtRokProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRokProd.Name = "txtRokProd";
            this.txtRokProd.Size = new System.Drawing.Size(180, 29);
            this.txtRokProd.TabIndex = 3;
            this.txtRokProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRokProd_KeyPress);
            // 
            // txtKolor
            // 
            this.txtKolor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.samochodBindingSource, "Kolor", true));
            this.txtKolor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKolor.Location = new System.Drawing.Point(180, 267);
            this.txtKolor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKolor.Name = "txtKolor";
            this.txtKolor.Size = new System.Drawing.Size(180, 29);
            this.txtKolor.TabIndex = 5;
            // 
            // cmbMarka
            // 
            this.cmbMarka.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.samochodBindingSource, "IdMarka", true));
            this.cmbMarka.DataSource = this.wypMarkaBindingSource;
            this.cmbMarka.DisplayMember = "Nazwa";
            this.cmbMarka.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(180, 34);
            this.cmbMarka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(180, 29);
            this.cmbMarka.TabIndex = 0;
            this.cmbMarka.ValueMember = "IdMarka";
            this.cmbMarka.SelectedValueChanged += new System.EventHandler(this.cmbMarka_SelectedValueChanged);
            // 
            // wypMarkaBindingSource
            // 
            this.wypMarkaBindingSource.DataMember = "wypMarka";
            this.wypMarkaBindingSource.DataSource = this.wypoDataSet;
            this.wypMarkaBindingSource.CurrentChanged += new System.EventHandler(this.wypMarkaBindingSource_CurrentChanged);
            // 
            // wypoDataSet
            // 
            this.wypoDataSet.DataSetName = "WypoDataSet";
            this.wypoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbModel
            // 
            this.cmbModel.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.samochodBindingSource, "IdModel", true));
            this.cmbModel.DataSource = this.wypModelMarkBindingSource;
            this.cmbModel.DisplayMember = "Nazwa";
            this.cmbModel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(180, 73);
            this.cmbModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(180, 29);
            this.cmbModel.TabIndex = 1;
            this.cmbModel.ValueMember = "IdModel";
            // 
            // wypModelMarkBindingSource
            // 
            this.wypModelMarkBindingSource.DataMember = "wypModelMark";
            this.wypModelMarkBindingSource.DataSource = this.wypoDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(31, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(31, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Rejestracja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(31, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Rok produkcji";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(31, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Typ paliwa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(31, 272);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kolor";
            // 
            // wypMarkaTableAdapter
            // 
            this.wypMarkaTableAdapter.ClearBeforeFill = true;
            // 
            // cmbPaliwo
            // 
            this.cmbPaliwo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.samochodBindingSource, "IdPaliwa", true));
            this.cmbPaliwo.DataSource = this.wypPaliwoBindingSource;
            this.cmbPaliwo.DisplayMember = "Nazwa";
            this.cmbPaliwo.FormattingEnabled = true;
            this.cmbPaliwo.Location = new System.Drawing.Point(180, 191);
            this.cmbPaliwo.Name = "cmbPaliwo";
            this.cmbPaliwo.Size = new System.Drawing.Size(180, 29);
            this.cmbPaliwo.TabIndex = 4;
            this.cmbPaliwo.ValueMember = "IdTypSilnik";
            // 
            // wypPaliwoBindingSource
            // 
            this.wypPaliwoBindingSource.DataMember = "wypPaliwo";
            this.wypPaliwoBindingSource.DataSource = this.wypoDataSet;
            // 
            // wypPaliwoTableAdapter
            // 
            this.wypPaliwoTableAdapter.ClearBeforeFill = true;
            // 
            // wypModelMarkTableAdapter
            // 
            this.wypModelMarkTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(31, 233);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Pojemność";
            // 
            // txtPoj
            // 
            this.txtPoj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.samochodBindingSource, "Pojemnosc", true));
            this.txtPoj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPoj.Location = new System.Drawing.Point(180, 228);
            this.txtPoj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPoj.Name = "txtPoj";
            this.txtPoj.Size = new System.Drawing.Size(180, 29);
            this.txtPoj.TabIndex = 15;
            this.txtPoj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPoj_KeyPress);
            // 
            // frmDodSamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(553, 319);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPoj);
            this.Controls.Add(this.cmbPaliwo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.txtKolor);
            this.Controls.Add(this.txtRokProd);
            this.Controls.Add(this.txtRej);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZapisz);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDodSamo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDodSamo";
            this.Load += new System.EventHandler(this.frmDodSamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.samochodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypMarkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypModelMarkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypPaliwoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRej;
        private System.Windows.Forms.TextBox txtRokProd;
        private System.Windows.Forms.TextBox txtKolor;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private WypoDataSet wypoDataSet;
        private System.Windows.Forms.BindingSource wypMarkaBindingSource;
        private WypoDataSetTableAdapters.wypMarkaTableAdapter wypMarkaTableAdapter;
        private System.Windows.Forms.ComboBox cmbPaliwo;
        private System.Windows.Forms.BindingSource wypPaliwoBindingSource;
        private WypoDataSetTableAdapters.wypPaliwoTableAdapter wypPaliwoTableAdapter;
        private System.Windows.Forms.BindingSource wypModelMarkBindingSource;
        private WypoDataSetTableAdapters.wypModelMarkTableAdapter wypModelMarkTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPoj;
        private System.Windows.Forms.BindingSource samochodBindingSource;
    }
}
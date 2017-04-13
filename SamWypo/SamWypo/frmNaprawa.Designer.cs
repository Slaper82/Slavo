namespace SamWypo.Klasy
{
    partial class frmNaprawa
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSamo = new System.Windows.Forms.ComboBox();
            this.samoWybBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wypoDataSet = new SamWypo.WypoDataSet();
            this.naprawaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpStop = new System.Windows.Forms.DateTimePicker();
            this.txtKwota = new System.Windows.Forms.TextBox();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.samoWybTableAdapter = new SamWypo.WypoDataSetTableAdapters.SamoWybTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.samoWybBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naprawaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Samochód";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(35, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Od";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(35, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Do";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(35, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kwota naprawy";
            // 
            // cmbSamo
            // 
            this.cmbSamo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.naprawaBindingSource, "IdSamo", true));
            this.cmbSamo.DataSource = this.samoWybBindingSource;
            this.cmbSamo.DisplayMember = "Nazwa";
            this.cmbSamo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbSamo.FormattingEnabled = true;
            this.cmbSamo.Location = new System.Drawing.Point(169, 30);
            this.cmbSamo.Name = "cmbSamo";
            this.cmbSamo.Size = new System.Drawing.Size(150, 29);
            this.cmbSamo.TabIndex = 4;
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
            // naprawaBindingSource
            // 
            this.naprawaBindingSource.DataSource = typeof(SamWypo.Naprawa);
            // 
            // dtpStart
            // 
            this.dtpStart.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.naprawaBindingSource, "DStart", true));
            this.dtpStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(169, 68);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(150, 29);
            this.dtpStart.TabIndex = 5;
            // 
            // dtpStop
            // 
            this.dtpStop.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.naprawaBindingSource, "DStop", true));
            this.dtpStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpStop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStop.Location = new System.Drawing.Point(169, 105);
            this.dtpStop.Name = "dtpStop";
            this.dtpStop.Size = new System.Drawing.Size(150, 29);
            this.dtpStop.TabIndex = 6;
            // 
            // txtKwota
            // 
            this.txtKwota.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.naprawaBindingSource, "Kwota", true));
            this.txtKwota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKwota.Location = new System.Drawing.Point(169, 142);
            this.txtKwota.Name = "txtKwota";
            this.txtKwota.Size = new System.Drawing.Size(150, 29);
            this.txtKwota.TabIndex = 7;
            // 
            // btnZapisz
            // 
            this.btnZapisz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZapisz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZapisz.Location = new System.Drawing.Point(235, 196);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(85, 34);
            this.btnZapisz.TabIndex = 8;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnuluj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnuluj.Location = new System.Drawing.Point(131, 196);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(85, 34);
            this.btnAnuluj.TabIndex = 9;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // samoWybTableAdapter
            // 
            this.samoWybTableAdapter.ClearBeforeFill = true;
            // 
            // frmNaprawa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 259);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.txtKwota);
            this.Controls.Add(this.dtpStop);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.cmbSamo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNaprawa";
            this.ShowIcon = false;
            this.Text = "Naprawa";
            this.Load += new System.EventHandler(this.frmNaprawa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.samoWybBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naprawaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSamo;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpStop;
        private System.Windows.Forms.TextBox txtKwota;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnAnuluj;
        private WypoDataSet wypoDataSet;
        private System.Windows.Forms.BindingSource samoWybBindingSource;
        private WypoDataSetTableAdapters.SamoWybTableAdapter samoWybTableAdapter;
        private System.Windows.Forms.BindingSource naprawaBindingSource;
    }
}
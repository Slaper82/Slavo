namespace SamWypo
{
    partial class frmModel
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
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.wypMarkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wypoDataSet = new SamWypo.WypoDataSet();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wypMarkaTableAdapter = new SamWypo.WypoDataSetTableAdapters.wypMarkaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.wypMarkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMarka
            // 
            this.cmbMarka.DataSource = this.wypMarkaBindingSource;
            this.cmbMarka.DisplayMember = "Nazwa";
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(18, 65);
            this.cmbMarka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(180, 29);
            this.cmbMarka.TabIndex = 0;
            this.cmbMarka.ValueMember = "IdMarka";
            // 
            // wypMarkaBindingSource
            // 
            this.wypMarkaBindingSource.DataMember = "wypMarka";
            this.wypMarkaBindingSource.DataSource = this.wypoDataSet;
            // 
            // wypoDataSet
            // 
            this.wypoDataSet.DataSetName = "WypoDataSet";
            this.wypoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(244, 66);
            this.txtNazwa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(148, 29);
            this.txtNazwa.TabIndex = 1;
            // 
            // btnZapisz
            // 
            this.btnZapisz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZapisz.Location = new System.Drawing.Point(444, 65);
            this.btnZapisz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(112, 33);
            this.btnZapisz.TabIndex = 2;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wybierz markę";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wpisz nazwę";
            // 
            // wypMarkaTableAdapter
            // 
            this.wypMarkaTableAdapter.ClearBeforeFill = true;
            // 
            // frmModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(628, 147);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.cmbMarka);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj model";
            this.Load += new System.EventHandler(this.frmModel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wypMarkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private WypoDataSet wypoDataSet;
        private System.Windows.Forms.BindingSource wypMarkaBindingSource;
        private WypoDataSetTableAdapters.wypMarkaTableAdapter wypMarkaTableAdapter;
    }
}
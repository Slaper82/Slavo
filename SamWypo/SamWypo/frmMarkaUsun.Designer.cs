namespace SamWypo
{
    partial class frmMarkaUsun
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
            this.cmbMarki = new System.Windows.Forms.ComboBox();
            this.wypMarkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wypoDataSet = new SamWypo.WypoDataSet();
            this.btnUsun = new System.Windows.Forms.Button();
            this.wypMarkaTableAdapter = new SamWypo.WypoDataSetTableAdapters.wypMarkaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wypMarkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMarki
            // 
            this.cmbMarki.DataSource = this.wypMarkaBindingSource;
            this.cmbMarki.DisplayMember = "Nazwa";
            this.cmbMarki.FormattingEnabled = true;
            this.cmbMarki.Location = new System.Drawing.Point(21, 53);
            this.cmbMarki.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMarki.Name = "cmbMarki";
            this.cmbMarki.Size = new System.Drawing.Size(220, 29);
            this.cmbMarki.TabIndex = 0;
            this.cmbMarki.ValueMember = "IdMarka";
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
            // btnUsun
            // 
            this.btnUsun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsun.Location = new System.Drawing.Point(293, 53);
            this.btnUsun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(156, 37);
            this.btnUsun.TabIndex = 1;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // wypMarkaTableAdapter
            // 
            this.wypMarkaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz markę do usunięcia";
            // 
            // frmMarkaUsun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(537, 136);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.cmbMarki);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMarkaUsun";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuń markę";
            this.Load += new System.EventHandler(this.frmMarkaUsun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wypMarkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMarki;
        private System.Windows.Forms.Button btnUsun;
        private WypoDataSet wypoDataSet;
        private System.Windows.Forms.BindingSource wypMarkaBindingSource;
        private WypoDataSetTableAdapters.wypMarkaTableAdapter wypMarkaTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}
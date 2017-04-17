namespace SamWypo
{
    partial class frmModelUsun
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
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.btnUsun = new System.Windows.Forms.Button();
            this.wypoDataSet = new SamWypo.WypoDataSet();
            this.wypModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wypModelTableAdapter = new SamWypo.WypoDataSetTableAdapters.wypModelTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wypoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbModel
            // 
            this.cmbModel.DataSource = this.wypModelBindingSource;
            this.cmbModel.DisplayMember = "Nazwa";
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(28, 66);
            this.cmbModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(180, 29);
            this.cmbModel.TabIndex = 0;
            this.cmbModel.ValueMember = "IdModel";
            // 
            // btnUsun
            // 
            this.btnUsun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsun.Location = new System.Drawing.Point(289, 59);
            this.btnUsun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(112, 41);
            this.btnUsun.TabIndex = 1;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // wypoDataSet
            // 
            this.wypoDataSet.DataSetName = "WypoDataSet";
            this.wypoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wypModelBindingSource
            // 
            this.wypModelBindingSource.DataMember = "wypModel";
            this.wypModelBindingSource.DataSource = this.wypoDataSet;
            // 
            // wypModelTableAdapter
            // 
            this.wypModelTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz model";
            // 
            // frmModelUsun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(455, 165);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.cmbModel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModelUsun";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuń model";
            this.Load += new System.EventHandler(this.frmModelUsun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wypoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Button btnUsun;
        private WypoDataSet wypoDataSet;
        private System.Windows.Forms.BindingSource wypModelBindingSource;
        private WypoDataSetTableAdapters.wypModelTableAdapter wypModelTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}
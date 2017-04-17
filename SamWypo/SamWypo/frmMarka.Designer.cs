namespace SamWypo
{
    partial class frmMarka
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
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.btnDodajMarke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka Samochodu";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(195, 32);
            this.txtMarka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(176, 29);
            this.txtMarka.TabIndex = 1;
            // 
            // btnDodajMarke
            // 
            this.btnDodajMarke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajMarke.Location = new System.Drawing.Point(425, 29);
            this.btnDodajMarke.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDodajMarke.Name = "btnDodajMarke";
            this.btnDodajMarke.Size = new System.Drawing.Size(112, 37);
            this.btnDodajMarke.TabIndex = 2;
            this.btnDodajMarke.Text = "Dodaj";
            this.btnDodajMarke.UseVisualStyleBackColor = true;
            this.btnDodajMarke.Click += new System.EventHandler(this.btnDodajMarke_Click);
            // 
            // frmMarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(599, 107);
            this.Controls.Add(this.btnDodajMarke);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMarka";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj nową markę";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Button btnDodajMarke;
    }
}
namespace SamWypo
{
    partial class frmDBConfig
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
            this.txtSrv = new System.Windows.Forms.TextBox();
            this.txtBaza = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSrv
            // 
            this.txtSrv.Location = new System.Drawing.Point(147, 50);
            this.txtSrv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSrv.Name = "txtSrv";
            this.txtSrv.Size = new System.Drawing.Size(250, 29);
            this.txtSrv.TabIndex = 0;
            // 
            // txtBaza
            // 
            this.txtBaza.Location = new System.Drawing.Point(147, 108);
            this.txtBaza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBaza.Name = "txtBaza";
            this.txtBaza.Size = new System.Drawing.Size(250, 29);
            this.txtBaza.TabIndex = 1;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(147, 170);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(250, 29);
            this.txtLogin.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(147, 228);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(250, 29);
            this.txtPass.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nazwa serwera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Baza danych";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hasło";
            // 
            // btnZapisz
            // 
            this.btnZapisz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZapisz.Location = new System.Drawing.Point(454, 155);
            this.btnZapisz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(112, 37);
            this.btnZapisz.TabIndex = 8;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnuluj.Location = new System.Drawing.Point(454, 221);
            this.btnAnuluj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(112, 37);
            this.btnAnuluj.TabIndex = 9;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // frmDBConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(618, 297);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtBaza);
            this.Controls.Add(this.txtSrv);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDBConfig";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Konfiguracja połączenia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSrv;
        private System.Windows.Forms.TextBox txtBaza;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnAnuluj;
    }
}
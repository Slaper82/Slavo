namespace SamWypo
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.samochódToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpWypo = new System.Windows.Forms.TabPage();
            this.tpSamoch = new System.Windows.Forms.TabPage();
            this.tpKlient = new System.Windows.Forms.TabPage();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUsun = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnDodSam = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpWypo.SuspendLayout();
            this.tpSamoch.SuspendLayout();
            this.tpKlient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.samochódToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(773, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // samochódToolStripMenuItem
            // 
            this.samochódToolStripMenuItem.Name = "samochódToolStripMenuItem";
            this.samochódToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.samochódToolStripMenuItem.Text = "Administrator";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpWypo);
            this.tabControl.Controls.Add(this.tpSamoch);
            this.tabControl.Controls.Add(this.tpKlient);
            this.tabControl.Location = new System.Drawing.Point(12, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(714, 328);
            this.tabControl.TabIndex = 1;
            // 
            // tpWypo
            // 
            this.tpWypo.Controls.Add(this.label4);
            this.tpWypo.Controls.Add(this.label3);
            this.tpWypo.Controls.Add(this.dataGridView1);
            this.tpWypo.Controls.Add(this.btnUsun);
            this.tpWypo.Controls.Add(this.label2);
            this.tpWypo.Controls.Add(this.label1);
            this.tpWypo.Controls.Add(this.dateTimePicker2);
            this.tpWypo.Controls.Add(this.dateTimePicker1);
            this.tpWypo.Controls.Add(this.btnDodaj);
            this.tpWypo.Location = new System.Drawing.Point(4, 22);
            this.tpWypo.Name = "tpWypo";
            this.tpWypo.Padding = new System.Windows.Forms.Padding(3);
            this.tpWypo.Size = new System.Drawing.Size(706, 302);
            this.tpWypo.TabIndex = 0;
            this.tpWypo.Text = "Wypożyczenia";
            this.tpWypo.UseVisualStyleBackColor = true;
            // 
            // tpSamoch
            // 
            this.tpSamoch.Controls.Add(this.btnDodSam);
            this.tpSamoch.Controls.Add(this.dataGridView2);
            this.tpSamoch.Location = new System.Drawing.Point(4, 22);
            this.tpSamoch.Name = "tpSamoch";
            this.tpSamoch.Padding = new System.Windows.Forms.Padding(3);
            this.tpSamoch.Size = new System.Drawing.Size(706, 302);
            this.tpSamoch.TabIndex = 1;
            this.tpSamoch.Text = "Samochody";
            this.tpSamoch.UseVisualStyleBackColor = true;
            // 
            // tpKlient
            // 
            this.tpKlient.Controls.Add(this.button1);
            this.tpKlient.Controls.Add(this.dataGridView3);
            this.tpKlient.Location = new System.Drawing.Point(4, 22);
            this.tpKlient.Name = "tpKlient";
            this.tpKlient.Padding = new System.Windows.Forms.Padding(3);
            this.tpKlient.Size = new System.Drawing.Size(706, 302);
            this.tpKlient.TabIndex = 2;
            this.tpKlient.Text = "Klienci";
            this.tpKlient.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.White;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Location = new System.Drawing.Point(586, 68);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(83, 39);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj Wypo";
            this.btnDodaj.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(228, 17);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(140, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Od";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Do";
            // 
            // btnUsun
            // 
            this.btnUsun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsun.Location = new System.Drawing.Point(586, 113);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(83, 39);
            this.btnUsun.TabIndex = 5;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(561, 226);
            this.dataGridView1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wartość:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(639, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "10000 zł";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 64);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(644, 221);
            this.dataGridView2.TabIndex = 0;
            // 
            // btnDodSam
            // 
            this.btnDodSam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodSam.Location = new System.Drawing.Point(6, 25);
            this.btnDodSam.Name = "btnDodSam";
            this.btnDodSam.Size = new System.Drawing.Size(79, 33);
            this.btnDodSam.TabIndex = 1;
            this.btnDodSam.Text = "Nowy";
            this.btnDodSam.UseVisualStyleBackColor = true;
            this.btnDodSam.Click += new System.EventHandler(this.btnDodSam_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 63);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(644, 221);
            this.dataGridView3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nowy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 380);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Katalog Główny";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tpWypo.ResumeLayout(false);
            this.tpWypo.PerformLayout();
            this.tpSamoch.ResumeLayout(false);
            this.tpKlient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem samochódToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpWypo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TabPage tpSamoch;
        private System.Windows.Forms.Button btnDodSam;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tpKlient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}


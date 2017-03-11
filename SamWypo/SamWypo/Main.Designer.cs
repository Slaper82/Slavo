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
            this.markiSamochodówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajMarkęIModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpWypo = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUsun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStop = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.tpSamoch = new System.Windows.Forms.TabPage();
            this.btnUSamo = new System.Windows.Forms.Button();
            this.btnESamo = new System.Windows.Forms.Button();
            this.btnDodSam = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tpKlient = new System.Windows.Forms.TabPage();
            this.btnUKlient = new System.Windows.Forms.Button();
            this.btnEKlient = new System.Windows.Forms.Button();
            this.btnDklient = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tpRaport = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tpNaprawa = new System.Windows.Forms.TabPage();
            this.btnNNapr = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.btnNEdytuj = new System.Windows.Forms.Button();
            this.btnNUsun = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpWypo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tpSamoch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tpKlient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tpRaport.SuspendLayout();
            this.tpNaprawa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.samochódToolStripMenuItem,
            this.markiSamochodówToolStripMenuItem});
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
            // markiSamochodówToolStripMenuItem
            // 
            this.markiSamochodówToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajMarkęIModelToolStripMenuItem});
            this.markiSamochodówToolStripMenuItem.Name = "markiSamochodówToolStripMenuItem";
            this.markiSamochodówToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.markiSamochodówToolStripMenuItem.Text = "Marki samochodów";
            // 
            // dodajMarkęIModelToolStripMenuItem
            // 
            this.dodajMarkęIModelToolStripMenuItem.Name = "dodajMarkęIModelToolStripMenuItem";
            this.dodajMarkęIModelToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.dodajMarkęIModelToolStripMenuItem.Text = "Dodaj markę i model";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpWypo);
            this.tabControl.Controls.Add(this.tpSamoch);
            this.tabControl.Controls.Add(this.tpKlient);
            this.tabControl.Controls.Add(this.tpRaport);
            this.tabControl.Controls.Add(this.tpNaprawa);
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
            this.tpWypo.Controls.Add(this.dtpStop);
            this.tpWypo.Controls.Add(this.dtpStart);
            this.tpWypo.Controls.Add(this.btnDodaj);
            this.tpWypo.Location = new System.Drawing.Point(4, 22);
            this.tpWypo.Name = "tpWypo";
            this.tpWypo.Padding = new System.Windows.Forms.Padding(3);
            this.tpWypo.Size = new System.Drawing.Size(706, 302);
            this.tpWypo.TabIndex = 0;
            this.tpWypo.Text = "Wypożyczenia";
            this.tpWypo.UseVisualStyleBackColor = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wartość:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(561, 226);
            this.dataGridView1.TabIndex = 6;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Do";
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
            // dtpStop
            // 
            this.dtpStop.Location = new System.Drawing.Point(228, 17);
            this.dtpStop.Name = "dtpStop";
            this.dtpStop.Size = new System.Drawing.Size(140, 20);
            this.dtpStop.TabIndex = 2;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(33, 16);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(141, 20);
            this.dtpStart.TabIndex = 1;
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
            // tpSamoch
            // 
            this.tpSamoch.Controls.Add(this.btnUSamo);
            this.tpSamoch.Controls.Add(this.btnESamo);
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
            // btnUSamo
            // 
            this.btnUSamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUSamo.Location = new System.Drawing.Point(212, 25);
            this.btnUSamo.Name = "btnUSamo";
            this.btnUSamo.Size = new System.Drawing.Size(79, 33);
            this.btnUSamo.TabIndex = 3;
            this.btnUSamo.Text = "Usuń";
            this.btnUSamo.UseVisualStyleBackColor = true;
            // 
            // btnESamo
            // 
            this.btnESamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnESamo.Location = new System.Drawing.Point(109, 25);
            this.btnESamo.Name = "btnESamo";
            this.btnESamo.Size = new System.Drawing.Size(79, 33);
            this.btnESamo.TabIndex = 2;
            this.btnESamo.Text = "Edytuj";
            this.btnESamo.UseVisualStyleBackColor = true;
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
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 64);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(644, 221);
            this.dataGridView2.TabIndex = 0;
            // 
            // tpKlient
            // 
            this.tpKlient.Controls.Add(this.btnUKlient);
            this.tpKlient.Controls.Add(this.btnEKlient);
            this.tpKlient.Controls.Add(this.btnDklient);
            this.tpKlient.Controls.Add(this.dataGridView3);
            this.tpKlient.Location = new System.Drawing.Point(4, 22);
            this.tpKlient.Name = "tpKlient";
            this.tpKlient.Padding = new System.Windows.Forms.Padding(3);
            this.tpKlient.Size = new System.Drawing.Size(706, 302);
            this.tpKlient.TabIndex = 2;
            this.tpKlient.Text = "Klienci";
            this.tpKlient.UseVisualStyleBackColor = true;
            // 
            // btnUKlient
            // 
            this.btnUKlient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUKlient.Location = new System.Drawing.Point(208, 24);
            this.btnUKlient.Name = "btnUKlient";
            this.btnUKlient.Size = new System.Drawing.Size(79, 33);
            this.btnUKlient.TabIndex = 4;
            this.btnUKlient.Text = "Usuń";
            this.btnUKlient.UseVisualStyleBackColor = true;
            // 
            // btnEKlient
            // 
            this.btnEKlient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEKlient.Location = new System.Drawing.Point(107, 24);
            this.btnEKlient.Name = "btnEKlient";
            this.btnEKlient.Size = new System.Drawing.Size(79, 33);
            this.btnEKlient.TabIndex = 3;
            this.btnEKlient.Text = "Edytuj";
            this.btnEKlient.UseVisualStyleBackColor = true;
            // 
            // btnDklient
            // 
            this.btnDklient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDklient.Location = new System.Drawing.Point(6, 24);
            this.btnDklient.Name = "btnDklient";
            this.btnDklient.Size = new System.Drawing.Size(79, 33);
            this.btnDklient.TabIndex = 2;
            this.btnDklient.Text = "Nowy";
            this.btnDklient.UseVisualStyleBackColor = true;
            this.btnDklient.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 63);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(644, 221);
            this.dataGridView3.TabIndex = 1;
            // 
            // tpRaport
            // 
            this.tpRaport.Controls.Add(this.label6);
            this.tpRaport.Controls.Add(this.label5);
            this.tpRaport.Location = new System.Drawing.Point(4, 22);
            this.tpRaport.Name = "tpRaport";
            this.tpRaport.Padding = new System.Windows.Forms.Padding(3);
            this.tpRaport.Size = new System.Drawing.Size(706, 302);
            this.tpRaport.TabIndex = 3;
            this.tpRaport.Text = "Raporty";
            this.tpRaport.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Opcje: po kliencie, okresie, samochodzie?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tutaj raporty...tylko jakie";
            // 
            // tpNaprawa
            // 
            this.tpNaprawa.Controls.Add(this.btnNUsun);
            this.tpNaprawa.Controls.Add(this.btnNEdytuj);
            this.tpNaprawa.Controls.Add(this.btnNNapr);
            this.tpNaprawa.Controls.Add(this.dataGridView4);
            this.tpNaprawa.Location = new System.Drawing.Point(4, 22);
            this.tpNaprawa.Name = "tpNaprawa";
            this.tpNaprawa.Padding = new System.Windows.Forms.Padding(3);
            this.tpNaprawa.Size = new System.Drawing.Size(706, 302);
            this.tpNaprawa.TabIndex = 4;
            this.tpNaprawa.Text = "Naprawy";
            this.tpNaprawa.UseVisualStyleBackColor = true;
            // 
            // btnNNapr
            // 
            this.btnNNapr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNNapr.Location = new System.Drawing.Point(6, 29);
            this.btnNNapr.Name = "btnNNapr";
            this.btnNNapr.Size = new System.Drawing.Size(79, 33);
            this.btnNNapr.TabIndex = 4;
            this.btnNNapr.Text = "Nowy";
            this.btnNNapr.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(6, 68);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(644, 221);
            this.dataGridView4.TabIndex = 3;
            // 
            // btnNEdytuj
            // 
            this.btnNEdytuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNEdytuj.Location = new System.Drawing.Point(107, 29);
            this.btnNEdytuj.Name = "btnNEdytuj";
            this.btnNEdytuj.Size = new System.Drawing.Size(79, 33);
            this.btnNEdytuj.TabIndex = 5;
            this.btnNEdytuj.Text = "Edytuj";
            this.btnNEdytuj.UseVisualStyleBackColor = true;
            // 
            // btnNUsun
            // 
            this.btnNUsun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNUsun.Location = new System.Drawing.Point(208, 29);
            this.btnNUsun.Name = "btnNUsun";
            this.btnNUsun.Size = new System.Drawing.Size(79, 33);
            this.btnNUsun.TabIndex = 6;
            this.btnNUsun.Text = "Usuń";
            this.btnNUsun.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tpSamoch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tpKlient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tpRaport.ResumeLayout(false);
            this.tpRaport.PerformLayout();
            this.tpNaprawa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtpStop;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TabPage tpSamoch;
        private System.Windows.Forms.Button btnDodSam;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tpKlient;
        private System.Windows.Forms.Button btnDklient;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tpRaport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tpNaprawa;
        private System.Windows.Forms.ToolStripMenuItem markiSamochodówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajMarkęIModelToolStripMenuItem;
        private System.Windows.Forms.Button btnUSamo;
        private System.Windows.Forms.Button btnESamo;
        private System.Windows.Forms.Button btnUKlient;
        private System.Windows.Forms.Button btnEKlient;
        private System.Windows.Forms.Button btnNUsun;
        private System.Windows.Forms.Button btnNEdytuj;
        private System.Windows.Forms.Button btnNNapr;
        private System.Windows.Forms.DataGridView dataGridView4;
    }
}


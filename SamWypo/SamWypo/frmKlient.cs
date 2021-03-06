﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamWypo
{
    public delegate void Dodano(object sender, EventArgs e);
    public partial class frmKlient : Form
    {
        private Klient klient { get; set; }

        public event Dodano dodano;
        public frmKlient()
        {
            InitializeComponent();
        }
        public frmKlient(Klient klient)
        {
            InitializeComponent();
            this.klient = klient;
            klientBindingSource.DataSource = this.klient;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            bool DaneOk = false;
            Klient nowy = new Klient(txtNazwaF.Text,txtNip.Text,txtUlica.Text,txtMiasto.Text,txtNrDomu.Text,txtNrMieszk.Text,txtKodPoczt.Text,txtTelefon.Text,txtTel2.Text,txtOsobKont.Text);
            DaneOk = nowy.Sprawdz();
            if(DaneOk)
            try
                {
                    if (klient != null)
                    {
                        klient.ZapiszEdyt();
                    }
                    else
                    {
                        nowy.ZapiszNowe();
                    }
                    if (dodano != null) dodano(this, e);
                }
            catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            else
            {
                MessageBox.Show("Uzupełnij wszystkie wymagane pola!");
            }
            this.Close();
            
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

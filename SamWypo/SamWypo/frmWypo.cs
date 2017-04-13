using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamWypo.Klasy
{
    public partial class frmWypo : Form
    {
        public event Dodano dodano;
        public Wypo wypozycz { get; set; }

        public frmWypo()
        {
            InitializeComponent();
        }

        public frmWypo(Wypo wyp)
        {
            InitializeComponent();
            this.wypozycz = wyp;
            Przypisz();
        }

        private void Przypisz()
        {
            cmbSamo.SelectedValue = this.wypozycz.IdSamo;
            cmbKlient.SelectedValue = this.wypozycz.IdKlient;
            dtpStart.Value = this.wypozycz.DStart;
            dtpStop.Value = this.wypozycz.DStop;
            txtStawka.Text = this.wypozycz.Stawka.ToString();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmWypo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wypoDataSet.wypKlient' table. You can move, or remove it, as needed.
            this.wypKlientTableAdapter.Fill(this.wypoDataSet.wypKlient);
            // TODO: This line of code loads data into the 'wypoDataSet.SamoWyb' table. You can move, or remove it, as needed.
            this.samoWybTableAdapter.Fill(this.wypoDataSet.SamoWyb);
            this.cmbSamo.SelectedValue = wypozycz.IdSamo;
            this.cmbKlient.SelectedValue = wypozycz.IdKlient;

        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (wypozycz != null)
            {
                wypozycz.IdKlient = (int)cmbKlient.SelectedValue;
                wypozycz.IdSamo = (int)cmbSamo.SelectedValue;
                wypozycz.DStart = dtpStart.Value;
                wypozycz.DStop = dtpStop.Value;
                wypozycz.Stawka = Convert.ToInt32(txtStawka.Text);
                wypozycz.ZapiszEdyt();
            }
            else
            {
                Wypo nowy = new Wypo((int)cmbSamo.SelectedValue,(int)cmbKlient.SelectedValue,dtpStart.Value,dtpStop.Value,Convert.ToDecimal(txtStawka.Text),0);
                nowy.ZapiszNowe();
            }
            if (dodano != null) dodano(this, e);
            this.Close();
        }
    }
}

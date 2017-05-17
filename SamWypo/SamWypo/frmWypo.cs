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
            try
            {
                this.samoWybTableAdapter.Fill(this.wypoDataSet.SamoWyb);
                this.cmbSamo.SelectedValue = wypozycz.IdSamo;
                this.cmbKlient.SelectedValue = wypozycz.IdKlient;
            }
            catch { }

        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (txtStawka.Text != String.Empty&&dtpStart.Value<dtpStop.Value)
            {
                if (wypozycz != null)
                {
                    wypozycz.IdKlient = (int)cmbKlient.SelectedValue;
                    wypozycz.IdSamo = (int)cmbSamo.SelectedValue;
                    wypozycz.DStart = dtpStart.Value;
                    wypozycz.DStop = dtpStop.Value;
                    wypozycz.Stawka = Convert.ToDecimal(txtStawka.Text);
                    if (wypozycz.UsunTrans(wypozycz.IdWypo))
                    {
                        wypozycz.ZapiszTransakcje(dtpStart.Value, dtpStop.Value,wypozycz.IdWypo);
                        wypozycz.ZapiszEdyt();
                    }
                    else MessageBox.Show("Wystąpiły błędy podczas edycji");
                }
                else
                {
                    Wypo nowy = new Wypo((int)cmbSamo.SelectedValue, (int)cmbKlient.SelectedValue, dtpStart.Value, dtpStop.Value, Convert.ToDecimal(txtStawka.Text), 0);
                    nowy.ZapiszNowe();
                    int IdWypo = nowy.PokazIdWypo(); 
                    nowy.ZapiszTransakcje(dtpStart.Value, dtpStop.Value,IdWypo);
                }
                if (dodano != null) dodano(this, e);
                this.Close();
            }
            else
            {
                if(txtStawka.Text==String.Empty)
                MessageBox.Show("Należy podać stawkę.", "Podaj Stawkę", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Data Od nie może być większa niż data Do", "Błędy daty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtStawka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnZapisz.PerformClick();
            }
        }
    }
}

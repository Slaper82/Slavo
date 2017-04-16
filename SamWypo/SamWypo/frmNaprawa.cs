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
    public partial class frmNaprawa : Form
    {
        public event Dodano dodano;
        public Naprawa naprawa { get; set; }
        public frmNaprawa()
        {
            InitializeComponent();
        }

        public frmNaprawa(Naprawa Enapr)
        {
            InitializeComponent();
            this.naprawa = Enapr;
            this.cmbSamo.SelectedValue = naprawa.IdSamo;
            this.txtKwota.Text = naprawa.Kwota.ToString();
            this.dtpStart.Text = naprawa.DStart.ToString();
            this.dtpStop.Text = naprawa.DStop.ToString();

            // samoWybBindingSource.DataSource = this.naprawa;
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNaprawa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wypoDataSet.SamoWyb' table. You can move, or remove it, as needed.
            this.samoWybTableAdapter.Fill(this.wypoDataSet.SamoWyb);
            this.cmbSamo.SelectedValue = naprawa.IdSamo;

        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            bool DaneOk = false;
            Naprawa nowa = new Naprawa(Convert.ToInt32(cmbSamo.SelectedValue.ToString()), dtpStart.Value, dtpStop.Value, Convert.ToDouble(txtKwota.Text),txtOpis.Text);
            DaneOk = nowa.Sprawdz();
            if (DaneOk)
            {
                try
                {
                    if (naprawa != null)
                    {
                        naprawa.ZapiszEdyt();
                    }
                    else
                    {
                        nowa.ZapiszNowe();
                    }
                    if (dodano != null) dodano(this, e);
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Wypełnij wszystkie pola!");
            }
            this.Close();
        }

        private void txtKwota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

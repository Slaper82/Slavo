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
            samoWybBindingSource.DataSource = this.naprawa;
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNaprawa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wypoDataSet.SamoWyb' table. You can move, or remove it, as needed.
            this.samoWybTableAdapter.Fill(this.wypoDataSet.SamoWyb);

        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            bool DaneOk = false;
            Naprawa nowa = new Naprawa(Convert.ToInt32(cmbSamo.SelectedIndex), dtpStart.Value, dtpStop.Value, Convert.ToDouble(txtKwota.Text));
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
        }
    }
}

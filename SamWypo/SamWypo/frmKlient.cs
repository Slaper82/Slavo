using System;
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
    public partial class frmKlient : Form
    {
        public frmKlient()
        {
            InitializeComponent();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            bool DaneOk = false;
            Klient nowy = new Klient(txtNazwaF.Text,txtNip.Text,txtUlica.Text,txtMiasto.Text,txtNrDomu.Text,txtNrMieszk.Text,txtKodPoczt.Text,txtTelefon.Text,txtTel2.Text,txtOsobKont.Text);
            DaneOk = nowy.Sprawdz();
            if(DaneOk)
            try
                {
                        nowy.ZapiszNowe();
                }
            catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            else
            {
                MessageBox.Show("Uzupełnij wszystkie wymagane pola!");
            }
            
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

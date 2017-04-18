using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SamWypo.WypoDataSetTableAdapters;
namespace SamWypo
{
    public partial class frmLogowanie : Form
    {
        wypLogowanieTableAdapter user;
        public frmLogowanie()
        {
            InitializeComponent();
            user = new wypLogowanieTableAdapter();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnZaloguj.PerformClick();
            }
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            int id = (int)user.LoginCheck(txtLogin.Text, txtPass.Text);
            if (id > 0)
            {
                Main wypozyczalania = new Main();
                wypozyczalania.Show();
                this.Owner = wypozyczalania;
                this.Hide();
                
            }
        }
    }
}

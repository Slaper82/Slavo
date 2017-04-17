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
    public partial class frmMarka : Form
    {
        public string Nazwa { get; set; }
        wypMarkaTableAdapter nowa;
        public frmMarka()
        {
            InitializeComponent();
            nowa = new wypMarkaTableAdapter();
        }

        private void btnDodajMarke_Click(object sender, EventArgs e)
        {
            Nazwa = txtMarka.Text;
            try
            {
                nowa.Insert(Nazwa);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Nie udało się wprowadzić nowej marki.");
            }
        }
    }
}

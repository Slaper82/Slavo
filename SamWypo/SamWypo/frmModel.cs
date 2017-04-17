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
    public partial class frmModel : Form
    {
        wypModelTableAdapter model;
        public frmModel()
        {
            InitializeComponent();
            model = new wypModelTableAdapter();
        }

        private void frmModel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wypoDataSet.wypMarka' table. You can move, or remove it, as needed.
            this.wypMarkaTableAdapter.Fill(this.wypoDataSet.wypMarka);

        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbMarka.SelectedValue.ToString());
            try
            {
                if (id > 0 && txtNazwa.Text != String.Empty)
                {
                    model.Insert(txtNazwa.Text, id);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Wystąpił błąd zapisu...");
            }
        }
    }
}

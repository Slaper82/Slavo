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
    public partial class frmModelUsun : Form
    {
        wypModelTableAdapter usun;
        public frmModelUsun()
        {
            InitializeComponent();
            usun = new wypModelTableAdapter();
        }

        private void frmModelUsun_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wypoDataSet.wypModel' table. You can move, or remove it, as needed.
            this.wypModelTableAdapter.Fill(this.wypoDataSet.wypModel);

        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult wynik = MessageBox.Show("Można usunąć model jeśli nie ma wypożyczeń. Czy na pewno usunąć wybrany model?", "Usuwanie modelu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (wynik)
                {
                    case DialogResult.Yes:
                        usun.Delete(Convert.ToInt32(cmbModel.SelectedValue.ToString()));
                        this.Close();
                            break;
                }
            }
            catch
            {
                MessageBox.Show("Nie udało się usunąć modelu ponieważ ma na koncie wypożyczenia");
            }
        }
    }
}

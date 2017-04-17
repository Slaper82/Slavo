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
    public partial class frmMarkaUsun : Form
    {
        wypMarkaTableAdapter usun;
        public frmMarkaUsun()
        {
            InitializeComponent();
            usun = new wypMarkaTableAdapter();
        }

        private void frmMarkaUsun_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wypoDataSet.wypMarka' table. You can move, or remove it, as needed.
            this.wypMarkaTableAdapter.Fill(this.wypoDataSet.wypMarka);

        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult wynik = MessageBox.Show("Jeśli są wypożyczenia dla tej marki, nie można jej usunąć. Czy na pewno chcesz usunąć?", "Usuwanie marki", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (wynik)
                {
                    case DialogResult.Yes:
                        int id = Convert.ToInt32(cmbMarki.SelectedValue.ToString());
                        usun.DeleteMarkaModel(id);
                        usun.Delete(id);
                        this.Close();
                        break;
                }
                
            }
            catch
            {
                MessageBox.Show("Nie można usunąć marki bo są wypożyczenia i modele do niej przypisane!");
            }
        }
    }
}

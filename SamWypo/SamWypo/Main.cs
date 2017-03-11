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
    public partial class Main : Form
    {
        Helper data;
        public Main()
        {
            InitializeComponent();
            data = new Helper(DateTime.Now,DateTime.Now,dtpStart,dtpStop);
            data.UstawDate();
        }

        private void btnDodSam_Click(object sender, EventArgs e)
        {
            frmDodSamo nowy = new frmDodSamo();
            nowy.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKlient nowy = new frmKlient();
            nowy.dodano += Main_Load;
            nowy.Text = "Nowy Klient";
            nowy.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wypoDataSet.wypKlient' table. You can move, or remove it, as needed.
            this.wypKlientTableAdapter.Fill(this.wypoDataSet.wypKlient);
            // TODO: This line of code loads data into the 'wypoDataSet.wypSamochod' table. You can move, or remove it, as needed.
            this.wypSamochodTableAdapter.Fill(this.wypoDataSet.wypSamochod);
           
        }

        private void btnEKlient_Click(object sender, EventArgs e)
        {
            Klient edyt = new Klient();
            if (dgvKlient.SelectedRows.Count > 0)
            {
                edyt.Nazwa = dgvKlient.CurrentRow.Cells[1].FormattedValue.ToString();
                edyt.IdKlient =Convert.ToInt32(dgvKlient.CurrentRow.Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Wybierz klienta a nie...:)");
            }
            //frmKlient stary = new frmKlient();
            
        }

        private void dgvKlient_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvKlient.Columns[0].Visible = false;
        }
    }
}

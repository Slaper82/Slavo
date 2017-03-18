using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoMapper;

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

            //    List<Klient> ed = Mapper.Map<IDataReader, List<Klient>>(dgvKlient.DataSource);
            //   ItemId = row.Field<long?>(_ItemIdDataName) ?? value_if_null;
            DataTable g = dgvKlient.DataSource as DataTable;
          //  DataRow row = g.NewRow();
         DataRow   row    = ((DataRowView)dgvKlient.SelectedRows[0].DataBoundItem).Row;
         Klient edyt = new Klient(row);
            frmKlient Edytowany = new frmKlient(edyt);
            Edytowany.dodano += Main_Load;
            Edytowany.ShowDialog();
         
               // edyt.IdKlient=dgvKlient.Rows.
           //     edyt.IdKlient = Convert.ToInt32(dgvKlient.CurrentRow.Cells[0].Value.ToString());
            //    edyt.Nazwa = dgvKlient.CurrentRow.Cells[1].FormattedValue.ToString();
             //   edyt.NIP = dgvKlient.CurrentRow.Cells[2].FormattedValue.ToString();
              ////  edyt.Ulica = dgvKlient.CurrentRow.Cells[3].FormattedValue.ToString();
              //  edyt.Miasto = dgvKlient.CurrentRow.Cells[4].FormattedValue.ToString();
              //  edyt.NrDomu = dgvKlient.CurrentRow.Cells[5].FormattedValue.ToString();
              //  edyt.NrMieszk = dgvKlient.CurrentRow.Cells[6].FormattedValue.ToString();
              //  edyt.KodPoczt = dgvKlient.CurrentRow.Cells[7].FormattedValue.ToString();
              //  edyt.Tel1 = dgvKlient.CurrentRow.Cells[8].FormattedValue.ToString();
              //  edyt.OsobaKont = dgvKlient.CurrentRow.Cells[9].FormattedValue.ToString();

            //}
            //else
            //{
            //    MessageBox.Show("Wybierz klienta a nie...:)");
            //}
            //frmKlient stary = new frmKlient();
            
        }

        private void dgvKlient_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvKlient.Columns[0].Visible = false;
        }
    }
}

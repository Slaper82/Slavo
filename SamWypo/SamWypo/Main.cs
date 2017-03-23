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
using SamWypo.WypoDataSetTableAdapters;

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
            nowy.dodano += Main_Load;
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
            // TODO: This line of code loads data into the 'wypoDataSet1.SamoLista' table. You can move, or remove it, as needed.
            this.samoListaTableAdapter.Fill(this.wypoDataSet1.SamoLista);
            // TODO: This line of code loads data into the 'wypoDataSet.SamoLista' table. You can move, or remove it, as needed.
            this.samoListaTableAdapter.Fill(this.wypoDataSet.SamoLista);
            // TODO: This line of code loads data into the 'wypoDataSet.wypKlient' table. You can move, or remove it, as needed.
            this.wypKlientTableAdapter.Fill(this.wypoDataSet.wypKlient);
            // TODO: This line of code loads data into the 'wypoDataSet.wypSamochod' table. You can move, or remove it, as needed.
            this.wypSamochodTableAdapter.Fill(this.wypoDataSet.wypSamochod);
           
        }
      

        private void btnEKlient_Click(object sender, EventArgs e)
        {
             DataTable g = dgvKlient.DataSource as DataTable;
             DataRow   row    = ((DataRowView)dgvKlient.SelectedRows[0].DataBoundItem).Row;
             Klient edyt = new Klient(row);
             frmKlient Edytowany = new frmKlient(edyt);
             Edytowany.dodano += Main_Load;
             Edytowany.ShowDialog();                   
        }

        private void dgvKlient_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvKlient.Columns[0].Visible = false;
        }

        private void btnESamo_Click(object sender, EventArgs e)
        {
            int Id = 0;
            DataTable g = dgvKlient.DataSource as DataTable;
            DataRow row = ((DataRowView)dgvSamo.SelectedRows[0].DataBoundItem).Row;
            Id = row.Field<int>("IdSam");
            DataTable rr = wypSamochodTableAdapter.GetDataBy(Id);
           // DataRow row = ((DataRowView)dgvSamo.SelectedRows[0].DataBoundItem).Row;
            Samochod SamoEdyt = new Samochod(rr);
            frmDodSamo SamEdyt = new frmDodSamo(SamoEdyt);
            SamEdyt.dodano += Main_Load;
            SamEdyt.ShowDialog();

        }
    }
}

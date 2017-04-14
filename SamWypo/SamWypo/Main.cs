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
using SamWypo.Klasy;

namespace SamWypo
{
    public partial class Main : Form
    {
        Helper data;
        List<Wypo> filtr = new List<Wypo>();
        
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
            // TODO: This line of code loads data into the 'wypoDataSet1.wypWypoFull' table. You can move, or remove it, as needed.
            this.wypWypoFullTableAdapter.Fill(this.wypoDataSet1.wypWypoFull);
            // TODO: This line of code loads data into the 'wypoDataSet1.NapListaView' table. You can move, or remove it, as needed.
            this.napListaViewTableAdapter.Fill(this.wypoDataSet1.NapListaView);
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

        private void dgvNaprawa_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvNaprawa.Columns[4].Visible = false;
            dgvNaprawa.Columns[5].Visible = false;
        }

        private void btnNNapr_Click(object sender, EventArgs e)
        {
            frmNaprawa nowy = new frmNaprawa();
            nowy.dodano += Main_Load;
            nowy.ShowDialog();
        }

        private void btnNEdytuj_Click(object sender, EventArgs e)
        {
            DataTable g = dgvNaprawa.DataSource as DataTable;
            DataRow row = ((DataRowView)dgvNaprawa.SelectedRows[0].DataBoundItem).Row;
            Naprawa napr = new Naprawa(row);
            frmNaprawa edyt = new frmNaprawa(napr);
            edyt.dodano += Main_Load;
            edyt.ShowDialog();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmWypo nowy = new frmWypo();
            nowy.dodano += Main_Load;
            nowy.ShowDialog();
        }

        private void btnEdycja_Click(object sender, EventArgs e)
        {
            int Id = 0;
            DataTable g =dgvWypo.DataSource as DataTable;
            DataRow row = ((DataRowView)dgvWypo.SelectedRows[0].DataBoundItem).Row;
            Id = row.Field<int>("IdWypo");
            DataTable wyp = wypWypozyczTableAdapter1.GetDataBy(Id);
            Wypo WypoEdyt = new Wypo(wyp);
            frmWypo Wyp = new frmWypo(WypoEdyt);
            Wyp.dodano += Main_Load;
            Wyp.ShowDialog();
        }

        private void btnFiltruj_Click(object sender, EventArgs e)
        {
            Main_Load(this, e);
            Mapper();
        }
        private void Mapper()
        {
            Wypo lista = new Wypo();
            foreach(DataGridViewRow row in dgvWypo.Rows)
            {
               DateTime Strt= Convert.ToDateTime(row.Cells[5].Value.ToString());
                DateTime Stop = Convert.ToDateTime(row.Cells[6].Value.ToString());

                if (Strt < dtpStart.Value || Stop > dtpStop.Value)
                {
                  dgvWypo.Rows[row.Index].Visible = false;
                }
                //testuję filtry
                //lista.IdKlient =Convert.ToInt32( row.Cells[0].Value.ToString());
                //filtr.Add(lista);
            }
        }

        private void btnPokaz_Click(object sender, EventArgs e)
        {
            RaportKlient n = new RaportKlient(dgvRaport);
            n.RaportKlientPokaz();
        }
    }
}

﻿using System;
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
using SamWypo.Raporty;

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
            lblWart.Text= data.WartoscWypo(dtpStart.Value, dtpStop.Value).ToString();
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
            this.wypWypoFullTableAdapter.Fill(this.wypoDataSet1.wypWypoFull,dtpStart.Value,dtpStop.Value);
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
            //
            lblWart.Text=data.WartoscWypo(dtpStart.Value, dtpStop.Value).ToString()+" zł";
           
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
            DataTable g = dgvSamo.DataSource as DataTable;
            DataRow row = ((DataRowView)dgvSamo.SelectedRows[0].DataBoundItem).Row;
            Id = row.Field<int>("IdSam");
            DataTable rr = wypSamochodTableAdapter.GetDataBy(Id);
            Samochod SamoEdyt = new Samochod(rr);
            frmDodSamo SamEdyt = new frmDodSamo(SamoEdyt);
            SamEdyt.dodano += Main_Load;
            SamEdyt.ShowDialog();

        }

        private void dgvNaprawa_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvNaprawa.Columns[5].Visible = false;
            dgvNaprawa.Columns[6].Visible = false;
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
        private void btnUsun_Click(object sender, EventArgs e)
        {
            int Id = 0;
            DataTable g = dgvWypo.DataSource as DataTable;
            DataRow row = ((DataRowView)dgvWypo.SelectedRows[0].DataBoundItem).Row;
            Id = row.Field<int>("IdWypo");
            DataTable wyp = wypWypozyczTableAdapter1.GetDataBy(Id);
            Wypo del = new Wypo(wyp);
            del.Usun();
            Main_Load(this, e);
        }
        private void btnUSamo_Click(object sender, EventArgs e)
        {
            DataTable g = dgvSamo.DataSource as DataTable;
            DataRow row = ((DataRowView)dgvSamo.SelectedRows[0].DataBoundItem).Row;
           int Id = row.Field<int>("IdSam");
            DataTable rr = wypSamochodTableAdapter.GetDataBy(Id);
            Samochod samo = new Samochod(rr);
            DialogResult wynik = MessageBox.Show("Czy na pewno usunąć ten samochód?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (wynik)
            {
                case DialogResult.Yes:
                    samo.Usun();
                    Main_Load(this, e);
                    break;
            }
        }
        private void btnFiltruj_Click(object sender, EventArgs e)
        {
            Main_Load(this, e);
          //  Mapper();
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
            }
        }

        private void btnPokaz_Click(object sender, EventArgs e)
        {
            if (rdbKlient.Checked)
            {
                dgvRaport.DataSource = null;
                Mapowanie.WyczyscListy();
                RaportKlient raport = new RaportKlient();
                raport.PokazDane(dgvRaport, dtpRaportStr.Value, dtpRaportStp.Value);
            }
            else if (rdbSamo.Checked)
            {
                dgvRaport.DataSource = null;
                Mapowanie.WyczyscListy();
                RaportSamochod raport = new RaportSamochod();
                raport.PokazDane(dgvRaport, dtpRaportStr.Value, dtpRaportStp.Value);
            }
            else if (rdbNaprawy.Checked)
            {
                dgvRaport.DataSource = null;
                Mapowanie.WyczyscListy();
                RaportNaprawa raport = new RaportNaprawa();
                raport.PokazDane(dgvRaport, dtpRaportStr.Value, dtpRaportStp.Value);
            }
            else if(rdbWypo.Checked)
            {
                dgvRaport.DataSource = null;
                Mapowanie.WyczyscListy();
                RaportWypo raport = new RaportWypo();
                raport.PokazDane(dgvRaport, dtpRaportStr.Value, dtpRaportStp.Value);
            }
        }
        private void btnNUsun_Click(object sender, EventArgs e)
        {
            DataTable g = dgvNaprawa.DataSource as DataTable;
            DataRow row = ((DataRowView)dgvNaprawa.SelectedRows[0].DataBoundItem).Row;
            int Id = row.Field<int>("IdNapr");
            Naprawa napr = new Naprawa(row);
            DialogResult wynik = MessageBox.Show("Czy na pewno usunąć tą naprawę?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (wynik) 
            {
                case DialogResult.Yes:
                     napr.Usun();
                     Main_Load(this, e);
                     break;
            }
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarka nowa = new frmMarka();
            nowa.ShowDialog();
        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarkaUsun usun = new frmMarkaUsun();
            usun.ShowDialog();
        }

        private void dodajToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmModel nowy = new frmModel();
            nowy.ShowDialog();
        }

        private void usuńToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmModelUsun usun = new frmModelUsun();
            usun.ShowDialog();
        }

        private void samochódToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDBConfig baza = new frmDBConfig();
            baza.ShowDialog();
        }

        private void btnUKlient_Click(object sender, EventArgs e)
        {
            DataTable g = dgvKlient.DataSource as DataTable;
            DataRow row = ((DataRowView)dgvKlient.SelectedRows[0].DataBoundItem).Row;
            int Id = row.Field<int>("IdKlient");
            Klient klient = new Klient(row);
            DialogResult wynik = MessageBox.Show("Czy na pewno usunąć tego klienta?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (wynik)
            {
                case DialogResult.Yes:
                    klient.Usun();
                    Main_Load(this, e);
                    break;
            }
        }
    }
}

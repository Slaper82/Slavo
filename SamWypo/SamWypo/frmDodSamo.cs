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
    public partial class frmDodSamo : Form
    {
        private Samochod samochod { get; set; }
        public frmDodSamo()
        {
            InitializeComponent();
        }
        public frmDodSamo(Samochod samochd)
        {
            this.samochod = samochd;
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDodSamo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wypoDataSet.wypPaliwo' table. You can move, or remove it, as needed.
            this.wypPaliwoTableAdapter.Fill(this.wypoDataSet.wypPaliwo);
            // TODO: This line of code loads data into the 'wypoDataSet.wypModel' table. You can move, or remove it, as needed.
          //  this.wypModelTableAdapter.Fill(this.wypoDataSet.wypModel);
            // TODO: This line of code loads data into the 'wypoDataSet.wypMarka' table. You can move, or remove it, as needed.
            this.wypMarkaTableAdapter.Fill(this.wypoDataSet.wypMarka);

        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tutaj dopisać aktualizowanie cmb model na podstawie id marki
            //zapytania porobić do wybierania modeli na podstawie marki
        }

        private void wypMarkaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            // ((miastaBindingSource.Current as DataRowView).Row as JIPP4_MapaDataSet.MiastaRow).Id;
            int IdMarki = ((wypMarkaBindingSource.Current as DataRowView).Row as WypoDataSet.wypMarkaRow).IdMarka;
           wypModelMarkTableAdapter.Fill(wypoDataSet.wypModelMark, IdMarki);
        }
    }
}

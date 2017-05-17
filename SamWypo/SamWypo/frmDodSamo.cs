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
        public int IdMarka { get; set; }
        public event Dodano dodano;
        public frmDodSamo()
        {
            InitializeComponent();
           
        }
        public frmDodSamo(Samochod samochd)
        {
            InitializeComponent();
            this.samochod = samochd;
            samochodBindingSource.DataSource = this.samochod;
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (samochod != null)
            {
                samochod.ZapiszEdyt();
                
            }
            else
            {
                int Marka = Convert.ToInt32(cmbMarka.SelectedValue.ToString());
                int Model = Convert.ToInt32(cmbModel.SelectedValue.ToString());
                int Paliwo = Convert.ToInt32(cmbPaliwo.SelectedValue.ToString());
                int RokPRod = Convert.ToInt32(txtRokProd.Text);
                decimal Poj = Convert.ToDecimal(txtPoj.Text);
                //tutaj zrobić przypisanie kontrolek do edycji
                this.samochod = new Samochod(Marka,Model,txtRej.Text,false,RokPRod,Paliwo,Poj,txtKolor.Text,true);
                samochod.ZapiszNowe();              
                //samochodBindingSource.DataSource = this.samochod;
            }
            if (dodano != null) dodano(this, e);
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
            try
            {
                cmbMarka.SelectedValue = samochod.IdMarka;
                cmbModel.SelectedValue = samochod.IdModel;
                cmbPaliwo.SelectedValue = samochod.IdPaliwa;
            }
            catch { }
            

        }

        private void wypMarkaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
           this.IdMarka = ((wypMarkaBindingSource.Current as DataRowView).Row as WypoDataSet.wypMarkaRow).IdMarka;
            this.wypModelMarkTableAdapter.Fill(wypoDataSet.wypModelMark, this.IdMarka);
        }

        private void cmbMarka_SelectedValueChanged(object sender, EventArgs e)
        {
           // frmDodSamo_Load(this, e);
        }

        private void txtRokProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPoj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

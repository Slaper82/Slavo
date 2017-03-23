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
                //tutaj zrobić przypisanie kontrolek do edycji
                this.samochod = new Samochod();              
                samochodBindingSource.DataSource = this.samochod;
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
    }
}

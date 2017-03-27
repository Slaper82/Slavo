using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamWypo.Klasy
{
    public partial class frmNaprawa : Form
    {
        public event Dodano dodano;
        public Naprawa naprawa { get; set; }
        public frmNaprawa()
        {
            InitializeComponent();
        }

        public frmNaprawa(Naprawa Enapr)
        {
            InitializeComponent();
            this.naprawa = Enapr;
            samoWybBindingSource.DataSource = this.naprawa;
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNaprawa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wypoDataSet.SamoWyb' table. You can move, or remove it, as needed.
            this.samoWybTableAdapter.Fill(this.wypoDataSet.SamoWyb);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamWypo
{
    public partial class frmDBConfig : Form
    {
        public frmDBConfig()
        {
            InitializeComponent();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            //Data Source = localhost; Initial Catalog = SlaWypo; Persist Security Info = True; User ID = przefoltyn; Password = Alamakota1!@
            StringBuilder Con = new StringBuilder();
            Con.Append("Data Source=");
            Con.Append(txtSrv.Text);
            Con.Append(";Initial Catalog=");
            Con.Append(txtBaza.Text);
            Con.Append("; Persist Security Info = True; User ID =");
            Con.Append(txtLogin.Text);
            Con.Append(";Password=");
            Con.Append(txtPass.Text);
            string ConnectionString = Con.ToString();
            string sciezka = String.Format(Application.StartupPath.ToString() + @"\connection.txt");
            File.WriteAllText(sciezka, ConnectionString);
            this.Close();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

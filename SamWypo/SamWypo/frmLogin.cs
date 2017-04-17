using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace SamWypo
{
    public partial class frmLogin : Form
    {
        public string Connection { get; set; }

        public frmLogin()
        {
            InitializeComponent();
            OdczytajPolaczenie();
            UstawPolaczenie();
        }
        public void OdczytajPolaczenie()
        {
            string sciezka = String.Format(Application.StartupPath.ToString() + @"\connection.txt");
            string con = File.ReadAllText(sciezka);
            this.Connection = con;
        }
        public void UstawPolaczenie()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["SamWypo.Properties.Settings.SlaWypoConnectionString"].ConnectionString = Connection;// "Data Source=localhost;Initial Catalog=SlaWypo;Persist Security Info=True;User ID=przefoltyn;Password=Alamakota1!@";
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
        }
        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            Main program = new Main();
            this.Owner = program;
            program.Show();
            this.Hide();
        }

        private void konfiguracjaBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDBConfig baza = new frmDBConfig();
            baza.ShowDialog();
        }
    }
}

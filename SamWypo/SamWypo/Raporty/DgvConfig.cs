using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamWypo.Raporty
{
  public class DgvConfig
    {
        public DataGridView dgv { get; set; }
        public DgvConfig(DataGridView DGV)
        {
            this.dgv = DGV;
        }

        public DataGridView Klient()
        {
            DataGridViewColumn NazwaKlienta = new DataGridViewTextBoxColumn();
            NazwaKlienta.Name = "Nazwa";
            NazwaKlienta.DataPropertyName = "Nazwa";
            NazwaKlienta.HeaderText = "Nazwa klienta";
            NazwaKlienta.Width = 300;
            NazwaKlienta.ReadOnly = true;

            DataGridViewColumn DoZaplaty = new DataGridViewTextBoxColumn();
            DoZaplaty.Name = "columnDozaplaty";
            DoZaplaty.DataPropertyName = "Dozaplaty";
            DoZaplaty.HeaderText = "Do zapłaty";
            DoZaplaty.Width = 300;
            DoZaplaty.ReadOnly = true;
            dgv.Columns.Add(NazwaKlienta);
            dgv.Columns.Add(DoZaplaty);
            return dgv;
        }

    }
}

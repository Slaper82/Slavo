using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SamWypo.WypoDataSetTableAdapters;
using System.Data.SqlClient;
using SamWypo.Raporty;

namespace SamWypo.Klasy
{
    public class RaportKlient
    {
       // public DataGridView dgv { get; set; }

        public string NazwaKlienta { get; set; }
        public decimal Dozaplaty { get; set; }
        public RaportKlient()
        {

        }

        public void PokazDane(DataGridView datagrid,DateTime Start,DateTime Stop)
        {
           DgvConfig dane = new DgvConfig(datagrid);
           dane.Klient();
           dane.dgv.DataSource = Mapowanie.KlientGetData(SqlQuery.KlienciAll(Start,Stop));
        }
    }
   
    
}

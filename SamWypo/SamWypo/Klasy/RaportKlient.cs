using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SamWypo.WypoDataSetTableAdapters;
using System.Data.SqlClient;

namespace SamWypo.Klasy
{
    public class RaportKlient
    {
        public DataGridView dgv { get; set; }

        public string NazwaKlienta { get; set; }
        public decimal Dozaplaty { get; set; }
        public RaportKlient()
        {

        }
        public RaportKlient(DataGridView DGV)
        {
            this.dgv = DGV;
        }
        public void RaportKlientPokaz()
        {
            UstawDgv();

        }
        private void UstawDgv()
        {
            DataGridViewColumn NazwaKlienta = new DataGridViewTextBoxColumn();
            NazwaKlienta.Name = "columnNazwaKlienta";
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

          //  this.dgv.Columns.Add(NazwaKlienta);
           // this.dgv.Columns.Add(DoZaplaty);
            this.dgv.DataSource = Mapowanie.Mapper();
            dgv.Columns[0].Visible = false;
        }
    }
    public static class Mapowanie
    {
       static List<RaportKlient> listaKlientRap = new List<RaportKlient>();
        public static List<RaportKlient> Mapper()
        {
          //  SqlConnection
            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = Properties.Settings.Default.SlaWypoConnectionString;
            string sql = @"select k.Nazwa,sum(Stawka) as 'Dozaplaty' from wypWypoDni as wd
join wypKlient k on wd.IdKlient=k.IdKlient
group by k.Nazwa ";
            Connection.Open();
            SqlCommand command = new SqlCommand(sql,Connection);
            using(SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    listaKlientRap.Add(MapowaniePol(reader));
                }
            }
            return listaKlientRap;
        }
        private static RaportKlient MapowaniePol(SqlDataReader reader)
        {
            RaportKlient entity = new RaportKlient();
            entity.NazwaKlienta = reader.GetString(reader.GetOrdinal("Nazwa"));
            entity.Dozaplaty = reader.GetDecimal(reader.GetOrdinal("Dozaplaty"));
            return entity;
        }
    }
}

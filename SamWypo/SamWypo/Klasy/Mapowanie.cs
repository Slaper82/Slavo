using SamWypo.Raporty;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamWypo.Klasy
{
    public static class Mapowanie
    {
        static List<RaportKlient> listaKlientRap = new List<RaportKlient>();
        static List<RaportSamochod> listaSamochodRap = new List<RaportSamochod>();
        static List<RaportNaprawa> listaNaprawRap = new List<RaportNaprawa>();
        static List<RaportWypo> listaWypoRap = new List<RaportWypo>();
        #region GetData
        public static List<RaportKlient>KlientGetData(String sql)
        {
            //  SqlConnection
            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = Properties.Settings.Default.SlaWypoConnectionString;
            Connection.Open();
            SqlCommand command = new SqlCommand(sql, Connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    listaKlientRap.Add(KlientMapowaniePol(reader));
                }
            }
            return listaKlientRap;
        }
        public static List<RaportSamochod> SamochodGetData(String sql)
        {
            //  SqlConnection
            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = Properties.Settings.Default.SlaWypoConnectionString;
            Connection.Open();
            SqlCommand command = new SqlCommand(sql, Connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    listaSamochodRap.Add(SamochodMapowaniePol(reader));
                }
            }
            return listaSamochodRap;
        }
        public static List<RaportNaprawa> NaprawaGetData(String sql)
        {
            //  SqlConnection
            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = Properties.Settings.Default.SlaWypoConnectionString;
            Connection.Open();
            SqlCommand command = new SqlCommand(sql, Connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    listaNaprawRap.Add(NaprawaMapowaniePol(reader));
                }
            }
            return listaNaprawRap;
        }
        public static List<RaportWypo> WypoGetData(String sql)
        {
            //  SqlConnection
            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = Properties.Settings.Default.SlaWypoConnectionString;
            Connection.Open();
            SqlCommand command = new SqlCommand(sql, Connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    listaWypoRap.Add(WypoMapowaniePol(reader));
                }
            }
            return listaWypoRap;
        }
        #endregion
        #region Mapowanie pol
        private static RaportKlient KlientMapowaniePol(SqlDataReader reader)
        {
            RaportKlient entity = new RaportKlient();
            entity.NazwaKlienta = reader.GetString(reader.GetOrdinal("Nazwa"));
            entity.Dozaplaty = reader.GetDecimal(reader.GetOrdinal("Dozaplaty"));
            return entity;
        }
        private static RaportSamochod SamochodMapowaniePol(SqlDataReader reader)
        {
            RaportSamochod entity = new RaportSamochod();
            entity.Nazwa = reader.GetString(reader.GetOrdinal("NazwaSamo"));
            entity.TablRej = reader.GetString(reader.GetOrdinal("TablRej"));
            entity.Kwota = reader.GetDecimal(reader.GetOrdinal("KwotaSuma"));
            return entity;

        }
        private static RaportNaprawa NaprawaMapowaniePol(SqlDataReader reader)
        {
            RaportNaprawa entity = new RaportNaprawa();
            entity.NazwaSamo = reader.GetString(reader.GetOrdinal("Nazwa"));
            entity.Tablica = reader.GetString(reader.GetOrdinal("Tabl"));
            entity.IloscNaprawa = reader.GetInt32(reader.GetOrdinal("ilNapr"));
            entity.Zapl = reader.GetDecimal(reader.GetOrdinal("Zapl"));
            return entity;
        }
        private static RaportWypo WypoMapowaniePol(SqlDataReader reader)
        {
            RaportWypo entity = new RaportWypo();
            entity.Nazwa =reader.GetString(reader.GetOrdinal("WR"));
                //reader.GetString(reader.GetOrdinal());
            entity.Zaplata = reader.GetDecimal(reader.GetOrdinal("suma"));
            //entity.IloscNapraw = reader.GetInt32(reader.GetOrdinal("Ilosc"));
            return entity;
        }
        #endregion
        #region Czyszczenie List
        public static void WyczyscListy()
        {
            listaKlientRap.Clear();
            listaNaprawRap.Clear();
            listaSamochodRap.Clear();
            listaWypoRap.Clear();
        }
        #endregion
    }
}

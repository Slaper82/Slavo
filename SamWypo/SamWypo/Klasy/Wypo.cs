using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SamWypo.WypoDataSetTableAdapters;
using System.Windows.Forms;
using System.Data;

namespace SamWypo
{
   public class Wypo : IObsluga
    {
        public int IdWypo { get; set; }
        public int IdSamo { get; set; }
        public int IdKlient { get; set; }
        public DateTime  DStart { get; set; }
        public DateTime DStop { get; set; }
        public decimal Stawka { get; set; }
        public decimal Suma { get; set; }
        wypWypozyczTableAdapter wypozycz;

        

        public Wypo()
        {
            wypozycz = new wypWypozyczTableAdapter();
        }
        public Wypo(int idsamo,int idklient,DateTime dstart,DateTime dstop,decimal stawka, decimal suma):this()
        {
            this.IdSamo = idsamo;
            this.IdKlient = idklient;
            this.DStart = dstart;
            this.DStop = dstop;
            this.Stawka = stawka;
            this.Suma = suma;
        }
        public Wypo(int idwypo,int idsamo, int idklient, DateTime dstart, DateTime dstop, decimal stawka, decimal suma) : this()
        {
            this.IdWypo = idwypo;
            this.IdSamo = idsamo;
            this.IdKlient = idklient;
            this.DStart = dstart;
            this.DStop = dstop;
            this.Stawka = stawka;
            this.Suma = suma;
        }
        public Wypo(DataTable table):this()
        {
            DataRow row = table.Rows[0];
            this.IdWypo = row.Field<int>("IdWypo"); 
            this.IdSamo = row.Field<int>("IdSamo");
            this.IdKlient = row.Field<int>("IdKlient");
            this.DStart = row.Field<DateTime>("DStart");
            this.DStop = row.Field<DateTime>("DStop");
            this.Stawka = row.Field<decimal>("Stawka");
            this.Suma = row.Field<decimal>("Suma");
        }
        public bool Sprawdz()
        {
            throw new NotImplementedException();
        }

        public void Usun()
        {
            throw new NotImplementedException();
        }

        public void ZapiszEdyt()
        {
            try
            {
                Suma = Convert.ToDecimal((DStop - DStart).TotalDays) * Stawka;
                wypozycz.Update(IdSamo, IdKlient, DStart, DStop, Stawka, Suma, IdWypo);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ZapiszNowe()
        {
            try
            {
                Suma = Convert.ToDecimal((DStop - DStart).TotalDays) * Stawka;
                wypozycz.Insert(IdSamo, IdKlient, DStart, DStop, Stawka, Suma);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Błąd zapisu",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}

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
        wypWypoDniTableAdapter wypodni;
        

        public Wypo()
        {
            wypozycz = new wypWypozyczTableAdapter();
            wypodni = new wypWypoDniTableAdapter();
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
            if (UsunTrans(IdWypo)) UsunWypo(IdWypo);
            else MessageBox.Show("Nie udało się usunąć wypożyczenia");
        }

        public void ZapiszEdyt()
        {
            try
            {
                Suma = Math.Round(Convert.ToDecimal((DStop - DStart).TotalDays) * Stawka);
                wypozycz.Update(IdSamo, IdKlient, DStart.Date, DStop.Date, Stawka, Suma, IdWypo);
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
                Suma = Math.Round(Convert.ToDecimal((DStop - DStart).TotalDays) * Stawka);
                decimal t = Convert.ToDecimal((DStop - DStart).TotalDays) * Stawka;
                wypozycz.Insert(IdSamo, IdKlient, DStart.Date, DStop.Date, Stawka, Suma);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Błąd zapisu",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public void ZapiszTransakcje(DateTime Start,DateTime Stop,int IdWypo)
        {
            
            while (Math.Round((Start - Stop).TotalDays)!=0)
            {
                try
                {
                    wypodni.InsertWyp(IdSamo, IdKlient, Start.Date.ToString(), Stawka,IdWypo);
                 Start= Start.AddDays(1);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        public bool UsunTrans(int IdWypo)
        {
            try
            {
                    wypodni.DeleteWyp(IdWypo);
                return true;

            }
            catch
            {
                return false; 
            }
        }
        public int PokazIdWypo()
        {
            int id;
            string test = Convert.ToString(wypozycz.IdWypo(IdSamo, IdKlient, DStart.Date, DStop.Date, Stawka));
            Int32.TryParse(test, out id);
            return id;
        }
        public bool UsunWypo(int Id)
        {
            try
            {
                wypozycz.Delete(Id);
                return true;
            }
            catch { return false; }
        }
    }
}

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
   public class Samochod:IObsluga
    {
        public int IdSam { get; set; }
        public int IdMarka { get; set; }
        public int IdModel { get; set; }
        public string TabRej { get; set; }
        public bool Status { get; set; }
        public int RokProd { get; set; }
        public int IdPaliwa { get; set; }
        public string Kolor { get; set; }
        public decimal Pojemnosc { get; set; }
        public bool Active { get; set; }

        wypSamochodTableAdapter samochod;
        public Samochod()
        {
            samochod = new wypSamochodTableAdapter();
        }
        public Samochod(int idmarka,int idmodel,string rejestr,bool stat,int rokprod,int idpaliwo,decimal pojemnosc,string kolor,bool active):this()
        {
            this.IdMarka = idmarka;
            this.IdModel = idmodel;
            this.TabRej = rejestr;
            this.Status = stat;
            this.RokProd = rokprod;
            this.IdPaliwa = idpaliwo;
            this.Pojemnosc = pojemnosc;
            this.Kolor = kolor;
            this.Active = active;
        }
        public Samochod(int IdSam,int idmarka, int idmodel, string rejestr, bool stat, int rokprod, int idpaliwo, decimal pojemnosc, string kolor, bool active) : this()
        {
            this.IdSam = IdSam;
            this.IdMarka = idmarka;
            this.IdModel = idmodel;
            this.TabRej = rejestr;
            this.Status = stat;
            this.RokProd = rokprod;
            this.IdPaliwa = idpaliwo;
            this.Pojemnosc = pojemnosc;
            this.Kolor = kolor;
            this.Active = active;
        }
        public Samochod(DataTable table):this()
        {
            DataRow row = table.Rows[0];
            this.IdSam = row.Field<int>("IdSam");
            this.IdMarka = row.Field<int>("IdMarka");
            this.IdModel = row.Field<int>("IdModel");
            this.TabRej = row.Field<string>("TablRej");
            this.Status = row.Field<bool>("Status");
            this.RokProd = row.Field<int>("RokProd");
            this.IdPaliwa = row.Field<int>("IdPaliwa");
            this.Pojemnosc = row.Field<decimal>("Pojemnosc");
            this.Kolor = row.Field<string>("Kolor");
            this.Active = row.Field<bool>("Active");
        }
        public void ZapiszNowe()
        {
            try
            {
                samochod.Insert(IdMarka, IdModel, TabRej, Status, RokProd, IdPaliwa, Kolor, Pojemnosc, Active);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void ZapiszEdyt()
        {
            try
            {
                samochod.Update(IdMarka, IdModel, TabRej, Status, RokProd, IdPaliwa, Kolor, Pojemnosc, Active, IdSam);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void Usun()
        {
            throw new NotImplementedException();
        }

        public bool Sprawdz()
        {
            throw new NotImplementedException();
        }
    }
  
}



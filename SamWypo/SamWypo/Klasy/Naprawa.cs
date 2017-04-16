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
  public class Naprawa : IObsluga
    {
        public int IdNapr { get; set; }
        public int IdSamo { get; set; }
        public DateTime DStart { get; set; }
        public DateTime DStop { get; set; }
        public double Kwota { get; set; }
        public string Opis { get; set; }
        wypNaprawaTableAdapter nowa;
        wypNaprawaTableAdapter edyt;
        

        public Naprawa()
        {
            nowa = new wypNaprawaTableAdapter();
            edyt = new wypNaprawaTableAdapter();
        }
        

        public Naprawa(int idnapr,int idsamo, DateTime dstart, DateTime dstop, double kwota,string opis):this()
        {
            this.IdNapr = idnapr;
            this.IdSamo = idsamo;
            this.DStart = dstart;
            this.DStop = dstop;
            this.Kwota = kwota;
            this.Opis = opis;
        }
        public Naprawa(int idsamo,DateTime dstart,DateTime dstop, double kwota,string opis):this()
        {
            this.IdSamo = idsamo;
            this.DStart = dstart;
            this.DStop = dstop;
            this.Kwota = kwota;
            this.Opis = opis;
        }
        public Naprawa(DataRow row):this()
        {
            string tmp = String.Empty;
            this.IdNapr = row.Field<int>("IdNapr");
            this.IdSamo = row.Field<int>("IdSamo");
            this.DStart = row.Field<DateTime>("DStart");
            this.DStop = row.Field<DateTime>("DStop");
            tmp = row.Field<decimal>("Kwota").ToString();
            tmp.Replace(".", ",");
            this.Kwota = Convert.ToDouble(tmp);
            this.Opis = row.Field<string>("Opis");

        }
        public bool Sprawdz()
        {
            if (IdSamo == 0 || DStart == null || DStop == null || Kwota == 0) return false;
            else return true;
 
        }

        public void Usun()
        {
            edyt.Delete(IdNapr);
        }

        public void ZapiszEdyt()
        {
            try
            {
                edyt.UpdateNapr(IdSamo, DStart, DStop, Convert.ToDecimal(Kwota), Opis,IdNapr);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void ZapiszNowe()
        {
            try
            { 
            nowa.Insert(IdSamo, DStart, DStop, Convert.ToDecimal(Kwota),Opis);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
}
    }
}

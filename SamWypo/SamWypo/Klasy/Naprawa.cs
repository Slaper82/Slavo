using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamWypo
{
  public class Naprawa : IObsluga
    {
        public int IdNapr { get; set; }
        public int IdSamo { get; set; }
        public DateTime DStart { get; set; }
        public DateTime DStop { get; set; }
        public double Kwota { get; set; }

        public Naprawa()
        {

        }

        public Naprawa(int idnapr,int idsamo, DateTime dstart, DateTime dstop, double kwota)
        {
            this.IdNapr = idnapr;
            this.IdSamo = idsamo;
            this.DStart = dstart;
            this.DStop = dstop;
            this.Kwota = kwota;
        }
        public Naprawa(int idsamo,DateTime dstart,DateTime dstop,double kwota)
        {
            this.IdSamo = idsamo;
            this.DStart = dstart;
            this.DStop = dstop;
            this.Kwota = kwota; 
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
            throw new NotImplementedException();
        }

        public void ZapiszNowe()
        {
            throw new NotImplementedException();
        }
    }
}

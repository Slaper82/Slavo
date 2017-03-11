using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamWypo
{
    class Wypo : IObsluga
    {
        public int IdWypo { get; set; }
        public int IdSamo { get; set; }
        public int IdKlient { get; set; }
        public DateTime  DStart { get; set; }
        public DateTime DStop { get; set; }
        public double Stawka { get; set; }
        public double Suma { get; set; }

        public Wypo()
        {

        }
        public Wypo(int idsamo,int idklient,DateTime dstart,DateTime dstop,double stawka,double suma):this()
        {
            this.IdSamo = idsamo;
            this.IdKlient = idklient;
            this.DStart = dstart;
            this.DStop = dstop;
            this.Stawka = stawka;
            this.Suma = suma;
        }
        public Wypo(int idwypo,int idsamo, int idklient, DateTime dstart, DateTime dstop, double stawka, double suma) : this()
        {
            this.IdWypo = idwypo;
            this.IdSamo = idsamo;
            this.IdKlient = idklient;
            this.DStart = dstart;
            this.DStop = dstop;
            this.Stawka = stawka;
            this.Suma = suma;
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

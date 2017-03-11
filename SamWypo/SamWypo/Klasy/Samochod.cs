using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamWypo
{      
    class Samochod:IObsluga
    {
        public int IdSam { get; set; }
        public int IdMarka { get; set; }
        public int IdModel { get; set; }
        public string TabRej { get; set; }
        public bool Status { get; set; }
        public int RokProd { get; set; }
        public int IdPaliwa { get; set; }
        public string Kolor { get; set; }
        public bool Active { get; set; }


        public Samochod()
        {

        }
        public Samochod(int idmarka,int idmodel,string rejestr,bool stat,int rokprod,int idpaliwo,string kolor,bool active):this()
        {
            this.IdMarka = idmarka;
            this.IdModel = idmodel;
            this.TabRej = rejestr;
            this.Status = stat;
            this.RokProd = rokprod;
            this.IdPaliwa = idpaliwo;
            this.Kolor = kolor;
            this.Active = active;
        }

        public void ZapiszNowe()
        {
            throw new NotImplementedException();
        }

        public void ZapiszEdyt()
        {
            throw new NotImplementedException();
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



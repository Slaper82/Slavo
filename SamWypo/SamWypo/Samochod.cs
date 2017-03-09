using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamWypo
{
//[IdSam]  int identity(1,1) not null primary key,
//[IdMarka] int not null,
//[IdModel]    int not null,
//[TablRej] nvarchar(12) not null,
//[Status]    bit not null default(0),
//[RokProd]    int not null,
//[IdPaliwa]    int not null,
//[Kolor]nvarchar(30) null,
//[Active]    bit default(1)
//)

        
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

    }
    public interface IObsluga
    {
        void ZapiszNowe();
        void ZapiszEdyt();
        void Usun();
        void Sprawdz();

    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SamWypo.WypoDataSetTableAdapters;
using System.Data;

namespace SamWypo
{
  public class Klient:IObsluga
    {
        
        public int IdKlient { get; set; }
        public string Nazwa { get; set; }
        public string NIP { get; set; }
        public string Ulica { get; set; }
        public string Miasto { get; set; }
        public string NrDomu { get; set; }
        public string NrMieszk { get; set; }
        public string KodPoczt { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string OsobaKont { get; set; }

        wypKlientTableAdapter nowy;
        KlientObslTableAdapter edycja;
        public Klient()
        {
            nowy = new wypKlientTableAdapter();
            edycja = new KlientObslTableAdapter();
        }

        public Klient(string Nazwa,string nip,string ulica,string miasto,string nrdom,string nrmieszk,string kodpoczt,string tel1,string tel2,string osoba):this()
        {
            this.Nazwa = Nazwa;
            this.NIP = nip;
            this.Ulica = ulica;
            this.Miasto = miasto;
            this.NrDomu = nrdom;
            this.NrMieszk = nrmieszk;
            this.KodPoczt = kodpoczt;
            this.Tel1 = tel1;
            this.Tel2 = tel2;
            this.OsobaKont = osoba;
        }
        public Klient(DataRow row)
        {

            this.IdKlient = row.Field<int>("IdKlient");
            this.Nazwa = row.Field<string>("Nazwa");
            this.NIP = row.Field<string>("NIP");
            this.Ulica = row.Field<string>("Ulica");
            this.Miasto = row.Field<string>("Miasto");
            this.NrDomu = row.Field<string>("NrDomu");
            this.NrMieszk = row.Field<string>("NrMieszkania");
            this.KodPoczt = row.Field<string>("KodPocz");
            this.Tel1 = row.Field<string>("Tel");
            this.OsobaKont = row.Field<string>("OsobaKont");

        }
        public bool Sprawdz()
        {
            if (this.Nazwa == ""||this.NIP == ""||this.Ulica == ""||this.Miasto == ""||this.NrDomu == ""||this.KodPoczt == "")
            {
                return false;
            }
            else
                return true;
        }

        public void ZapiszEdyt()
        {
            edycja = new KlientObslTableAdapter();
            try
            {
                edycja.ZapKlientEdyt(IdKlient, Nazwa, NIP, Ulica, Miasto, NrDomu, NrMieszk, KodPoczt, Tel1, OsobaKont);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nie można zapisać bo: \n"+ex.ToString());
            }
            
         //   Dorobic zapis po edycji
        }
     
        public  void ZapiszNowe()
        {
            nowy.Insert(Nazwa, NIP, Ulica, Miasto, NrDomu, NrMieszk, KodPoczt, Tel1, OsobaKont);
            //throw new NotImplementedException();
        }

        public void Usun()
        {
         //   throw new NotImplementedException();
        }


    }
}

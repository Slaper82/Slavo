using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamWypo
{
    class Marka:IObsluga
    {
        public int IdMarka { get; set; }
        public string Nazwa { get; set; }

        public Marka()
        {

        }
        public Marka(string nazwa)
        {
            this.Nazwa = nazwa;
        }
        public Marka(int id,string nazwa)
        {
            this.IdMarka = id;
            this.Nazwa = nazwa;
        }
        public bool Sprawdz()
        {
            if (this.Nazwa == String.Empty)
            {
                return false;
            }
            else
                return true;
        }
        public void ZapiszNowa()
        {

        }
        public void ZapiszEdyt()
        {

        }
        public void Usun()
        {

        }
    }
    class Model:IObsluga
    {
        public int IdModel { get; set; }
        public string Nazwa { get; set; }
        public int Marka { get; set; }

        public Model()
        {
            Marka = 0;
        }
        public Model(string nazwa,int marka)
        {
            this.Nazwa = nazwa;
            this.Marka = marka;
        }
        public Model(int IdModel,string nazwa,int idMarka)
        {
            this.IdModel = IdModel;
            this.Nazwa = nazwa;
            this.Marka = idMarka;
        }
        public bool Sprawdz()
        {
            if (Nazwa == String.Empty || this.Marka == 0)
            {
                return false;
            }
            else
                return true;
        }
        public void ZapiszNowy()
        {

        }
        public void ZapiszEdyt()
        {

        }
        public void Usun()
        {

        }
    }
}

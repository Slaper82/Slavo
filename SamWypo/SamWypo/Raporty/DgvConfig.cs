using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamWypo.Raporty
{
  public class DgvConfig
    {
        public DataGridView dgv { get; set; }
        public DgvConfig(DataGridView DGV)
        {
            this.dgv = null;
            this.dgv = DGV;
        }

        public DataGridView Klient()
        {
            DataGridViewColumn NazwaKlienta = new DataGridViewTextBoxColumn();
            NazwaKlienta.Name = "Nazwa";
            NazwaKlienta.DataPropertyName = "NazwaKlienta";
            NazwaKlienta.HeaderText = "Nazwa klienta";
            NazwaKlienta.Width = 300;
            NazwaKlienta.ReadOnly = true;

            DataGridViewColumn DoZaplaty = new DataGridViewTextBoxColumn();
            DoZaplaty.Name = "columnDozaplaty";
            DoZaplaty.DataPropertyName = "Dozaplaty";
            DoZaplaty.HeaderText = "Do zapłaty";
            DoZaplaty.Width = 300;
            DoZaplaty.ReadOnly = true;
            dgv.Columns.Add(NazwaKlienta);
            dgv.Columns.Add(DoZaplaty);
            return dgv;
        }
        public DataGridView Samochod()
        {
            DataGridViewColumn Samo = new DataGridViewTextBoxColumn();
            Samo.Name = "Nazwa";
            Samo.DataPropertyName = "Nazwa";
            Samo.HeaderText = "Nazwa samochodu";
            Samo.Width = 300;
            Samo.ReadOnly = true;

            DataGridViewColumn TablRej=new DataGridViewTextBoxColumn();
            TablRej.Name = "TablRej";
            TablRej.DataPropertyName = "TablRej";
            TablRej.HeaderText = "Tablica Rejestracyjna";
            TablRej.Width = 300;
            TablRej.ReadOnly = true;

            DataGridViewColumn DoZaplaty = new DataGridViewTextBoxColumn();
            DoZaplaty.Name = "columnDozaplaty";
            DoZaplaty.DataPropertyName = "Kwota";
            DoZaplaty.HeaderText = "Do zapłaty";
            DoZaplaty.Width = 300;
            DoZaplaty.ReadOnly = true;
            dgv.Columns.Add(Samo);
            dgv.Columns.Add(TablRej);
            dgv.Columns.Add(DoZaplaty);
           
            
            return dgv;
        }
        public DataGridView Wypo()
        {
            DataGridViewColumn Wyp= new DataGridViewTextBoxColumn();
            Wyp.Name = "Opis";
            Wyp.DataPropertyName = "Nazwa";
            Wyp.HeaderText = " ";
            Wyp.Width = 300;
            Wyp.ReadOnly = true;

            DataGridViewColumn Suma = new DataGridViewTextBoxColumn();
            Suma.Name = "suma";
            Suma.DataPropertyName = "Zaplata";
            Suma.HeaderText = " ";
            Suma.Width = 150;
            Suma.ReadOnly = true;

            dgv.Columns.Add(Wyp);
            dgv.Columns.Add(Suma);

            return dgv;
        }
        public DataGridView Naprawa()
        {
            DataGridViewColumn Napr= new DataGridViewTextBoxColumn();
            Napr.Name = "Nazwa";
            Napr.DataPropertyName = "NazwaSamo";
            Napr.HeaderText = "Nazwa samochodu";
            Napr.Width = 300;
            Napr.ReadOnly = true;

            DataGridViewColumn TablRej = new DataGridViewTextBoxColumn();
            TablRej.Name = "Tabl";
            TablRej.DataPropertyName = "Tablica";
            TablRej.HeaderText = "Tablica Rejestracyjna";
            TablRej.Width = 300;
            TablRej.ReadOnly = true;

            DataGridViewColumn DoZaplaty = new DataGridViewTextBoxColumn();
            DoZaplaty.Name = "columnDozaplaty";
            DoZaplaty.DataPropertyName = "Zapl";
            DoZaplaty.HeaderText = "Do zapłaty";
            DoZaplaty.Width = 300;
            DoZaplaty.ReadOnly = true;
           
            DataGridViewColumn IloscNapraw = new DataGridViewTextBoxColumn();
            IloscNapraw.Name = "columnNaprawy";
            IloscNapraw.DataPropertyName = "IloscNaprawa";
            IloscNapraw.HeaderText = "Ilość napraw";
            IloscNapraw.Width = 150;
            IloscNapraw.ReadOnly = true;

            //
            dgv.Columns.Add(Napr);
            dgv.Columns.Add(TablRej);
            dgv.Columns.Add(IloscNapraw);
            dgv.Columns.Add(DoZaplaty);
            

            return dgv;
        }
    }
}

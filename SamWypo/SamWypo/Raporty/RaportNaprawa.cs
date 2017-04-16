using SamWypo.Klasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamWypo.Raporty
{
   public class RaportNaprawa
    {
        public string NazwaSamo { get; set; }
        public decimal Zapl { get; set; }
        public string Tablica { get; set; }
        public int IloscNaprawa { get; set; }

        public void PokazDane(DataGridView datagrid, DateTime Start, DateTime Stop)
        {
            DgvConfig dane = new DgvConfig(datagrid);
            dane.Naprawa();
            dane.dgv.DataSource = Mapowanie.NaprawaGetData(SqlQuery.NaprawyAll(Start, Stop));
        }
    }
}

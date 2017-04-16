using SamWypo.Raporty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamWypo.Klasy
{
    public class RaportSamochod
    {
        public string Nazwa { get; set; }
        public decimal Kwota { get; set; }
        public string TablRej { get; set; }

        public RaportSamochod()
        {

        }
        public void PokazDane(DataGridView datagrid, DateTime Start, DateTime Stop)
        {
            DgvConfig dane = new DgvConfig(datagrid);
            dane.Samochod();
            dane.dgv.DataSource = Mapowanie.SamochodGetData(SqlQuery.SamochodAll(Start, Stop));
        }

    }
}

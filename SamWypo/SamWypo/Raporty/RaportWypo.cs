using SamWypo.Klasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamWypo.Raporty
{
    /// <summary>
    /// Trzeba wymyslić pola które mają się pojawiać
    /// </summary>
    public class RaportWypo
    {
        public string Nazwa { get; set; }
        public decimal Zaplata { get; set; }

        public RaportWypo()
        {

        }
        public void PokazDane(DataGridView datagrid, DateTime Start, DateTime Stop)
        {
            DgvConfig dane = new DgvConfig(datagrid);
            dane.Wypo();
            dane.dgv.DataSource = Mapowanie.WypoGetData(SqlQuery.WypoAll(Start, Stop));
        }
    }
}

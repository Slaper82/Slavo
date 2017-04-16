using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SamWypo.WypoDataSetTableAdapters;

namespace SamWypo
{
    class Helper
    {
        public DateTime Start { get; set; }
        public DateTime Stop { get; set; }

        public DateTimePicker MStart { get; set; }
        public DateTimePicker MStop { get; set; }

        public Helper()
        {

        }
        public Helper(DateTime start,DateTime stop,DateTimePicker mstart, DateTimePicker mstop)
        {
            this.Start = start;
            this.Stop = stop;
            this.MStart = mstart;
            this.MStop = mstop;
        }
        public void UstawDate()
        {
           MStart.Value = new DateTime(Start.Year, Start.Month, 1);
           MStop.Value = new DateTime(Stop.Year, Stop.Month, DateTime.DaysInMonth(Stop.Year, Stop.Month));
        }
        public decimal WartoscWypo(DateTime Start,DateTime Stop)
        {
            try
            {
                wypWypozyczTableAdapter wypo = new wypWypozyczTableAdapter();
                decimal wynik;
                Decimal.TryParse(wypo.WypoSum(Start.Date, Stop.Date).ToString(), out wynik);
                return wynik;
            }
            catch
            {
                return 0;
            }
        }
    }

}

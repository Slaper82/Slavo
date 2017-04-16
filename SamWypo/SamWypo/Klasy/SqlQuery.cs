using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamWypo.Klasy
{
  public static  class SqlQuery
    {
        /// <summary>
        /// Klasa przechowuje zapytanka sql potrzebne do raportów
        /// </summary>
        /// <param name="Start"></param>
        /// <param name="Stop"></param>
        /// <returns></returns>
        public static string KlienciAll(DateTime Start,DateTime Stop)
        {
            string sql = String.Format(@"select k.Nazwa as 'Nazwa',sum(Stawka) as 'Dozaplaty' from wypWypoDni as wd
                        join wypKlient k on wd.IdKlient=k.IdKlient
                        where DataWyp>'{0}' and DataWyp<'{1}'
                        group by k.Nazwa", Start.Date,Stop.Date);
            return sql;
        }
        public static string NaprawyAll(DateTime Start,DateTime Stop)
        {
            string sql = String.Format(@"select m.Nazwa,s.TablRej as'Tabl',Sum(Kwota) as 'Kwota',count(s.IdSam) as 'ilNapr' from wypNaprawa as n
                        inner join wypSamochod as s on n.IdSamo=s.IdSam
                        inner join wypModel as m on s.IdModel=m.IdModel
                        where DStop>'{0}' and DStop<'{1}'
                        group by m.Nazwa,s.TablRej", Start.Date, Stop.Date);
            return sql;
        }
        public static string SamochodAll(DateTime Start,DateTime Stop)
        {
            string sql = String.Format(@"select m.Nazwa as 'NazwaSamo',TablRej as 'TablRej',Sum(Stawka) as 'KwotaSuma' from wypWypoDni as wd
                        join wypSamochod as s on wd.IdSamo=s.IdSam
                        join wypModel as m on s.IdModel=m.IdModel
                        where wd.DataWyp>'{0}' and wd.DataWyp<'{1}'
                        group by m.Nazwa,TablRej", Start.Date, Stop.Date);
            return sql;
        }
        public static string WypoAll(DateTime Start,DateTime Stop)
        {
            string sql = String.Format(@"select 
                        'Wypożyczenia Razem' as WR,                   
                        sum(Stawka) as suma
                         from wypWypoDni as wd
                        join wypSamochod as s on wd.IdSamo=s.IdSam
                        join wypModel as m on m.IdModel=s.IdModel
                        where DataWyp>'{0}' and DataWyp<'{1}'", Start.Date, Stop.Date);
            return sql;
        }
        //
    }
}

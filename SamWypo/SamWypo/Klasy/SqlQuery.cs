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
        public static string Klienci(DateTime Start,DateTime Stop)
        {
            string sql = String.Format(@"select k.Nazwa as 'Nazwa',sum(Stawka) as 'Dozaplaty' from wypWypoDni as wd
                        join wypKlient k on wd.IdKlient=k.IdKlient
                        where DataWyp>'{0}' and DataWyp<'{1}'
                        group by k.Nazwa", Start.Date,Stop.Date);
            return sql;
        }
        //
    }
}

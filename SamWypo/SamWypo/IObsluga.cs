using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamWypo
{
    interface IObsluga
    {
        void ZapiszNowe();
        void ZapiszEdyt();
        void Usun();
        bool Sprawdz();
    }
}

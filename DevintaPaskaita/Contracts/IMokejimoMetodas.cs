using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevintaPaskaita.Contracts
{
    internal interface IMokejimoMetodas
    {
        void Apmoketi(double suma);

        bool PatikrintiLikuti(double suma);

    }
}

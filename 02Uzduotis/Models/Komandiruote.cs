using _02Uzduotis.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Uzduotis.Models
{
    public class Komandiruote : Kelione, IKelionesUzsakymas
    {
        private const double Nuolaida = 0.2;
        private double GalutineKaina;

        public Komandiruote(double bazinesKainos)
            : base(bazinesKainos)
        {

        }

        public void UzsakytiKelione(string kryptis, int dienuSk)
        {
            Kryptis = kryptis;
            DienuSkaicius = dienuSk;
            GalutineKaina = BazinesKainos * dienuSk * (1 - Nuolaida);
        }

        public double GautiKelionesKaina()
        {
            return GalutineKaina;
        }
    }
}

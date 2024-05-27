using _02Uzduotis.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Uzduotis.Models
{
    public class Atostogos : Kelione, IKelionesUzsakymas
    {
        private const double PapildomasMokestis = 50.0;
        private double GalutineKaina;
        public Atostogos(double bazinesKainos)
            : base(bazinesKainos)
        {

        }
        public void UzsakytiKelione(string kryptis, int dienuSk)
        {
            Kryptis = kryptis;
            DienuSkaicius = dienuSk;
            GalutineKaina = BazinesKainos * dienuSk + PapildomasMokestis;
        }

        public double GautiKelionesKaina()
        {
            return GalutineKaina;
        }
    }
}

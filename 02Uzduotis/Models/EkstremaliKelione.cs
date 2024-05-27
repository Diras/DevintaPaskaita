using _02Uzduotis.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Uzduotis.Models
{
    public class EkstremaliKelione : Kelione, IKelionesUzsakymas
    {
        private const double PapildomasMokestis = 100.0;
        private double GalutineKaina;

        public EkstremaliKelione(double bazinesKainos) : base(bazinesKainos) { }

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Uzduotis.Models
{
    public class Kelione
    {
        public string Kryptis { get; set; }
        protected int DienuSkaicius { get; set; }
        protected double BazinesKainos { get; set; }
        public Kelione(double bazinesKainos)
        {
            BazinesKainos = bazinesKainos;
        }

        public double GetBazinesKainos()
        {
            return BazinesKainos;
        }

        public int GetDienuSkaicius()
        {
            return DienuSkaicius;
        }
    }
}

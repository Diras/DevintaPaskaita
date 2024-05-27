using DevintaPaskaita.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevintaPaskaita.Funkcionalas
{
    public class DebetoSaskaita: Saskaita, IMokejimoMetodas
    {
        public DebetoSaskaita(string savininkoPavadinimas, double balansas)
            : base(savininkoPavadinimas, balansas)
        {

        }
        public void Apmoketi(double suma)
        {
            if (PatikrintiLikuti(suma))
            {
                Balansas -= suma;
                Console.WriteLine($"Mokėjimas {suma} buvo sėkmingas. Naujas balansas: {GetBalansas()}");
            }
            else
            {
                Console.WriteLine($"Mokėjimas {suma} buvo nesėkmingas. Nepakanka lėšų.");
            }
        }

        public bool PatikrintiLikuti(double suma)
        {
            if (Balansas >= suma)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using Gyvunai.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyvunai.Models
{
    internal class Suo : Gyvunas, IGyvunoVeikla, IGyvunoPrieziura
    {
        public Suo(string vardas, int amzius) 
        :base(vardas, amzius)
        {
        
        }
        public void Gydyti()
        {
            Console.WriteLine($"Suo {Vardas} yra maitinamas sunu maistu.");
        }

        public void Maitinti()
        {
            Console.WriteLine($"Suo {Vardas} yra gydomas veterinarijos klinikoje.");
        }

        public void Pasivaikscioti()
        {
            Console.WriteLine($"Suo {Vardas} yra vedamas pasivaikscioti.");
        }

        public void Valyti()
        {
            Console.WriteLine($"Suo {Vardas} yra maudomas.");
        }

        public void Informacija()
        {
            base.Informacija();
            Console.WriteLine("Gyvuno tipas: Suo");
        }
    }
}

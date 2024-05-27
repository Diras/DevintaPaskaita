using Gyvunai.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyvunai.Models
{
    internal class Paukstis : Gyvunas, IGyvunoVeikla, IGyvunoPrieziura
    {
        public Paukstis(string vardas, int amzius) 
            : base(vardas, amzius) 
        { 
        
        }

        public void Maitinti()
        {
            Console.WriteLine($"Paukstis {Vardas} yra maitinamas su pauksciu maistu.");
        }

        public void Gydyti()
        {
            Console.WriteLine($"Paukstis {Vardas} yra gydomas veterinarijos klinikoje.");
        }

        public void Valyti()
        {
            Console.WriteLine($"Paukstis {Vardas} yra valomas.");
        }

        public void Pasivaikscioti()
        {
            Console.WriteLine($"Paukstis {Vardas} skraido.");
        }

        public void Informacija()
        {
            base.Informacija();
            Console.WriteLine("Gyvuno tipas: Paukstis");
        }
    }
}

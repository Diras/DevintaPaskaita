using Gyvunai.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyvunai.Models
{
    internal class Kate : Gyvunas, IGyvunoVeikla, IGyvunoPrieziura
    {
        public Kate(string vardas, int amzius)
            : base(vardas, amzius)
        { 
        
        }

        public void Maitinti()
        {
            Console.WriteLine($"Kate {Vardas} yra maitinama kaciu maistu.");
        }

        public void Gydyti()
        {
            Console.WriteLine($"Kate {Vardas} yra gydoma veterinarijos klinikoje.");
        }

        public void Valyti()
        {
            Console.WriteLine($"Kate {Vardas} yra maudoma.");
        }

        public void Pasivaikscioti()
        {
            Console.WriteLine($"Kate {Vardas} vaiksto pagal savo nora.");
        }

        public void Informacija()
        {
            base.Informacija();
            Console.WriteLine("Gyvuno tipas: Kate");
        }
    }
}

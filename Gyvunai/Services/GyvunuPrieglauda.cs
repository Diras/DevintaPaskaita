using Gyvunai.Contracts;
using Gyvunai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyvunai.Services
{
    internal class GyvunuPrieglauda
    {
        private List<Gyvunas> gyvunai = new List<Gyvunas>();

        public void PridetiGyvuna(Gyvunas gyvunas)
        {
            gyvunai.Add(gyvunas);
            Console.WriteLine($"{gyvunas.Vardas} pridetas i prieglaudos sarasa.");
        }

        public void VykdytiVeiklasSuGyvunais()
        {
            foreach (Gyvunas gyvunas in gyvunai)
            {
                if (gyvunas is IGyvunoVeikla gyvunoVeikla)
                {
                    gyvunoVeikla.Maitinti();
                    gyvunoVeikla.Gydyti();
                }

                if (gyvunas is IGyvunoPrieziura gyvunoPrieziura)
                {
                    gyvunoPrieziura.Valyti();
                    gyvunoPrieziura.Pasivaikscioti();
                }

                Console.WriteLine();
            }
        }

        public void RodytiVisusGyvunus()
        {
            Console.WriteLine("Visu prieglaudos gyvunu informacija:");
            foreach (Gyvunas gyvunas in gyvunai)
            {
                if (gyvunas is Suo suo)
                {
                    suo.Informacija();
                }
                else if (gyvunas is Kate kate)
                {
                    kate.Informacija();
                }
                else if(gyvunas is Paukstis paukstis)
                {
                    paukstis.Informacija();
                }

                Console.WriteLine();
            }
        }
    }
}

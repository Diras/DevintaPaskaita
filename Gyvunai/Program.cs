using Gyvunai.Models;
using Gyvunai.Services;
using System;

namespace DevintaPaskaita
{
    public class Uzduotis03
    {
        public static void Main(string[] args)
        {
            GyvunuPrieglauda prieglauda = new GyvunuPrieglauda();

            prieglauda.PridetiGyvuna(new Suo("Rex", 3));
            prieglauda.PridetiGyvuna(new Kate("Marge", 2));
            prieglauda.PridetiGyvuna(new Paukstis("Plunksnuotis", 1));

            Console.WriteLine("\nVisi gyvūnai prieglaudoje:");
            prieglauda.RodytiVisusGyvunus();

            Console.WriteLine("\nVykdomos veiklos su gyvūnais:");
            prieglauda.VykdytiVeiklasSuGyvunais();
        }
    }
}


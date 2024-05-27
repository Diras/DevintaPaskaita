using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyvunai.Models
{
    internal class Gyvunas
    {
        public string Vardas {  get; set; }
        public int Amzius { get; set; }

        public Gyvunas( string vardas, int amzius) 
        {
            Vardas = vardas;
            Amzius = amzius;
        }

        public void Informacija()
        {
            Console.WriteLine($"Gyvuno vardas: {Vardas}, amzius: {Amzius}.");
        }
    }
}

using DevintaPaskaita.Contracts;
using DevintaPaskaita.Funkcionalas;
using System;

namespace DevintaPaskaita
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Saskaita> saskaitos = new List<Saskaita>();
            Random random = new Random();

            saskaitos.Add(new DebetoSaskaita("Ernestas", random.Next(100, 1000)));
            saskaitos.Add(new KreditoSaskaita("Vardenis", random.Next(100, 1000)));
            saskaitos.Add(new DebetoSaskaita("Pavardenis", random.Next(100, 1000)));
            saskaitos.Add(new KreditoSaskaita("Jonas", random.Next(100, 1000)));
            saskaitos.Add(new DebetoSaskaita("Jonaitis", random.Next(100, 1000)));
            saskaitos.Add(new KreditoSaskaita("Panaitis", random.Next(100, 1000)));


            List<double> mokejimuSarosas = new List<double>();
            for (int i = 0; i < 3; i++)
            {
                mokejimuSarosas.Add(random.Next(10, 500));
            }
            mokejimuSarosas.Add(2000);

            foreach (Saskaita saskaita in saskaitos)
            {
                if (saskaita is IMokejimoMetodas moketojas)
                {
                    foreach (double suma in mokejimuSarosas)
                    {
                        Console.WriteLine($"Tikrinama sąskaita {saskaita.SavininkoVardas} su balansu {saskaita.GetBalansas()}");
                        moketojas.Apmoketi(suma);  
                    }
                }
            }
        }
    }
}

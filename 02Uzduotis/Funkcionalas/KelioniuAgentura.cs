using _02Uzduotis.Contracts;
using _02Uzduotis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Uzduotis.Funkcionalas
{
    public class KelioniuAgentura
    {
        private List<Kelione> keliones;

        public KelioniuAgentura()
        {
            keliones = new List<Kelione>();
        }

        public void PridetiKelione(Kelione kelione)
        {
            keliones.Add(kelione);
        }

        public void UzsakytiKelione(string kelionesTipas, string kryptis, int dienuSk)
        {
            Kelione kelione = null;

            switch (kelionesTipas)
            {
                case "Atostogos":
                    kelione = new Atostogos(50.0); 
                    break;
                case "Komandiruote":
                    kelione = new Komandiruote(100.0); 
                    break;
                case "EkstremaliKelione":
                    kelione = new EkstremaliKelione(150.0); 
                    break;
                default:
                    Console.WriteLine("Neteisingas kelionės tipas.");
                    return;
            }

            if(kelione is IKelionesUzsakymas uzsakymas)
            {
                uzsakymas.UzsakytiKelione(kryptis, dienuSk);
            }

            PridetiKelione(kelione);
            if (kelione is Atostogos atostogos)
            {
                Console.WriteLine($"Atostogu kelionė užsakyta: {kryptis}, {dienuSk} dienų. Kaina: {atostogos.GautiKelionesKaina()}");
            }
            else if (kelione is Komandiruote komandiruote)
            {
                Console.WriteLine($"Komadiruotes kelionė užsakyta: {kryptis}, {dienuSk} dienų. Kaina: {komandiruote.GautiKelionesKaina()}");
            }
            else if(kelione is EkstremaliKelione ekstremaliKelione)
            {
                Console.WriteLine($"Ekstremali kelionė užsakyta: {kryptis}, {dienuSk} dienų. Kaina: {ekstremaliKelione.GautiKelionesKaina()}");
            }


        }

        public void RodytiVisasKeliones()
        {
            foreach (var kelione in keliones)
            {
                if (kelione is Atostogos atostogos)
                {
                    Console.WriteLine($"Atostogos. Kryptis: {atostogos.Kryptis}, Dienų skaičius: {atostogos.GetDienuSkaicius()}, Kaina: {atostogos.GautiKelionesKaina()}");
                }
                else if (kelione is Komandiruote komandiruote)
                {
                    Console.WriteLine($"Komandiruote. Kryptis: {komandiruote.Kryptis}, Dienų skaičius: {komandiruote.GetDienuSkaicius()}, Kaina: {komandiruote.GautiKelionesKaina()}");
                }
                else if (kelione is EkstremaliKelione ekstremaliKelione)
                {
                    Console.WriteLine($"EkstremaliKryptis: {ekstremaliKelione.Kryptis}, Dienų skaičius: {ekstremaliKelione.GetDienuSkaicius()}, Kaina: {ekstremaliKelione.GautiKelionesKaina()}");
                }
            }

           

            
        }
    }
}

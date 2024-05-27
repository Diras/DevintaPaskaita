using System;
using _02Uzduotis.Funkcionalas;

namespace DevintaPaskaita
{
    public class Uzduotis02 
    {
        public static void Main(string[] args)
        {
            KelioniuAgentura agentura = new KelioniuAgentura();
            Random random = new Random();

            List<string> kryptys = new List<string> { "Italija", "Ispanija", "Graikija", "Prancūzija", "Portugalija" };
            List<string> kelioniuTipai = new List<string> { "Atostogos", "Komandiruote", "EkstremaliKelione" };

            for (int i = 0; i < 5; i++)
            {
                string kryptis = kryptys[random.Next(kryptys.Count)];
                string kelionesTipas = kelioniuTipai[random.Next(kelioniuTipai.Count)];
                int dienuSk = random.Next(1, 15);

                agentura.UzsakytiKelione(kelionesTipas, kryptis, dienuSk);
            }

            Console.WriteLine("\nVisos užsakytos kelionės:");
            agentura.RodytiVisasKeliones();
        }
    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DevintaPaskaita.Funkcionalas
{
    public class Saskaita
    {
        public string SavininkoVardas { get; set; }

        protected double Balansas { get; set; }


        public Saskaita( string savininkoVardas, double balansas) 
        {
            SavininkoVardas = savininkoVardas;
            Balansas = balansas;
        }

        public double GetBalansas() 
        {
            return Balansas; 
        }
    }
}

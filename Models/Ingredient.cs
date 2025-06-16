using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributeurBoissonsChaudes.Models
{
    public class Ingredient
    {
        public string Nom { get; set; }
        public double PrixParDose { get; set; }

        public Ingredient(string nom, double prixParDose)
        {
            Nom = nom;
            PrixParDose = prixParDose;
        }
    }
}

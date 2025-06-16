using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributeurBoissonsChaudes.Models
{
    public class Distributeur
    {
        public List<Recette> Recettes { get; set; }

        public Distributeur()
        {
            Recettes = new List<Recette>();
        }

        public void AjouterRecette(Recette recette)
        {
            Recettes.Add(recette);
        }

        public void AfficherListeBoissons()
        {
            for (int i = 0; i < Recettes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Recettes[i].Nom}");
            }
        }

        public Recette ObtenirBoissonParChoix(int choix)
        {
            if (choix >= 1 && choix <= Recettes.Count)
            {
                return Recettes[choix - 1];
            }
            return null;
        }
    }
}

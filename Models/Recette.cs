using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributeurBoissonsChaudes.Models
{
    public class Recette
    {
        public string Nom { get; set; }
        public Dictionary<Ingredient, int> Ingredients { get; set; }

        public Recette(string nom)
        {
            Nom = nom;
            Ingredients = new Dictionary<Ingredient, int>();
        }

        public void Ajouter(Ingredient ingredient, int quantite)
        {
            Ingredients[ingredient] = quantite;
        }

        public double CalculerCoutSansMarge()
        {
            double total = 0;

            foreach (var pair in Ingredients)
            {
                var ingredient = pair.Key;
                var quantite = pair.Value;
                total += ingredient.PrixParDose * quantite;
            }

            return total;
        }

        public double CalculerPrixVente()
        {
            double cout = CalculerCoutSansMarge();
            double marge = cout * 0.3;
            double prixFinal = cout + marge;

            return Math.Round(prixFinal, 2);
        }

        public string AfficherDetails()
        {
            var lignes = Ingredients.Select(i => $"{i.Value} doses de {i.Key.Nom}");
            return string.Join(", ", lignes);
        }
    }
}

using DistributeurBoissonsChaudes.Models;

// création des ingrédients pr test
var cafe = new Ingredient("Café", 1.0);
var sucre = new Ingredient("Sucre", 0.1);
var creme = new Ingredient("Crème", 0.5);
var the = new Ingredient("Thé", 2.0);
var eau = new Ingredient("Eau", 0.2);
var chocolat = new Ingredient("Chocolat", 1.0);
var lait = new Ingredient("Lait", 0.4);

// création des recette pr test
var expresso = new Recette("Expresso");
expresso.Ajouter(cafe, 1);
expresso.Ajouter(eau, 1);

var allonge = new Recette("Allongé");
allonge.Ajouter(cafe, 1);
allonge.Ajouter(eau, 2);

var capuccino = new Recette("Capuccino");
capuccino.Ajouter(cafe, 1);
capuccino.Ajouter(chocolat, 1);
capuccino.Ajouter(eau, 1);
capuccino.Ajouter(creme, 1);

var chocolatChaud = new Recette("Chocolat");
chocolatChaud.Ajouter(chocolat, 3);
chocolatChaud.Ajouter(lait, 2);
chocolatChaud.Ajouter(eau, 1);
chocolatChaud.Ajouter(sucre, 1);

var theBoisson = new Recette("Thé");
theBoisson.Ajouter(the, 1);
theBoisson.Ajouter(eau, 2);

// ajout des recettes dans le distributeur pr test
var distributeur = new Distributeur();
distributeur.AjouterRecette(expresso);
distributeur.AjouterRecette(allonge);
distributeur.AjouterRecette(capuccino);
distributeur.AjouterRecette(chocolatChaud);
distributeur.AjouterRecette(theBoisson);

// boucle d'affichage du menu
while (true)
{
    Console.Clear();
    Console.WriteLine("Bienvenue dans le distributeur automatique !");
    Console.WriteLine("Choisissez une boisson :\n");

    distributeur.AfficherListeBoissons(); //  Afficher les boissons disponibles

    Console.Write("\nVotre choix: ");
    var saisie = Console.ReadLine();

    if (int.TryParse(saisie, out int choix))
    {
        // récupération de la recette sélectionné
        var boisson = distributeur.ObtenirBoissonParChoix(choix);

        if (boisson != null)
        {
            // nom et du prix final de la boisson affichéés
            Console.WriteLine($"\nVous avez choisi : {boisson.Nom}");
            Console.WriteLine($"Prix de vente : {boisson.CalculerPrixVente():0.00} euro");
        }
        else
        {
            Console.WriteLine("Choix invalide"); // numero hors de la liste
        }
    }
    else
    {
        Console.WriteLine("Saisie non reconnue"); // pas un numero
    }

    Console.WriteLine("\nAppuyez sur une touche pour recommencer ");
    Console.ReadKey();
}

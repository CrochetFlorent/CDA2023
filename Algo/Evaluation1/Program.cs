using System.Globalization;

namespace Evaluation1
{
    internal class Program
    {

        public static void CalculTableau()
        {
            //Soit un tableau de nombre entier
            int[] numbers = { 2, 4, 1, 8, 6, 14, 23, 25, 7, 42 };
            //Une variable visant à récuprer la somme des ces valeurs
            double somme = 0;
            // Et une variable visant à récuprer la valeur la plus grande
            int nbLePlusGrand = numbers.Max();

            //On parcours le tableau 
            for (int i = 0; i < numbers.Length; i++)
            {
                //On calcul la somme des nombres dans le tableau en incrémentant la somme
                somme += numbers[i];
            }

            Console.WriteLine("Bienvenue dans le programme de calcul du tableau d'entier.");
            //On affiche les résultats
            //En premier la somme divisée par le nombre de nombres présents dans le tableau pour la moyenne
            Console.WriteLine("Moyenne des valeurs du tableau : "+somme/numbers.Length);
            //En second La valeur la plus grande puis son carré
            Console.WriteLine("Valeur la plus grande dans le tableau: "+nbLePlusGrand+" élevée au carré: " + Math.Pow(nbLePlusGrand, 2));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            CalculTableau();
        }
    }
}
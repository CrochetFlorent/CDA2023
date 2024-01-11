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
            int temp = numbers[0];

            //On parcours le tableau 
            for (int i = 0; i < numbers.Length; i++)
            {
                //On calcul la somme des nombres dans le tableau en incrémentant la somme
                somme += numbers[i];

                //Si la première valeur enregistrée dans la variable temp est plus petite que celle à l'indice 
                //(sachant que l'on compare la première avec elle même une fois)
                if (temp < numbers[i])
                {
                    //On récupère la plus grande
                    temp = numbers[i];
                }
                //Et ainsi de suite
            }

            Console.WriteLine("Bienvenue dans le programme de calcul du tableau d'entier.");
            //On affiche les résultats
            //En premier la somme divisée par le nombre de nombres présents dans le tableau pour la moyenne
            Console.WriteLine("Moyenne des valeurs du tableau : "+somme/numbers.Length);
            //En second LA valeur la plus grande puis son carré
            Console.WriteLine("Valeur la plus grande dans le tableau: "+temp+" élevée au carré: " + Math.Pow(temp, 2));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            CalculTableau();
        }
    }
}
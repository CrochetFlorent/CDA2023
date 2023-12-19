using System.Runtime.CompilerServices;

namespace Demarrage
{
    internal class Program
    {
        //Partie 1
        
        public static void moyenne()
        {
            int nb1, nb2;

            Console.WriteLine("Entrer nombre 1");
            string saisie = Console.ReadLine();
            nb1 = int.Parse(saisie);
            Console.WriteLine("Entrez nombre 2");
            saisie =Console.ReadLine();
            nb2 = int.Parse(saisie);

            int moyenne = (nb1 + nb2) / 2;
            Console.WriteLine("La moyenne de " + nb1 + " et " + nb2 + " est " + moyenne);

        }

        public static void aire()
        {
            double aire, rayon, volume;

            Console.WriteLine("Entrer l'aire de la sphère");
            string saisie = Console.ReadLine();
            rayon= int.Parse(saisie);

            aire = Math.Round(4 * Math.PI * Math.Pow(rayon, 2)*100)/100;
            volume = Math.Round((4/3)*Math.PI*Math.Pow(rayon, 3)*100)/100;

            Console.WriteLine("L'aire de la sphère est de " + aire + " et le volume de " + volume);
        }

        public static void surface()
        {
            double rayon, angle, surface;

            Console.WriteLine("Entrer le rayon d'un secteur circulaire");
            string saisie = Console.ReadLine();
            rayon = int.Parse(saisie);
            Console.WriteLine("Entrez l'anlg eu secteur");
            saisie = Console.ReadLine();
            angle = int.Parse(saisie);

            surface = Math.Round(((Math.PI*Math.Pow(rayon,2)*angle)/360)*100)/100;
            Console.WriteLine("L'aire du secteur est "+ surface);
        }

        public static void interets(){

            double somme, interet, nbAnnees;

            Console.WriteLine("Entrer la somme sur votre compte");
            string saisie = Console.ReadLine();
            somme = int.Parse(saisie);
            Console.WriteLine("Entrez l'interet offert par la banque");
            saisie = Console.ReadLine();
            interet = int.Parse(saisie);
            Console.WriteLine("Entrez le nombre d'années de placement");
            saisie = Console.ReadLine();
            nbAnnees = int.Parse(saisie);

            double interetSimple = somme*(1 + nbAnnees * (interet/100));
            double interetCompose = Math.Round(somme*Math.Pow((1 + (interet/100)),nbAnnees)*100)/100;

            Console.WriteLine("Interet Simple = " + interetSimple + " et interet composé = " + interetCompose);

        }

        public static void inversion()
        {
            int a, b, c;

            Console.WriteLine("Entrer nombre 1");
            string saisie = Console.ReadLine();
            a = int.Parse(saisie);
            Console.WriteLine("Entrez nombre 2");
            saisie = Console.ReadLine();
            b = int.Parse(saisie);

            Console.WriteLine("a = "+a+" et b = "+b);

            c = a;
            a = b;
            b = c;

            Console.WriteLine("Apres inversion : a = " + a + " et b = " + b);
        }

        //Partie 2

        public static void comparaison()
        {
            int a;

            Console.WriteLine("Entrez votre age");
            string saisie = Console.ReadLine();
            a = int.Parse(saisie);

            if (a <= 0)
            {
                Console.WriteLine("Vous n'êtes pas né.");
            }
            else if(a >= 18)
            {
                Console.WriteLine("Vous êtes majeur.");
            }
            else
            {
                Console.WriteLine("Vous êtes mineur.");
            }
        }

        public static void tri()
        {
            int a, b;

            Console.WriteLine("Entrer nombre 1");
            string saisie = Console.ReadLine();
            a = int.Parse(saisie);
            Console.WriteLine("Entrez nombre 2");
            saisie = Console.ReadLine();
            b = int.Parse(saisie);

            if (a > b)
            {
                Console.WriteLine(a + " > " + b);

            }
            else if (a < b)
            {
                Console.WriteLine(b + " > " + a);
            }
            else
            {
                Console.WriteLine("Les deux nombre sont égaux");
            }
        }

        public static void triTrois()
        {
            int a, b, c;

            Console.WriteLine("Entrer nombre1");
            string saisie = Console.ReadLine();
            a = int.Parse(saisie);
            Console.WriteLine("Entrez nombre2");
            saisie = Console.ReadLine();
            b = int.Parse(saisie);
            Console.WriteLine("Entrez nombre3");
            saisie = Console.ReadLine();
            c = int.Parse(saisie);

            if (a > b && b > c)
            {
                Console.WriteLine(c + ">" + b + ">" + a);
            }
            else if (a > c && c > b)
            {
                Console.WriteLine(b + ">" + c + ">" + a);
            }
            else if (b > a && a > c)
            {
                Console.WriteLine(c + ">" + a + ">" + b);
            }
            else if (c> a && a > b)
            {
                Console.WriteLine(b + ">" + a + ">" + c);
            }
            else if (a > b && b > c)
            {
                Console.WriteLine(c + ">" + b + ">" + a);
            }
            else 
            {
                Console.WriteLine(a + ">" + b + ">" + c);
            }
        }
        public static void bissext()
        {
            int annee;
               
            Console.WriteLine("Entrer une annee.");
            string saisie = Console.ReadLine();
            annee = int.Parse(saisie);

            
            if ((annee % 4 != 0) || (annee%4 == 0 && annee%100 == 0 && annee%400 != 0))
            {
                Console.WriteLine("Pas bissextile");
            }
            else
            {
                Console.Write("Bissextile");
            }
        }

        public static void diviseurs()
        {
            int nb;

            Console.WriteLine("Entrer un nombre.");
            string saisie = Console.ReadLine();
            nb = int.Parse(saisie);

            for (int i = 2; i < nb-1; i++)
            {
                if(nb%i==0)
                {
                    Console.WriteLine(i+" est un diviseur de "+nb);     
                }
            }
        }

        public static void premier()
        {
            int nb, test = 0;

            Console.WriteLine("Entrer un nombre.");
            string saisie = Console.ReadLine();
            nb = int.Parse(saisie);

            for (int i = 2; i<nb; i++)
            {
                if(nb%i==0)
                {
                    test += 1;
                }
            }
            if (test == 0)
            {
                Console.WriteLine(nb+" est premier.");
            }
            else
            {
                Console.WriteLine(nb + " n'est pas premier.");
            }
        }

        public static void conversion()
        {
            double valeur;
            double miles;

            Console.WriteLine("Entrer un nombre de kilometres saisir q pour quitter.");
            string saisie = Console.ReadLine();
            if (saisie.Equals("q"))
            {
                Environment.Exit(0);
            }
            else {
                valeur = double.Parse(saisie);
                while (valeur < 0.01 || valeur > 1000000)
                {
                    Console.WriteLine("Entrer un nombre.");
                    saisie = Console.ReadLine();
                    
                    if (saisie.Equals("q"))
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        valeur = double.Parse(saisie);
                    }
                }
                miles = valeur * 0.621;
                Console.WriteLine("En miles :" + miles);
            }
        }

        //Partie 3

        public static void RechercheDeLettre()
        {
            int nbLettre = 0;
            string fin = "";
            string str = "";

            while(!fin.Equals("q"))
            {
                Console.WriteLine("Tapez une phrase.");
                str = Console.ReadLine();

                
                Console.WriteLine("Entrez une lettre.");
                string lettre = Console.ReadLine();

                nbLettre = str.Split(lettre).Length - 1;

                if (nbLettre==0)
                {
                    Console.WriteLine("La lettre n'est pas présente dans la chaine de caractères.");
                }
                else
                {
                    Console.WriteLine("La lettre est présente " + nbLettre + " fois dans la chaine de caractères.");
                }

                Console.WriteLine("Continuer?");
                fin = Console.ReadLine();
            }
        }

        public static void barnabe()
        {
            int nbMagasins = 0;
            Random r = new Random();
            double somme = r.Next(20, 150);
            Console.WriteLine("Barnabe dispose de " + somme + " euros.");
            while (somme != 0)
            {
                if (somme >= 2)
                {
                    somme = somme / 2 - 1;
                    nbMagasins += 1;
                }
                else
                {
                    somme = 0;
                    nbMagasins += 1;
                }
            }
            Console.WriteLine("Barnabe est passé dans " + nbMagasins + " magasins.");
        }

        public static void fourchette()
        {
            Random r = new Random();
            int nbAlea = r.Next(0, 100);
            int nb, min = 0, max = 100;
            int essais = 0;

            do
            {
                Console.WriteLine("Entrez un nombre entre " + min + " et " + max);
                nb = int.Parse(Console.ReadLine());
                if(nbAlea<nb)
                {
                    max = nb;
                }
                else if(nbAlea>nb)
                {
                    min = nb;
                }
                essais += 1;
            } while (nb != nbAlea);
            Console.WriteLine("Vous avez reussi en " + essais + " essai(s).");
        }

        public static void RechercheTableau()
        {
            int[] tab = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32 };
            Console.WriteLine(" Entrez un nombre.");
            int nb = int.Parse(Console.ReadLine());
            bool test = false;

            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == nb)
                {
                    Console.WriteLine("Le nombre appartient au tableau.");
                    i = tab.Length;
                    test = true;
                }
                else
                {

                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            RechercheTableau();
        }
    }
}
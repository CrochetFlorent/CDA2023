using System;
using System.Collections;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace FonctionsATester
{
    public class Program
    {
        public static double Moyenne(double nb1,double nb2)
        {
            //Retour de la moyenne
            return (nb1 + nb2) / 2;
        }
        
        public static bool Premier(int nb)
        {

            //Un nombre premier est un nombre entier qui admet exactement deux diviseurs : 1 et lui-meme
            //Tout nombre est divisible par 1 et lui meme , le tout est de savoir s'il y a plus de diviseurs autres
            //que ces deux la
            int nombreDeDiviseurs = 0;
            bool estPremier = false;

            //Je ne test pas 1, je commence à deux, jusqu'au nombre precédent au nombre testé
            for (int i = 2; i < nb; i++)
            {
                //Si il est divisible par l'indice j'incrémente une variable 
                if (nb % i == 0)
                {
                    nombreDeDiviseurs += 1;
                }
            }
            //S'il n'a pas été divisé âr un autre nombre que 1 ou lui meme, il est premier
            if (nombreDeDiviseurs == 0)
            {
                estPremier= true;
            }
            else
            {
                estPremier = false;
            }
            return estPremier;
        }
        public static Boolean Bissextile(int annee)
        {
            bool estBissextile = false;
            //Si l'année est divisible par 4, par 100, et pas par 400 elle n'est pas bissextile
            if ((annee % 4 != 0) || (annee % 4 == 0 && annee % 100 == 0 && annee % 400 != 0))
            {
                estBissextile= false;
            }
            //Si elle est divisible par 4 et/ou par 400 elle est bissextile
            else
            {
                estBissextile = true;
            }
            return estBissextile;
        }

        public static int Barnabe(double somme)
        {
            int nbMagasins = 0;

            //Si la somme est plus petite ou égale à un, barnabe ne passe dans aucuns magasins
            if (somme <= 1)
            {
                nbMagasins = -1;
            }
            //Sinon
            else
            {
                //Tant que la somme est différente de zero
                while (somme != 0)
                {
                    //Si la somme est plus grande ou égale a 2
                    if (somme >= 2)
                    {
                        //Je la divise par 2 et lui enlève un euros et j'incrémente le nombre de magasins
                        somme = somme / 2 - 1;
                        nbMagasins += 1;
                    }
                    //Sinon si elle est plus petite que 2, comme barnabé depense plus d'un euro dans chaque magasin, la division
                    //par 2 ne peut plus etre faite, elle il dépense tout son solde dans le dernier magasin
                    else if (somme < 2)
                    {
                        somme = 0;
                        nbMagasins += 1;
                    }
                }
            }
            return nbMagasins;
        }

        public static Boolean RechercheTableau(int nb, int[] tab)
        {
            bool estDansLeTableau = false;
            int i;

            //Je parcours mon tableau avec un for
            for (i = 0; i < tab.Length; i++)
            {
                //Si a l'indice le nombre est dégal a celui du tableau
                if (tab[i] == nb)
                {
                    //Je le signal par le passage du booleen test à vrai et je sors de la boucle pour en passant
                    //à l'indice une valeur supérieure à son maximum
                    i = tab.Length;
                    estDansLeTableau = true;
                }
                //Sinon je repasse dans la boucle pour voir si le prochain nombre du tableau est égale au nombre choisi
            }
            
            return estDansLeTableau;
        }

        public static Boolean Palindrome(string palindrome)
        {
            int i = 0, nombreDeLettreIdentiques = 0;
            //Si le mot devant etre testé est plus grand qu'une seul lettre
            if (palindrome.Length>1)
            {
                //Tant que je ne suis pas  a la moitié du mot(incrémentation de l'indice en fin de boucle)
                while (i < (int)((palindrome.Length / 2)))
                {
                    //Si la lettre correspondante à l'indice est égale à son opposée de l'autre côté du milieu du mot
                    if (palindrome[i].Equals(palindrome[palindrome.Length - i - 1]))
                    {
                        //J'incrémente une variable de test
                        nombreDeLettreIdentiques++;
                    }
                    i++;
                } 
                //Si la variable de test est égale à la moitié du mot cela veut dire que toutes lettres rencontrées dans cette ordre
                //sont identiques aux lettres de l'autre côté du milieu
                if (nombreDeLettreIdentiques == (int)palindrome.Length / 2)
                {
                    return true;
                }
                //sinon ce n'est pas un palindrom
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        //Version de detection de palindrome avec une boucle for: on va jusqu'au milieu du mot pour voir si de l'autre côté
        // les lettre sont identiques
        public static bool Palindrome2(string palindrome)
        {
            int nombreDeLettreIdentiques = 0;
            bool estUnPalindrome = false;
 
            for(int i=0;i<palindrome.Length/2;i++)
            {

                if (palindrome[i].Equals(palindrome[palindrome.Length- nombreDeLettreIdentiques - 1]))
                {
                    nombreDeLettreIdentiques++;
                }
                else
                {
                    i = palindrome.Length / 2;
                }
            }
            if(nombreDeLettreIdentiques == palindrome.Length/2 && palindrome.Length>1)
            {
                estUnPalindrome = true;
            }
            else
            {
                estUnPalindrome = false;
            }
            
            return estUnPalindrome;
        }
        
        public static string Chifumi(string s1, string s2)
        {
            //Nous avons en paramètres d'entrée deux caractères chacun représentant un lancé
            //p pour pierre, f pour feuille, c pour ciseaux
            //Le resultat du lancé est une chaine de caractère comprenant les deux caractères
            //Le premier est le lancé du joueur1
            //Le second celui du joueur 2
            string manche = "" + s1 + s2;
            string winner = "";

            //Nous testons tous les cas
            switch (manche)
                {
                    case "pp":
                        winner = "egalite";
                    break;
                    case "pf":
                        winner = "joueur2";
                    break;
                    case "pc":
                         winner = "joueur1";
                    break;
                    case "ff":
                        winner = "egalite";
                    break;
                    case "fp":
                        winner = "joueur1";
                    break;
                    case "fc":
                        winner = "joueur2";
                    break;
                    case "cc":
                        winner = "egalite";
                    break;
                    case "cp":
                         winner = "joueur2";
                    break;
                    case "cf":
                        winner = "joueur1";
                    break;
                }
            //nous retournons le gagnant
            return winner;
        }

        public static void Yaourts(string[] tabCouleurs,out string couleur1, out string couleur2)
        {
            Dictionary<string, int> couleurs = new Dictionary<string, int>();
            couleur1 = ""; 
            couleur2 = "";
            //Pour chaque couleur dans le tableaux contenant l'énumération de couleurs
            foreach (string color in tabCouleurs)
            {
                //Si la couleur n'est pas représentée dans le dictionnaire
                    if(!couleurs.ContainsKey(color))
                    {
                    //Nous l'ajoutons
                        couleurs.Add(color,1);
                    }
                //Sinon
                    else
                    {
                    //Nous incrémentons son nombre de représentations
                        couleurs[color] += 1;
                    }
             }

            //Nous trions les couleurs dans l'ordre croissant
            //On récupère les deux couleurs les plus représentées
            var tri = couleurs.OrderByDescending(x => x.Value).Take(2).ToDictionary(x => x.Key, x => x.Value);

            couleur1 = tri.Keys.First();
            couleur2 = tri.Keys.Last();

        }

        public static void RetourTableau(int[] tab,int nombreACompter1,int nombreACompter2, out int nombreCompte1, out int nombreCompte2)
        {
           nombreCompte1 = 0;
           nombreCompte2 = 0;

            //Pour chaque élément du tableau
            for (int i = 0; i < tab.Length; i++)
            {
                //Si l'élément est égale au premier nombre à tester
                if (tab[i] == nombreACompter1)
                {
                    //On incrémente le nombre de fois ou le nombre est présent
                    nombreCompte1 += 1;
                }
                //Si l'élément est égale au deuxième nombre à tester
                else if (tab[i] == nombreACompter2)
                {
                    //On incrémente le nombre de fois ou le nombre est présent
                    nombreCompte2 += 1;
                }
            }
        }

        public static string Fibonacci(int nombre)
        {

            string debut = "01";
            
            string suite = debut;

            string nb1 = suite.Substring(suite.Length - 2, 2);
            string nb2 = suite.Substring(suite.Length - 1, 1);

            int intNb1 = int.Parse(nb1);
            int intNb2 = int.Parse(nb2);
            int intNb3 = (intNb1 + intNb2);

            suite = suite + intNb3.ToString();

            if (nombre > 0)
            {
                suite = Fibonacci(--nombre);
            }

            return suite;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci( 5));
        }
    }
}
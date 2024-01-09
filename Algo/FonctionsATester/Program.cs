using System;
using System.Collections;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Timers;

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
            //Tout nombre est divisible par 1 et lui meme , le tout est de savoir s'il y a plus de diviseurs
            int test = 0;
            bool isPremier = false;

            //Je ne test pas 1, je commence à deux, jusqu'au nombre testé
            for (int i = 2; i < nb; i++)
            {
                //Si il est divisible par l'indice j'incrémente une variable 
                if (nb % i == 0)
                {
                    test += 1;
                }
            }
            //S'il n'a pas été divisé âr un autre nombre que 1 ou lui meme, il est premier
            if (test == 0)
            {
                isPremier= true;
            }
            else
            {
                isPremier = false;
            }
            return isPremier;
        }
        public static Boolean Bissext(int annee)
        {
            bool isBissext = false;
            //Si l'année est divisible par 4, par 100, et pas par 400 elle n'est pas bissextile
            if ((annee % 4 != 0) || (annee % 4 == 0 && annee % 100 == 0 && annee % 400 != 0))
            {
                isBissext= false;
            }
            //Si elle est divisible par 4 et/ou par 400 elle est bissextile
            else
            {
                isBissext= true;
            }
            return isBissext;
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
            bool isIn = false;
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
                    isIn = true;
                }
                //Sinon je repasse dans la boucle pour voir si le prochain nombre du tableau est égale au nombre choisi
            }
            
            return isIn;
        }

        public static Boolean Palindrome(string palindrome)
        {
            int i = 0, nbOk = 0;
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
                        nbOk++;
                    }
                    i++;
                } 
                //Si la variable de test est égale à la moitié du mot cela veut dire que toutes lettres rencontrées dans cette ordre
                //sont identiques aux lettres de l'autre côté du milieu
                if (nbOk == (int)palindrome.Length / 2)
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
        // les lettre ssont identiques
        public static bool Palindrome2(string palindrome)
        {
            int nb = 0;
            bool test = false;
 
            for(int i=0;i<palindrome.Length/2;i++)
            {

                if (palindrome[i].Equals(palindrome[palindrome.Length-nb-1]))
                {
                    nb++;
                }
                else
                {
                    i = palindrome.Length / 2;
                }
            }
            if(nb==palindrome.Length/2 && palindrome.Length>1)
            {
                test = true;
            }
            else
            {
                test = false;
            }
            
            return test;
        }
        
        public static string Chifumi(string s1, string s2)
        {
            //Nous avons en paramètres d'entrée deux caractères chacun représentant un lancé
            //p pour pierre, f pour feuille, c pour ciseaux
            string winner = "";
            //Le resultat du lancé est une chaine de caractère comprenant les deux caractères
            //Le premier est le lancé du joueur1
            //Le second celui du joueur 2
            string resultat = "" + s1 + s2;

            //Nous testons tous les cas
                switch (resultat)
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

        public static void Yaourts(string[] tabCouleurs,out string couleur1, out string couleur2,out int nbCouleur1, out int nbCouleur2)
        {
            Dictionary<string, int> couleurs = new Dictionary<string, int>();

            //Pour chaque couleur dans le tableaux contenant l'énumération de couleurs
            foreach (string color in tabCouleurs)
            {
                //Si la couleur n'est pas contenu
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
            var tri = couleurs.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            //Comme nous voulons les deux couleurs les plus représentées, nous enlevonsle premier élément du dictionnaire 
            //jusqu'a n'en avoir que deux
            while (tri.Count > 2)
            {
                tri.Remove(tri.Keys.First());
            }

            //Nous mettons le dernier en premier et inversement
            couleur1 = tri.Keys.Last();
            couleur2 = tri.Keys.First();
            nbCouleur1 = tri.Values.Last();
            nbCouleur2 = tri.Values.First();
        }

        public static void RetourTableau(int[] tab,int nbACompter1,int nbACompter2, out int nbCompte1, out int nbCompte2)
        {
            nbCompte1 = 0;
            nbCompte2 = 0;

            //Pour chaque élément du tableau
            for (int i = 0; i < tab.Length; i++)
            {
                //Si l'élément est égale au premier nombre à tester
                if (tab[i] == nbACompter1)
                {
                    //On incrémente le nombre de fois ou le nombre est présent
                    nbCompte1 += 1;
                }
                //Si l'élément est égale au deuxièmenombre à tester
                else if (tab[i] == nbACompter2)
                {
                    //On incrémente le nombre de fois ou le nombre est présent
                    nbCompte2 += 1;
                }
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}
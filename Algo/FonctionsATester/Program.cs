using System.Net.NetworkInformation;
using System.Timers;

namespace FonctionsATester
{
    public class Program
    {
        public static double Moyenne(double nb1,double nb2)
        {
            return (nb1 + nb2) / 2;
        }
        
        public static bool Premier(int nb)
        {
            int test = 0;
            bool isPremier = false;

            for (int i = 2; i < nb; i++)
            {
                if (nb % i == 0)
                {
                    test += 1;
                }
            }

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
            if ((annee % 4 != 0) || (annee % 4 == 0 && annee % 100 == 0 && annee % 400 != 0))
            {
                isBissext= false;
            }
            else
            {
                isBissext= true;
            }
            return isBissext;
        }

        public static int Barnabe(double somme)
        {
            int nbMagasins = 0;

            if (somme <= 1)
            {
                nbMagasins = -1;
            }
            else
            {
                while (somme != 0)
                {
                    if (somme >= 2)
                    {
                        somme = somme / 2 - 1;
                        nbMagasins += 1;
                    }
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
            bool test = false, isIn = false;
            int i;

            for (i = 0; i < tab.Length; i++)
            {
                if (tab[i] == nb)
                {
                    test = true;
                    i = tab.Length;
                }
            }
            if (test)
            {
                isIn = true;
            }
            else
            {
               isIn = false;
            }
            return isIn;
        }

        public static Boolean Palindrome(string palindrome)
        {
            int i = 0, nbOk = 0;
            if (palindrome.Length>1)
            {
                while (i < (int)((palindrome.Length / 2)))
                {
                    if (palindrome[i].Equals(palindrome[palindrome.Length - i - 1]))
                    {
                        nbOk++;
                    }
                    i++;
                } 

                if (nbOk++ == (int)palindrome.Length / 2)
                {
                    return true;
                }
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
            string winner = "";
            string resultat = "" + s1 + s2;

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
            return winner;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
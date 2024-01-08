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
            if (!palindrome.Equals(""))
            {
                do
                {
                    if (palindrome[i].Equals(palindrome[palindrome.Length - i - 1]))
                    {
                        nbOk++;
                    }
                    i++;
                } while (i < (int)((palindrome.Length / 2)));

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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
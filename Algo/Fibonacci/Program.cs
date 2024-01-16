namespace Fibonacci
{
    public class Program
    {
        //Fibonacci avec boucle
        /*Variables 

        Position est un entier          // utilisé pour l’incrémentation 

        N est un entier                 // donnée fournie par l’utilisateur 

        Resultat est une chaine de caractère    // sera affiché à l’utilisateur à la fin du programme 

        NbPrecedent est un entier 64 bits   // Nombre précédent dans la suite  

        NbCourant est un  entier 64 bits    // Nombre courant dans la suite  

        NbSuivant est un entier 64 bits     // Nombre suivant dans la suite (celui qu’on est en train de calculer)  



        DEBUT PROGRAMME 

        Lire(N)                 // saisie par l’utilisateur 
        Position := 2 
        Resultat :=  "0\n1"  
        NbPrecedent := 0        // 1er nombre de la suite  
        NbCourant := 1          // 2ème nombre de la suite 


        SI N EST SUPÉRIEUR À 2 ALORS 

        TANT QUE Position EST INFÉRIEUR À N FAIRE 
        NbSuivant := NbPrecedent + NbCourant 
        Resultat := Resultat, "\n",  NbSuivant 
        NbPrecedent := NbCourant 
        NbCourant := NbSuivant 
        N := N + 1 
        FIN TANT QUE 

        SINON 

        N: = 2 

        FIN SI 

        Écrire "Les ", N, " premiers nombres de la suite de Fibonacci sont \n ", Resultat 

        FIN PROGRAMME*/
        public static string FibonacciBoucle(int n)
        {
            string resultat = "\n0\n1";
            long nbPrecedent = 0;   
            long nbCourant = 1;
            long nbSuivant;

            while (n > 2)
            {
                nbSuivant = nbPrecedent + nbCourant;
                resultat = resultat + "\n" + nbSuivant;
                nbPrecedent = nbCourant;
                nbCourant = nbSuivant;
                n -= 1;
            }
            return resultat;
        }

        public static long[] FibonacciTab(int n)
        {
            long[] tabFibo = new long[n];
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    tabFibo[i] = 0;
                }
                else if (i == 1)
                {
                    tabFibo[i] = 1;
                }
                else
                {
                    tabFibo[i] = tabFibo[i-1 ] + tabFibo[i - 2];
                }
            }
            return tabFibo;
        }

        //Fibonacci recursive
        public static string FibonacciRecursiveString(int n)
        {
            string resultat = "";

            if (n <= 2)
            {
                resultat += "\n0\n1";
            }
            else
            {
                string recur = FibonacciRecursiveString(n - 1);
                string[] recurTab = recur.Split("\n");
                resultat += recur + "\n" + (long.Parse(recurTab[recurTab.Length - 1]) + long.Parse(recurTab[recurTab.Length - 2])).ToString();
            }

            return resultat;
        }

        public static int FibonacciRecursiveInt(int n)
        {
            int resultat;

            if(n == 0)
            {
                resultat = -1;
            }
            else if (n == 1)
            {
                resultat = 0;
            }
            else if (n == 2)
            {
                resultat = 1;
            }
            else
            {
                resultat = FibonacciRecursiveInt(n - 1) + FibonacciRecursiveInt(n - 2);
            }
            return resultat;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int n;
            Console.WriteLine("Combien de nombres de la suite de fibonacci voulez vous afficher? fibonacci avec boucle");
            string saisie1 = Console.ReadLine();
            int.TryParse(saisie1, out n);
            Console.WriteLine(FibonacciBoucle(n));

            Console.WriteLine("Combien de nombres de la suite de fibonacci voulez vous afficher? fibonacci avec recursif IF");
            string saisie2 = Console.ReadLine();
            int.TryParse(saisie2, out n);
            Console.WriteLine(FibonacciRecursiveString(n));

            Console.WriteLine("Combien de nombres de la suite de fibonacci voulez vous afficher? fibonacci avec recursif FOR");
            string saisie3 = Console.ReadLine();
            int.TryParse(saisie3, out n);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(FibonacciRecursiveInt(i));
            }

            Console.WriteLine("Combien de nombres de la suite de fibonacci voulez vous afficher? fibonacci avec recursif Tableau");
            string saisie4 = Console.ReadLine();
            int.TryParse(saisie4, out n);

            long[] fibo = FibonacciTab(n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(fibo[i]);
            }
        }
    }
}
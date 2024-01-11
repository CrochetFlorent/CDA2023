namespace Recursive
{
    internal class Program
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

                while(n > 2)
                {
                    nbSuivant = nbPrecedent + nbCourant;
                    resultat = resultat + "\n" + nbSuivant;
                    nbPrecedent = nbCourant;
                    nbCourant = nbSuivant;
                    n -= 1;
                }
            return resultat;
        }

        //Fibonacci recursive
        public static string FibonacciRecursive(long n)
        {
            string resultat = "";
            
            if(n <= 2 )
            {
                resultat += "\n0\n1";
            }
            else 
            {
                string recur = FibonacciRecursive(n - 1);
                string[] recurTab = FibonacciRecursive(n-1).Split("\n");
                resultat += recur + "\n" + (long.Parse(recurTab[recurTab.Length - 1]) + long.Parse(recurTab[recurTab.Length - 2])).ToString();
            }
            
            return resultat;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int n;
            Console.WriteLine("Combien de nombres de la suite de fibonacci voulez vous afficher?");
            string saisie1 = Console.ReadLine();
            int.TryParse(saisie1, out n);
            Console.WriteLine(FibonacciBoucle(n));

            Console.WriteLine("Combien de nombres de la suite de fibonacci voulez vous afficher?");
            string saisie2 = Console.ReadLine();
            int.TryParse(saisie2, out n);
            Console.WriteLine(FibonacciRecursive(n));


        }
        }
}
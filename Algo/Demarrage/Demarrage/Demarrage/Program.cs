using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace Demarrage
{
    internal class Program
    {
        //Exercices #1
        //Partie 1
        public static void Moyenne()
        {
            int nb1, nb2;

            Console.WriteLine("Entrer le nombre 1.");
            string saisie = Console.ReadLine();
            nb1 = int.Parse(saisie);
            Console.WriteLine("Entrez le nombre 2");
            saisie = Console.ReadLine();
            nb2 = int.Parse(saisie);

            int moyenne = (nb1 + nb2) / 2;
            Console.WriteLine("La moyenne de " + nb1 + " et " + nb2 + " est " + moyenne);
        }

        public static void Aire()
        {
            double aire, rayon, volume;

            Console.WriteLine("Entrer le rayon de la sphère.");
            string saisie = Console.ReadLine();
            rayon= int.Parse(saisie);

            aire = Math.Round(4 * Math.PI * Math.Pow(rayon, 2)*100)/100;
            volume = Math.Round((4/3)*Math.PI*Math.Pow(rayon, 3)*100)/100;

            Console.WriteLine("L'aire de la sphère est de " + aire + " et le volume de " + volume+".");
        }

        public static void Surface()
        {
            double rayon, angle, surface;

            Console.WriteLine("Entrer le rayon d'un secteur circulaire.");
            string saisie = Console.ReadLine();
            rayon = int.Parse(saisie);
            Console.WriteLine("Entrez l'anlge du secteur.");
            saisie = Console.ReadLine();
            angle = int.Parse(saisie);

            surface = Math.Round(((Math.PI*Math.Pow(rayon,2)*angle)/360)*100)/100;
            Console.WriteLine("L'aire du secteur est "+ surface);
        }

        public static void Interets(){

            double somme, interet, nbAnnees;

            Console.WriteLine("Entrer la somme sur votre compte.");
            string saisie = Console.ReadLine();
            somme = int.Parse(saisie);
            Console.WriteLine("Entrez l'interet offert par la banque.");
            saisie = Console.ReadLine();
            interet = int.Parse(saisie);
            Console.WriteLine("Entrez le nombre d'années de placement.");
            saisie = Console.ReadLine();
            nbAnnees = int.Parse(saisie);

            double interetSimple = somme*(1 + nbAnnees * (interet/100));
            double interetCompose = Math.Round(somme*Math.Pow((1 + (interet/100)),nbAnnees)*100)/100;

            Console.WriteLine("Interet Simple = " + interetSimple + " et interet composé = " + interetCompose+".");
        }

        public static void Inversion()
        {
            int a, b, c;

            Console.WriteLine("Entrer nombre 1.");
            string saisie = Console.ReadLine();
            a = int.Parse(saisie);
            Console.WriteLine("Entrez nombre 2.");
            saisie = Console.ReadLine();
            b = int.Parse(saisie);

            Console.WriteLine("a = "+a+" et b = "+b);

            c = a;
            a = b;
            b = c;

            Console.WriteLine("Apres inversion : a = " + a + " et b = " + b);
        }

        //Partie 2

        public static void Comparaison()
        {
            int a;

            Console.WriteLine("Entrez votre age.");
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

        public static void TriDeux()
        {
            int a, b;

            Console.WriteLine("Entrer nombre 1.");
            string saisie = Console.ReadLine();
            a = int.Parse(saisie);
            Console.WriteLine("Entrez nombre 2.");
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
                Console.WriteLine("Les deux nombre sont égaux.");
            }
        }

        public static void TriTrois()
        {
            int a, b, c;

            Console.WriteLine("Entrer nombre1.");
            string saisie = Console.ReadLine();
            a = int.Parse(saisie);
            Console.WriteLine("Entrez nombre2.");
            saisie = Console.ReadLine();
            b = int.Parse(saisie);
            Console.WriteLine("Entrez nombre3.");
            saisie = Console.ReadLine();
            c = int.Parse(saisie);

            if (a > b && b > c)
            {
                Console.WriteLine(c + "<" + b + "<" + a);
            }
            else if (c > b && b > a)
            {
                Console.WriteLine(a + "<" + b + "<" + c);

            }
            else if (b > a && a > c)
            {
                Console.WriteLine(c + "<" + a + "<" + b);
            }
            else if (c > a && a > b)
            {
                Console.WriteLine(b + "<" + a + "<" + c);
            }
            else if (a > c && c > b)
            {
                Console.WriteLine(b + "<" + c + "<" + a);
            }
            else 
            {
                Console.WriteLine(a + "<" + c + "<" + b);
            }
        }
        public static void Bissext()
        {
            int annee;
               
            Console.WriteLine("Entrer une annee.");
            string saisie = Console.ReadLine();
            annee = int.Parse(saisie);

            if ((annee % 4 != 0) || (annee%4 == 0 && annee%100 == 0 && annee%400 != 0))
            {
                Console.WriteLine("Pas bissextile.");
            }
            else
            {
                Console.Write("Bissextile.");
            }
        }

        public static void Diviseurs()
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

        public static void Premier()
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

        public static void Conversion()
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
                Console.WriteLine("En miles :" + miles+".");
            }
        }

        //Partie 3

        public static void RechercheDeLettre()
        {
            int nbLettre ;
            string fin = "";
            string str ;

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

        public static void Barnabe()
        {
            int nbMagasins = 0;
            Random r = new ();
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

        public static void Fourchette()
        {
            Random r = new ();
            int nbAlea = r.Next(0, 100);
            int nb, min = 0, max = 100;
            int essais = 0;

            do
            {
                Console.WriteLine("Entrez un nombre entre " + min + " et " + max+".");
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
            int i;

            for (i = 0; i < tab.Length; i++)
            {
                if (tab[i] == nb)
                {
                    test = true;
                }     
            }
            if (test)
            {
                Console.WriteLine("Le nombre appartient au tableau.");
            }
            else
            {
                Console.WriteLine("404 No Found.");
            }
        }

        //Exercices #2
        //Partie 4

        public static void Parfait()
        {
            var diviseurs = new List<int>();

             int somme , c = 1, nb=0,n;
            Console.WriteLine("Entrez combien de nombres parfaits vous voulez trouver, jusqu'a 4 maximum.");
            n = int.Parse(Console.ReadLine());
            
            while (nb<n)
            {
                c++;
                somme = 0;
                for (int i = 1; i <= c/2 ; i++)
                {
                    if(c%i==0)
                    {
                        diviseurs.Add(i);
                        somme += i;
                    }
                }

                if (somme == c)
                {
                    Console.WriteLine(c+ " est un nombre parfait.");
                    nb++;
                }
            }       
        }

        public static void Palindrome()
        {
            string  first, second;

            Console.WriteLine("Taper une phrase, est-ce un palindrome?");
            first= Console.ReadLine().Replace(" ", "");

            char[] charArray = first.ToCharArray();
            Array.Reverse(charArray);

            second = new string(charArray);

            if (first.Equals(second))
            {
                Console.WriteLine("C'est un palindrome.");
            }
            else 
            {
                Console.WriteLine(" Ceci n'est pas un palindrome.");
            }       
        }

        //Ne fonctionne pas si deux valeurs identiques dans le tableau
        public static void TriCroissantTab()
        {
            int[] tab= { 2, 5, 15, 3, 18, 19, 17, 4, 8, 5, 65, 25, 48 };
            int stock;

            for(int i = 0; i < tab.Length; i++)
            {
                for (int j = 1; j < tab.Length; j++)
                {
                        if (tab[j] < tab[j - 1])
                        {
                            stock = tab[j - 1];
                            tab[j-1] = tab[j];
                            tab[j] = stock;  
                        }
                }
            }

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }

        public static void Pendu()
        {
            string mot1, mot2;
            char lettre;
            int essais1 = 0, essais2 = 0;
            bool test;

            do
            {
                Console.WriteLine("Entrer un mot.");
                mot1 = Console.ReadLine();
            } while (mot1.Length < 5);

            char[] tabChar1 = mot1.ToCharArray();
            char[] tabChar2 = mot1.ToCharArray();
             
            for (int i = 0; i < tabChar2.Length; i++)
            {
                if (i!=0 && i!= tabChar2.Length-1)
                {
                    tabChar2[i] = '_';
                }
            }
            
            mot2 = new String(tabChar2);
            Console.WriteLine(mot2);

                do
                {
                    test = false;
                    Console.WriteLine("Supposez une lettre.");
                    lettre = char.Parse(Console.ReadLine());

                    for (int i = 1; i < tabChar1.Length-1; i++)
                    {
                        if (lettre == tabChar1[i])
                        {
                            tabChar2[i] = lettre;
                            test = true;
                        }
                    }

                    if(!test)
                    {
                        essais1++;
                    }
                    
                    essais2++;

                    mot2 = new string(tabChar2);
                    Console.WriteLine(mot2);
                }
                while (!mot1.Equals(mot2) && essais1 !=6);

            if (mot1.Equals(mot2))
            {
                Console.WriteLine("Vous avez trouvé en " + essais2+" lettres.");
            }
            else
            {
                Console.WriteLine("Vous avez dépassé le nombre d'essais autorisés : 6.Le mot était "+mot1+".");
            }

        }
        public static void Journee()
        {
            Random r = new();

            //Chances de faire beune chance sur deux
            int a = r.Next(1,3);
            //Chances d'aller chez le garagiste et qu'il réparer la bicyclette: une chance sur 2 qu'elle soit cassée et si elle est cassée
            //une chance sur deux qu'elle soit réparée
            int b = r.Next(1,4);
            //Chances e posseder Got : une chance sur 2 qu'il soit chez moi et une chance sur deux qu'il soit  a la bibliothèquee
            int c = r.Next(1,3);


            //Chances de faire la balade à vélo
            if(a == 1 && b == 3  || a==1 && b ==2 )
            {
                Console.Write(" Il fait beau, mon vélo fonctionne, je vais me balader à vélo.");
            }
            //Chances d'aller à l'étang
            else if( a==1 && b==1)
            {
                Console.WriteLine("Il fait beau, mon vélo ne fonctionne pas je vais à l'étang cueillir des joncs.");
            }
            //Chances de lire Game of Thrones chez soi
            else if(a ==2 && c==1 )
            {
                Console.WriteLine("Il ne fait pas beau,je vais lire Game of Thrones chez moi dans mon fauteuil.");
            }
            //Chances de lire un roman chez soi
            else if(a==2 && c==2)
            {
  
                Console.WriteLine("Il ne fait pas beau, je lis un roman dans mon fauteuil.");
            }
        }

        public static void DenombrerLettres()
        {
            string texte = "La beauté de la nature est indubitablement époustouflante. Les vastes paysages montagneux, les océans majestueux et les" +
                " forêts luxuriantes offrent une escapade paradisiaque loin du tumulte de la vie quotidienne. La pureté et la fraîcheur de l'air en " +
                "montagne procurent une sensation enivrante de liberté. Se tenir au sommet d'une montagne et contempler l'immensité du monde qui " +
                "s'étend à perte de vue est une expérience qui marque à jamais l'esprit. De même, se promener le long d'une plage de sable fin, " +
                "les pieds plongés dans l'eau froide de l'océan, crée une sérénité intérieure qui apaise l'âme. Enfin, prendre une randonnée dans" +
                " une forêt émeraude, avec le doux murmure du vent dans les feuilles et la richesse de la flore et de la faune, procure un " +
                "sentiment de connexion profonde avec la nature. La beauté de ces paysages naturels nous rappelle l'importance de préserver et de" +
                " respecter notre environnement pour les générations futures.";

            char[] tabTexte = texte.ToCharArray();
            
            char[] tabAlphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int[] tabOccurence = new int[26];

            for (int i = 0; i < tabTexte.Length; i++)
            {
                for (int j = 0; j < tabAlphabet.Length; j++)
                {
                    if(tabTexte[i] == tabAlphabet[j])
                    {
                        tabOccurence[j] = tabOccurence[j] + 1;
                    }
                }
            }

            for  (int i = 0; i < tabOccurence.Length; i++)
            {
                Console.WriteLine("Il y a " + tabOccurence[i] + " la lettre " + tabAlphabet[i] + " dans votre texte.");
            }
        }

        public static void AfficherPersonnes()
        {
            int[] tabAge = new int[20];
            List<int> moinsEtEgal = new();
            List<int> plusDeVingt = new();
            List<int> moinsDeVingt = new();
            /*plusDeVingt = null;
            moinsDeVingt = null;
            moinsEtEgal = null;*/

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Entrez l'age d'une personne.");
                tabAge[i] = int.Parse(Console.ReadLine());
                if (tabAge[i]>20)
                {
                    plusDeVingt.Add(tabAge[i]);
                }
                else if (tabAge[i]<20)
                {
                    moinsDeVingt.Add(tabAge[i]);
                    moinsEtEgal.Add(tabAge[i]);
                }
                else
                {
                    moinsEtEgal.Add(tabAge[i]);
                }
            }

            Console.WriteLine("Plus de vingt ans.");
            for (int i = 0; i < plusDeVingt.Count;i++)
            {
                
                Console.Write(plusDeVingt[i]+" ");
            }

            Console.WriteLine("/nMoins de vingt ans.");
            for (int i = 0; i < moinsDeVingt.Count; i++)
            {

                Console.Write(moinsDeVingt[i] + " ");
            }

            Console.WriteLine("/nMoins de vingt ans et 20ans.");
            for (int i = 0; i < moinsEtEgal.Count; i++)
            {

                Console.Write(moinsEtEgal[i] + " ");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string test = "lavala";
            string[] str = test.Split('a');

            foreach(var word in str)
            {
                Console.Write(word);
            }

            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

            string text = "one\ttwo :,five six seven";
            System.Console.WriteLine($"Original text: '{text}'");

            string[] words = text.Split(delimiterChars);
            System.Console.WriteLine($"{words.Length} words in text:");

            foreach (var word in words)
            {
                System.Console.WriteLine($"<{word}>");
            }

            Console.WriteLine(text.Split(delimiterChars).Length);

            Fourchette();
        }
    }
}
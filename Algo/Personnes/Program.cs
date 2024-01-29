using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TP01
{
    public interface IPeopleContainer
    {
        public List<Person> SortByLastName(List<Person> _noms);
        public List<Person> SortByFirstName(List<Person> _prenoms);
    }

    internal class Program
    {
        public static string afficheSaisie(string typeSaisie)
        {
            string saisie;
            //Saisie du nom d'un personne
            Console.WriteLine("Saisir le "+typeSaisie);
            saisie = Console.ReadLine();
            saisie[0].ToString().ToUpper();
            return saisie;
        }

        //On affiche les noms
        public static void affichage(List<Person> triList, bool choix)
        {
            Console.WriteLine("Noms par ordre alphabétique:");
            foreach(Person p in triList)
            {
                if(choix)
                { 
                    Console.WriteLine(p.nom + "  " + p.prenom);
                }
                else
                {
                    Console.WriteLine(p.prenom + "  " + p.nom);
                }
            }
        }

        //On rempli le JSON
        public static void remplissageJSON(List<Person> listePersonnes)
        {
            string json = JsonSerializer.Serialize(listePersonnes);
            File.WriteAllText(@".\personnes.json", json);
        }

        //Enlever une personne de la liste de personnes
        public static void supprimerPersonne(List<Person> listePersonnes,Person suppr)
        {      
                Person temp = Person.comparer(suppr,listePersonnes);
                if(temp!=null)
                {
                    listePersonnes.Remove(temp);
                }             
        }

        static void Main(string[] args)
        {
            //Liste de personnes, de noms et de prénoms
            List<Person> listePersonnes = new List<Person>();

            //Instanciation de trois objets Person et ajout de ces trois objets à la liste de personnes
            listePersonnes.Add(new Person("Crochet", "Florent"));
            listePersonnes.Add(new Person("Gibier", "Aurelien"));
            listePersonnes.Add(new Person("Maurice", "Anthony"));


            //Début du Do/While qui permet la gestion de l'ajout de personnes par l'utilisateur
            //La condition du while est une saisie clavier
            do
            {
                //Création d'une personne avec le nom et le prénom saisis
                Person myPerson = new Person(afficheSaisie("nom"),afficheSaisie("prenom"));

                //On remplit et test si la personne est déja présente,et la supprime à la demande de l'utilisateur
                bool testRemplissage = myPerson.remplissage(listePersonnes,myPerson);
                if(testRemplissage == false)
                {
                    Console.WriteLine("La personne existe déja.");
                    Console.WriteLine("Voulez vous la supprimer de la liste de personnes? o pour oui,n'importe quelle touche pour non");
                    if(Console.ReadLine().ToUpper().Equals("O"))
                    {
                        supprimerPersonne(listePersonnes, myPerson);
                    }
                }

                //On instancie la classe PeopleContainer en lui donnant en attribut la liste de personnes
                PeopleContainer myPersonContainer = new PeopleContainer(listePersonnes);

                //On s'en sert pour trier les noms ou prénoms grace à ses méthode de classes
                Console.WriteLine("Tri par nom ou prénoms? n ou p ou n'importe quelle touche pour quitter");
                string saisie = Console.ReadLine().ToUpper();
                if (saisie.Equals("N"))
                {
                    myPersonContainer.SortByLastName(listePersonnes);
                    //On affiche les noms
                    affichage(listePersonnes,true);
                }
                else if (saisie.Equals("P"))
                {
                    myPersonContainer.SortByFirstName(listePersonnes);
                    //On afiche les prénoms
                    affichage(listePersonnes,false);
                }

                //On demande à l'utilisateur s'il veut réjouter une personne
                Console.WriteLine("Voulez vous ajouter une autre personne? o pour oui, n'importe quelle autre touche pour quitter.");

            } while (Console.ReadLine().ToUpper().Equals("O"));//Si o , on repasse dans la boucle, sinon on quitte

            //Demande à l"utilisateur s'il veut récupérer la liste de personnes dans un fichier JSON
            Console.WriteLine("Voulez vous enregistrer vos données au format JSON ? o pour oui, autre pour quitter.");

            //Si l'utilisateur le choisit nous créons une chaine de caractère récupérant la liste de personne
            // et nous créons un fichier json qui récupère cette chaine
            if (Console.ReadLine().ToUpper().Equals("O"))
            {
                remplissageJSON(listePersonnes);
            }
        }
    }
}
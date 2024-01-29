using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01;

namespace TP01
{
    public class Person
    {
        public string nom {get;set;}
        public string prenom {get; set;}

        //Constructeur avec paramètres
        public Person(string _nom, string _prenom)
        {
            this.nom = _nom;
            this.prenom = _prenom;
        }

        //Fonction de comparaison de deux personnes
        public static Person comparer(Person other,List<Person> listePersonnes)
        {
            return listePersonnes.Find(p => p.nom.ToUpper() == other.nom.ToUpper() && p.prenom.ToUpper() == other.prenom.ToUpper());
        }

        public bool remplissage(List<Person> listePersonnes,Person myPerson)
        {
            bool rempli = false;
            bool trouve = false;
            //Si la personne n'est pas présente, on l'ajoute

            Person same = comparer(myPerson, listePersonnes);
            
            if(same == null)
            {
                listePersonnes.Add(myPerson);
                rempli = true;
            }
            else
            {
                rempli = false;
            }
            return rempli;
        }         

    }
}

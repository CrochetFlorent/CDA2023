using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    public class PeopleContainer : IPeopleContainer
    {
        private List<Person> personnes;


        //Constructeur avec paramètres
        public PeopleContainer(List<Person> _personnes)
        {
            this.personnes = _personnes;
        }


        //Tri par ordre alphabétique des noms
        public List<Person> SortByLastName(List<Person> triNoms)
        {
            triNoms.OrderBy(x => x.nom);
            return triNoms;
            throw new NotImplementedException();
        }

        //Tri par ordre alphabétique des prénoms
        public List<Person> SortByFirstName(List<Person> triPrenoms)
        {
            triPrenoms.OrderBy(x => x.prenom);
            return triPrenoms;
            throw new NotImplementedException();
        }
    }
}

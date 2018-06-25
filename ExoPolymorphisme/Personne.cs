using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPolymorphisme
{
    public class Personne
    {
        private string nom;
        private string prenom;
        private DateTime dateNaissance;

        public string Nom { get { return this.nom; } }
        public string Prenom { get { return this.prenom; } }
        public DateTime DateNaissance { get { return this.dateNaissance; } }

        public Personne(string nom, string prenom, DateTime dateNaissance)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
        }

        public virtual void Afficher()
        {
            Console.WriteLine("Depuis la classe Personne =>\n Nom : " + Nom + ";\nPrénom : " + Prenom + ";\nDate de naissance : " + DateNaissance);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPolymorphisme
{
    public abstract class Personne
    {
        private string nom;
        private string prenom;
        private DateTime dateNaissance;

        public string Nom { get { return this.nom; }}
        public string Prenom { get { return this.prenom; } }
        public string DateNaissance { get { return this.DateNaissance; } }

        public Personne(string nom, string prenom, DateTime dateNaissance)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
        }

        public string Afficher()
        {
            return "Depuis la classe Personne =>\n Nom : " + Nom + ";\nPrénom : " + Prenom + ";\nDate de naissance : " + DateNaissance;
        }

    }
}

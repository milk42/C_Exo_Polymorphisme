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
        private string date_naissance;

        public string Nom { get { return this.Nom; }}
        public string Prenom { get { return this.Prenom; } }
        public string Date_naissance { get { return this.Date_naissance; } }

        public Personne(string nom, string prenom, string date_naissance)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.date_naissance = date_naissance;
        }

        public string Afficher()
        {
            return "Depuis la classe Personne =>\n Nom : " + Nom + ";\nPrénom : " + Prenom + ";\nDate de naissance : " + Date_naissance;
        }


    }
}

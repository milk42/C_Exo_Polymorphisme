using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPolymorphisme
{
    class Employe : Personne
    {
        private int salaire;

        public int Salaire { get { return this.Salaire; } }

        public Employe(string nom, string prenom, string date_naissance, int salaire) : base(nom, prenom, date_naissance)
        {
        }

        public override string Afficher()
        {
            return "Depuis la classe Personne =>\n Nom : " + Nom + ";\nPrénom : " + Prenom + ";\nDate de naissance : " + Date_naissance + ";\nSalaire = " + salaire;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPolymorphisme
{
    class Directeur : Chef
    {
        private string societe;

        public string Societe { get { return this.Societe; } }
        public Directeur(string nom, string prenom, string date_naissance, int salaire, string service, string societe) : base(nom, prenom, date_naissance, salaire, service)
        {
        }

        public override string Afficher()
        {
            return base.Afficher();
        }
    }
}

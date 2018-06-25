using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPolymorphisme
{
    class Directeur : Chef
    {
        // Les attributs peuvent être notés avec un underscore par convention
        private string _societe;

        public string Societe { get { return this._societe; } }

        public Directeur(string nom, string prenom, DateTime dateNaissance, double salaire, string service, string societe) : base(nom, prenom, dateNaissance, salaire, service)
        {
            this._societe = societe;
        }

        public override void Afficher()
        {
            // redéfinir en ajoutant société
            base.Afficher();
            Console.WriteLine($" Société : {this._societe}");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPolymorphisme
{
    class Chef : Employe
    {
        private string service;

        public string Service { get { return this.Service; } }
        public Chef(string nom, string prenom, string date_naissance, int salaire, string service) : base(nom, prenom, date_naissance, salaire)
        {
        }

        public override string Afficher()
        {
            return base.Afficher();
        }
    }
}

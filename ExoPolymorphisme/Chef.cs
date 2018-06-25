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
        public Chef(string nom, string prenom, DateTime dateNaissance, double salaire, string service) : base(nom, prenom, dateNaissance, salaire)
        {
            this.service = service;
        }

        public override void Afficher()
        {
            // redéfinir en ajoutant service
             base.Afficher();
            Console.WriteLine($" Sevice : {this.service}");
        }
    }
}

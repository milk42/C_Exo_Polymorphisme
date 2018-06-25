using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPolymorphisme
{
    class Employe : Personne
    {
        private double salaire;

        public int Salaire { get { return this.Salaire; } }

        public Employe(string nom, string prenom, DateTime dateNaissance, double salaire) : base(nom, prenom, dateNaissance)
        {
            this.salaire = salaire;
        }

        public override void Afficher()
        {
            // redéfinir en ajoutant salaire
            base.Afficher();
            Console.WriteLine($" Salaire : {salaire}"); 
        }

    }
}

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

        public double Salaire { get { return this.salaire; } }

        public Employe(string nom, string prenom, string date_naissance, int salaire) : base(nom, prenom, date_naissance)
        {
           this.salaire = salaire;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine($"Salaire : {this.salaire} Euros");           
        }
    }
}

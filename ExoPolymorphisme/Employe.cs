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

        // Dans le constructeur qui hérite de sa classe mère, les paramètres hérités sont rappelés après "base"
        public Employe(string nom, string prenom, DateTime dateNaissance, double salaire) : base(nom, prenom, dateNaissance)
        {
            this.salaire = salaire;
        }

        // je modifie la méthode Afficher de la classe mère avec override
        public override void Afficher()
        {
            // j'appelle le contenu de la méthode de la classe mère et j'ajoute un bout de phrase
            base.Afficher();
            Console.WriteLine($" Salaire : {this.salaire}"); 
            // cette interpolation avec le $ et les accolades ne sont pas obligatoires, on peut simplement faire une concaténation
        }

    }
}

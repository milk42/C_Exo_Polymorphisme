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
        public DateTime DateNaissance { get { return this.dateNaissance; } }

        public Personne(string nom, string prenom, string dateNaissance)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
        }

        public void Afficher()
        {
            Console.WriteLine($"\nNom : {this.nom}\nPrenom : {this.prenom}\nDate de naissance : {this.dateNaissance.ToString("dd/MM/yyyy")}");
        }
    }
}

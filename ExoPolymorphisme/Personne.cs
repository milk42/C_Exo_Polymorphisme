using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPolymorphisme
{
    public class Personne
    {
        // les attributs sont en private donc ne peuvent être appelés que dans cette classe (ici dans le constructeur)
        private string nom;
        private string prenom;
        private DateTime dateNaissance;

        // les propriétés, toujours avec une majuscule ont des 
        // getters setters si on veut modifier leur valeur à l'extérieur de cette classe
        public string Nom { get { return this.nom; } }
        public string Prenom { get { return this.prenom; } }
        public DateTime DateNaissance { get { return this.dateNaissance; } }

        public Personne(string nom, string prenom, DateTime dateNaissance)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
        }

        // virtual sert à donner accès à la méthode pour les classes filles afin de pouvoir la modifier (override)
        public virtual void Afficher()
        {
            Console.WriteLine("Depuis la classe Personne =>\n Nom : " + Nom + ";\nPrénom : " + Prenom + ";\nDate de naissance : " + DateNaissance);
        }
    }
}

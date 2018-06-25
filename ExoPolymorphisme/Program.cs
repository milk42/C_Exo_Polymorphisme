using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPolymorphisme
{
    class Program
    {
        static void Main(string[] args)
        {
            // J'ai mis un DateTime.Now car je n'ai pas trouvé le bon format de date de base en C#
            Personne[] personnes = new Personne[8];
            personnes[0] = new Employe("Fogham", "souleimane", DateTime.Now, 10000);
            personnes[1] = new Employe("Fogham", "souleimane", DateTime.Now, 10000);
            personnes[2] = new Employe("Fogham", "souleimane", DateTime.Now, 10000);
            personnes[3] = new Employe("Fogham", "souleimane", DateTime.Now, 10000);
            personnes[4] = new Employe("Fogham", "souleimane", DateTime.Now, 10000);

            personnes[5] = new Chef("Fogham", "souleimane", DateTime.Now, 10000, "dev");
            personnes[6] = new Chef("Fogham", "souleimane", DateTime.Now, 10000, "dev");

            personnes[7] = new Directeur("Fogham", "souleimane", DateTime.Now, 10000, "dev", "SARL");



            // Entrainement boucle foreach sur un tableau
            foreach (Personne p in personnes)
            {
                Console.WriteLine(p);
           
            }
            // Entrainement boucle for sur un tableau
            // .length pour un tableau / .Count pour une liste
            for(int i = 0; i < personnes.Length; i++)
            {
                personnes[i].Afficher();
            }

            // pour que la console reste ouverte au lancement du projet
            Console.ReadLine();
        }
    }
}

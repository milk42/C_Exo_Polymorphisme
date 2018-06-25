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

            Personne[] personnes = new Personne[8];
            personnes[0] = new Employe("Fogham", "souleimane", DateTime.Now, 10000);
            personnes[1] = new Employe("Fogham", "souleimane", DateTime.Now, 10000);
            personnes[2] = new Employe("Fogham", "souleimane", DateTime.Now, 10000);
            personnes[3] = new Employe("Fogham", "souleimane", DateTime.Now, 10000);
            personnes[4] = new Employe("Fogham", "souleimane", DateTime.Now, 10000);

            personnes[5] = new Chef("Fogham", "souleimane", DateTime.Now, 10000, "dev");
            personnes[6] = new Chef("Fogham", "souleimane", DateTime.Now, 10000, "dev");

            personnes[7] = new Directeur("Fogham", "souleimane", DateTime.Now, 10000, "dev", "SARL");


            foreach (Personne p in personnes)
            {
                Console.WriteLine(p);
           
            }

            for(int i = 0; i < personnes.Length; i++)
            {
                personnes[i].Afficher();
            }

            Console.ReadLine();
        }
    }
}

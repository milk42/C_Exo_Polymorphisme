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

            List<Personne> personnes = new List<Personne>();

            Employe souleimane = new Employe("Foghram", "souleimane", "12/12/1980", 10000);
            Employe al = new Employe("reza", "al", "12/12/1980", 10000);
            Employe lea = new Employe("azer", "lea", "12/12/1980", 10000);
            Employe zoe = new Employe("zera", "zoe", "12/12/1980", 10000);
            Employe leo = new Employe("raze", "leo", "12/12/1980", 10000);
            Chef yo = new ExoPolymorphisme.Chef("raze", "yo", "12/12/1980", 10000, "dev");
            Chef ya = new ExoPolymorphisme.Chef("raze", "ya", "12/12/1980", 10000, "dev");
            Directeur dir = new ExoPolymorphisme.Directeur("raze", "leo", "12/12/1980", 10000, "dev", "SARL");

            personnes.Add(souleimane);
            personnes.Add(al);
            personnes.Add(lea);
            personnes.Add(zoe);
            personnes.Add(leo);
            personnes.Add(yo);
            personnes.Add(ya);
            personnes.Add(dir);

            foreach (Personne p in personnes)
            {
                Console.WriteLine(p);
           
            }

            for(int i = 0; i < personnes.Count; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

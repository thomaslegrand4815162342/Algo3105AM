using Algo3105AM.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo3105AM
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Ecriture d'une liste et d'items
            List<MenuItem> list = new List<MenuItem>
            {
                new MenuItem{Libelle="menu1"},
                new MenuItem{Libelle="menu3"},
                new MenuItem{Libelle="menu7"},
                new MenuItem{Libelle="menu15"},
            };

            int resultat = GererMenu(list);
            Console.WriteLine(resultat);
            Console.ReadLine();
         }

        //METHODES

            /// <summary>
            /// Affiche un menu et teste puis récupère la saisie de l'utilisateur
            /// </summary>
            /// <param name="menu">La liste des choix possibles</param>
            /// <returns>Le choix de l'utilisateur</returns>
        private static int GererMenu(List<MenuItem> menu)
        {
            //Affiche le menu
            foreach (MenuItem ligne in menu)
            {
                Console.WriteLine($"{ligne.Numero} et {ligne.Libelle}");
            }
            
            //Récupération de la saisie
            int choix;
            choix = int.Parse(Console.ReadLine());

            /*Type test = typeof(int);*/

            //test du choix par rapport au menu
            /*foreach (MenuItem item in menu)

            {
                if (choix == item.Numero)
                return choix;
            }

            Console.WriteLine("Erreur de la saisie");
            return -1;*/

            //2ème méthode avec linq à la place de foreach
            //return menu.SingleOrDefault(x => x.Numero == choix) is null ? choix : -1;
            
            //Vérification que le choix est un int
            /*if (choix.GetType().Equals(test))
            {
                Console.WriteLine($"ok+{choix}");
                return choix;
            }
            else { Console.WriteLine($"pas ok+{choix}"); return choix; }*/

        }

       



    }
    
    
}
    

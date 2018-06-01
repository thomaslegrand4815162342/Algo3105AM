using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo3105AM.classes
{
    class Menu
    {
        private List<MenuItem> menuItems;

        public Menu()
        { menuItems = new List<MenuItem>(); }

        public void InsererLigne(MenuItem item)
        {
            //1ère méthode avec foreach
            /*foreach (var ligne in menuItems)
            {
                if (ligne.Numero == item.Numero)
                {throw new ArgumentException($"Le numéro {item.Numero} existe déjà"); }
            }*/

            //2e méthode avec .Exists
            if (menuItems.Exists(x => x.Numero == item.Numero))
            { throw new ArgumentException($"Le numéro {item.Numero} existe déjà"); }

            menuItems.Add(item);
        }

        public void Afficher()
        {
            foreach (MenuItem ligne in menuItems)
            {
                Console.WriteLine($"{ligne.Numero} et {ligne.Libelle}");
            }
        }

        public int Choisir()
        {
            Console.WriteLine("Saisir un choix");
            int choix;
            choix = int.Parse(Console.ReadLine());

            foreach (MenuItem item in menuItems)
            {
                if (choix == item.Numero)
                    return choix;
            }

            Console.WriteLine("Erreur de la saisie");
            return -1;
        }
        
    }
}

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
            
        }

        private static int GererMenu(List<MenuItem> menu)
        {
            foreach (MenuItem ligne in menu)
            {
                Console.WriteLine(ligne);
            }
            int choix;
            choix = int.Parse(Console.ReadLine());

              Type test = typeof(int);


            foreach (MenuItem item in menu)

            {

                if (choix == item.Numero)
                return choix;
            }
            Console.WriteLine("Erreur de la saisie");
            return -1;
            

            /*if (choix.GetType().Equals(test))
            {
                Console.WriteLine($"ok+{choix}");
                return choix;
            }
            else { Console.WriteLine($"pas ok+{choix}"); return choix; }*/

        }



        
            

    }
    
    
}
    

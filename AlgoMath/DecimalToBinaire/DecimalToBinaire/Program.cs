using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinaire
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int dividende, quotient, reste;
            int diviseur = 2;
            List<int> stockreste = new List<int>();


            ////UI
            Console.WriteLine("Saisissez un nombre decimal puis appuyez sur la toucher ENTREE");
            dividende = int.Parse(Console.ReadLine()); // converti la string en int pour la stocker dans dividende

            while (dividende / 2 >= 1)
            {
                quotient = dividende / 2;
                Console.WriteLine("le quotient est de " + quotient);
                reste = dividende % 2;
                stockreste.Add(reste); // ajoute à la liste la valeur de reste
                Console.WriteLine("le reste est de " + reste);
                dividende = quotient;
                Console.WriteLine("la valeur du dividende est maintenant de " + dividende);
                if (quotient == 1) // dans le cas d'un nombre impaire ajouter la valeur du quotient en reste pour que le nombre binaire soit valide.
                {
                    stockreste.Add(quotient);
                }
            }
            
            foreach(int element in stockreste)
            {
                Console.Write(element.ToString());
            }

            Console.ReadLine();

        }
    }
}

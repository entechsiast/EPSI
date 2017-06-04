using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int nb1, nb2, nb3 ;
            int plusGrandNombre, plusPetitNombre, quotient;
            int reste, Dividende,Diviseur ; // initialisé à 1 pour entrer dans la boucle

            #region UI
            Console.WriteLine("saisissez le 1er nombre");
            nb1 = int.Parse(Console.ReadLine()); // recupère le premier nombre

            Console.WriteLine("saisissez le 2eme nombre");
            nb2 = int.Parse(Console.ReadLine()); // recupère le 2eme nombre
            #endregion

            #region Défini les plus grand et plus petits nombres du couple nb1 nb2
            Dividende = Math.Max(nb1, nb2); // selectionne le plus grand nombre du couple nb1 nb2, qui sera le dividende
            Diviseur = Math.Min(nb1, nb2); // selectionne le plus petit nombre du couple nb1 nb2, qui sera le diviseur
            #endregion

            #region fait la division du plus grand nombre par le plus petit nombre et récupère le reste
            // le reste deviens le nouveau diviseur, le reste de la division étant toutjours inférieur au diviseur ici;
            reste = Dividende % Diviseur;
            #endregion

            Dividende = Diviseur;

            while (reste != 0)
            {
                #region le reste se transforme en diviseur de la nouvelle division et le diviseur de l'ancienne se transforme en dividende de la nouvelle
                Diviseur = reste;
                #endregion

                #region calcul le reste de la nouvelle Division
                reste = Dividende % Diviseur;
                #endregion
                Dividende = Math.Max(reste, Diviseur);
            }

            Console.Write("le PGC de " + nb1 + " et " + nb2 + " est " + Diviseur);


            Console.ReadLine();
        }
    }
}

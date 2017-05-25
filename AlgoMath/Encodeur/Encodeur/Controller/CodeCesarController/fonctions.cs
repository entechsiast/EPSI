using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encodeur.Controller.CodeCesarController
{
    public static class fonctions
    {
        public static string chiffrer(string chaineCaractere, int cle, int modulo)
        {
            //déclaration des variables
            string chaineChiffree= null; //chaine de caractère résultat du cryptage
            int reste; // reste de la division euclidienne du numero du caractère de chaineCaractère et du modulo
            char caractereChiffre; //caractère composant la chaine cryptée
            string enMaj = chaineCaractere.ToUpper();
            if(chaineCaractere == enMaj)
            {
                chaineCaractere.ToLower(); //converti l'intégralité de la chaine en minuscule pour ne pas se préocupper des majuscules
            }
            

            // Pour chaque caractère qui se trouve dans la chaine de caractère à crypter
            foreach (char unCaractere in chaineCaractere)
            {
                //le caractère chiffré prend la valeur de l'index deu caractère à crypter + la valeur de la clé de cryptage
                caractereChiffre = (char)(unCaractere + cle);


                // la simple cote indique qu'il s'agit d'un caractère et non d'une string
                // si la valeur de l'index du caractère est supérieure à la valeur de z ou Z (différents caractères dans la table ASCII)
                if (caractereChiffre > 'z')
                {
                    char differenceChiffreEtZ = (char)(caractereChiffre - 'z');
                    char differenceCleResteChiffreEtZ = (char)(cle - differenceChiffreEtZ);
                    caractereChiffre =(char) (('a' + differenceChiffreEtZ)-1);
                }
                //contruit la chaine de caractère cryptée en y ajoutant à chaque boucle le chiffre résultant de l'opération
                chaineChiffree += caractereChiffre;
            }

            return chaineChiffree;
        }
    }
}

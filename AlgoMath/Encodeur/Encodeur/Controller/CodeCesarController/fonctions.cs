using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encodeur.Controller.CodeCesarController
{
    public static class fonctions
    {
        #region cryptage
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

                //Cette partie permet de recommencer l'opération depuis la lettre a quand z est dépassé
                    // la simple cote indique qu'il s'agit d'un caractère et non d'une string
                    // si la valeur de l'index du caractère est supérieure à la valeur de z ou Z (différents caractères dans la table ASCII)
                if (caractereChiffre > 'z')
                {
                    //fait la différence entre la valeur de z et la valeur du caractère chiffré
                    char differenceChiffreEtZ = (char)(caractereChiffre - 'z');
                    //soustrait la différence précédente à la valeur de la clé de cryptage
                    char differenceCleResteChiffreEtZ = (char)(cle - differenceChiffreEtZ);
                    //ajoute le résultat de l'opéation précédente moins 1 pour obtenir le bon résultat
                    caractereChiffre =(char) (('a' + differenceChiffreEtZ)-1);
                }
                //contruit la chaine de caractère cryptée en y ajoutant à chaque boucle le chiffre résultant de l'opération
                chaineChiffree += caractereChiffre;
            }

            return chaineChiffree;
        }
        #endregion

        #region decryptage
        public static string dechiffrer(string chaineADechiffrer, int cle, int modulo)
        {
            string laChaineDechiffree = null;
            char caractereDechiffre;

            // transforme la chaine a dechiffrer en minuscule
            chaineADechiffrer.ToLower();

            //pour chaque caractère de la chaine a dechiffrer je dois y soustraire la cle
            foreach(char unCaractere in chaineADechiffrer)
            {
                caractereDechiffre = (char)(unCaractere - cle);

                if(caractereDechiffre < 'a')
                {
                    //fait la difference entre la valeur du caractère et celle de a
                    char differenceCharEtA = (char)(unCaractere - 'a');
                    //valeur a soustraire de z
                    char diff = (char)(cle - differenceCharEtA);
                    //soustrait cette différence de la valeur de z et ajoute 1
                    char differenceAvecZ = (char)(('z' - diff)+1);
                    //affecte la valeur à caractère dechiffre
                    caractereDechiffre = differenceAvecZ;
                }

                laChaineDechiffree += caractereDechiffre;
            }

            return laChaineDechiffree;
        }
        #endregion
    }
}

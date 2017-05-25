using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encodeur.Controller.CodeCesarController
{
    public class fonctions
    {
        public string chiffrer(string chaineCaractere, int cle, int modulo)
        {
            string chaineChiffree= null;
            int reste;
            char caractereChiffre;

            foreach(char unCaractere in chaineCaractere)
            {
                caractereChiffre = (char)(unCaractere + cle);

                if (caractereChiffre > modulo)
                {
                    caractereChiffre = (char)(unCaractere - cle);
                }

                chaineChiffree += chaineChiffree + caractereChiffre;
            }

            return chaineChiffree;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Revision_Jonathan
{
    public class Departement
    {
        #region attributs

        private string libelle;
        private int numero;



        #endregion

        #region methodes
        public string Libelle
        {
            get
            {
                return libelle;
            }

            set
            {
                libelle = value;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public string ToString()
        {
            string laChaine;

            laChaine = "le libellé du département est : " + this.libelle;
            laChaine += "le numero du département est : " + this.numero;

            return laChaine;
        }

        public Departement()
        {

        }

        public Departement(string nomDuDepartement, int numeroDuDepartement)
        {
            this.libelle = nomDuDepartement;
            this.numero = numeroDuDepartement;
        }
        #endregion
    }
}

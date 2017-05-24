using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Revision_Jonathan
{
    public class TeleSiege : Remontee
    {
        #region attibutes
        private int nbSieges;

        #endregion

        #region methods
        public int NbSieges
        {
            get
            {
                return nbSieges;
            }

            set
            {
                nbSieges = value;
            }
        }

        public override string ToString()
        {
            string laChaine;

            laChaine = base.ToString() + "le nombre de siège est de: " + this.nbSieges;
            

            return laChaine;
        }



        public TeleSiege(int altitude, int debit, int denivele, int distance, int numero, int nombredeSieges) : base( altitude,  debit,  denivele,  distance,  numero)
        {
            this.nbSieges = nombredeSieges;
        }

        // modèle constructeur classe dérivée + constructeur classe mère : base()
        #endregion


    }
}

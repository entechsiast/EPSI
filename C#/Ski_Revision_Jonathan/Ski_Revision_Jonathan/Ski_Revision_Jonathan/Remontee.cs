using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Revision_Jonathan
{
    public class  Remontee
    {
        #region attributes
        private int altitude;
        private int debit;
        private int denivele;
        private int distance;
        private int numero;

        #endregion

        #region methods

        public Remontee(int altitude, int debit, int denivele, int distance, int numero)
        {
            this.altitude = altitude;
            this.debit = debit;
            this.denivele = denivele;
            this.distance = distance;
            this.numero = numero;
        }


        

        public int Altitude
        {
            get
            {
                return altitude;
            }

            set
            {
                altitude = value;
            }
        }

        public int Debit
        {
            get
            {
                return debit;
            }

            set
            {
                debit = value;
            }
        }

        public int Denivele
        {
            get
            {
                return denivele;
            }

            set
            {
                denivele = value;
            }
        }

        public int Distance
        {
            get
            {
                return distance;
            }

            set
            {
                distance = value;
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

        public virtual string ToString()
        {
            string laChaine;
            laChaine = "l'altitude de la remontée: " + this.altitude ;
            laChaine += "le débit de la remontée: " + this.debit;
            laChaine += "le denivelé de la remontée: " + this.denivele;
            laChaine += "la distance de la remontée: " + this.distance;
            laChaine += "le numero de la remontée: " + this.numero;

            return laChaine;
        }

        #endregion
    }
}

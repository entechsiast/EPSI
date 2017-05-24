using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas_Thali
{
    public class Etape
    {
        private uint numEtape;
        private string description;
        private sbyte dureeEtapeEnMin;

        public Etape(uint unNumEtape, string uneDescription, sbyte uneDureeEtape)
        {
            this.numEtape = unNumEtape;
            this.description = uneDescription;
            this.dureeEtapeEnMin = uneDureeEtape;
        }

        //public String donneDureePrevueHHMM()
        //{
        //    int dureePrevue;

        //    return Convert.ToString(dureePrevue);
        //}

        public uint getNumEtape()
        {
            return this.numEtape;
        }

        //public SByte getDureeEtape()
        //{
        //    SByte dureeEtape;

        //    return dureeEtape;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas_Thali
{
    class MiniExcursionsPayantes : MiniExcursion
    {
        private float tarif;


        public MiniExcursionsPayantes(int unNumMiniExcursion, String unLibelleMiniExcursion, int unNombrePlaces,
            float unTarif) : base(unNumMiniExcursion, unLibelleMiniExcursion, unNombrePlaces)
        {
            
        }
    }
}

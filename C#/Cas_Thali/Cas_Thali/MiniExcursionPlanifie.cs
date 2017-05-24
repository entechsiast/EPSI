using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas_Thali
{
    public class MiniExcursionPlanifie
    {
        private MiniExcursion laMiniExcursion;
        private TimeSpan depart;
        private byte nombreInscrits;

        public MiniExcursionPlanifie(MiniExcursion uneMiniExcursion, TimeSpan uneHeureDepart)
        {
            this.laMiniExcursion = uneMiniExcursion;
            this.depart = uneHeureDepart;
        }

        //public Boolean inscrit(Byte nbVoulu)
        //{

        //}

        //public Byte getNombreInscrits()
        //{

        //}

        public Boolean estComplete()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Revision_Jonathan
{
    public class TeleSki:Remontee
    {
        #region attributes
        private Boolean debrayee;

        #endregion

        #region methodes

        public bool Debrayee
        {
            get
            {
                return debrayee;
            }

            set
            {
                debrayee = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "Etat de la remontée ( 0 pas débrayée / 1 débrayée)" + this.debrayee;
            // demander confirmation sur syntaxe
        }

        public TeleSki()
        {

        }

        public void debrayeTeleski()
        {
            this.debrayee = true;
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace forfaitSkiSaison
{
    public class ForfaitSkiSaison : ForfaitSki.ForfaitSki
    {
        #region liste
        
        #endregion

        #region attributes
        private static DateTime dateDebutSaison;
        private static DateTime dateFinSaison;
        private string adresseRue;
        private string cp;
        private string adresseVille;
        #endregion

        #region get/set
        public DateTime getDateDebutSaison()
        {
            return dateDebutSaison;
        }

        public void setDateDebutSaison(DateTime uneDate)
        {
            dateDebutSaison = uneDate;
        }

        public DateTime getDateFinSaison()
        {
            return dateFinSaison;
        }

        public void setDateFinSaison(DateTime uneDate)
        {
            dateFinSaison = uneDate;
        }

        public string getAdresseRue()
        {
            return this.adresseRue;
        }

        public void setAdresseRue(string uneAdresse)
        {
            this.adresseRue = uneAdresse;
        }

        public string getCodePostal()
        {
            return this.cp;
        }

        public void setCodePostal(string unCodePostal)
        {
            this.cp = unCodePostal;
        }

        public string getAdresseVille()
        {
            return this.adresseVille;
        }

        public void setAdresseville(string uneAdresseDeVille)
        {
            this.adresseVille = uneAdresseDeVille;
        }
        #endregion

        #region methods

        public ForfaitSkiSaison(string nom, string prenom, DateTime dateNaiss, string adRue,string cp, string adVil) : base (nom,prenom,dateDebutSaison,dateFinSaison,dateNaiss)
        {
           
        }

        /// <summary>
        /// calcul du montant total à payer par le client 
        /// </summary>
        /// <returns></returns>
        public new int  calculTarif()
        {
            int tarifAPayer = Convert.ToInt32(this.donneTarifUnJour() * this.donnNbjours());

            return tarifAPayer;
        }
        /// <summary>
        /// renvoi une string contenant la totalité des informations de l'objet ForfaitSkiSaison
        /// </summary>
        /// <returns></returns>
         public new string ToString() 
        {
            string laChaine;

            laChaine = "";
            
           

            return laChaine;
        }



        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4_Parametres_CalculRemu
{
    public class Commercial
    {
        #region attributes
        private string nom;
        private double[] chiffreDAffaires = new double[12];
        private DateTime dateEmbauche;
        #endregion

        #region methods        

        public Commercial(string nom, DateTime dateDEmbauche)
        {
            this.nom = nom;
            this.dateEmbauche =  dateDEmbauche;
        }

        public void setDateEmbauche(DateTime d)
        {
            this.dateEmbauche = d;
        }

        public DateTime getDateEmbauche()
        {
            return this.dateEmbauche;
        }

        /// <summary>
        /// Méthode qui permet de définir le chiffre d'affaire effectué par le commercial au cours du mois définit spécifié
        /// </summary>
        /// <param name="mois"></param>
        /// <param name="ca"></param>
        public void setCA(int mois, double ca)
        {
            this.chiffreDAffaires[mois] = ca;
        }

        public double donneCaMois(int mois)
        {
            return this.chiffreDAffaires[mois];
        }
        public string getNom()
        {
            return this.nom;
        }
         public static void appelCALCULREMU(int mois, double salaireFix, List<Commercial> lesCommerciaux) // passée en public pour effectuer les test unitaires
        {
            double totalBrut = 0;
            double prime = 0;
            double commission = 0;
            double caMois = 0;

            foreach (Commercial c in lesCommerciaux)
            {
                calculPrime(c.donneAnciennete(), ref prime);
                caMois = c.donneCaMois(mois);
                commission = calculCommission(ref caMois);

                Console.WriteLine("La rémunération mensuelle brute de" + c.getNom() + " est de " + calculBrut(salaireFix, commission,prime));
            }
            Console.WriteLine("Le total des rémunérations du mois est de " + totalBrut);
        }
        public static int calculBrut(double salfixe, double mtcom, double mtprime)
        {
            int mtbrut;
            mtbrut = Convert.ToInt32(salfixe + mtcom + mtprime);
            return mtbrut;
        }
        public static void calculPrime(int nb_anciennete, ref double prime_accordee)
        {
            if (nb_anciennete < 2)
                prime_accordee = 0;
            else
            {
                if (nb_anciennete < 10)
                    prime_accordee = 23 * nb_anciennete;
                else prime_accordee = 30 * nb_anciennete;
            }
        }
        public static double calculCommission(ref double chiffre_affaires)
        {
            double com;

            if (chiffre_affaires <= 200000)
                com = chiffre_affaires * 0.02;
            else
            {
                if (chiffre_affaires <= 400000 && chiffre_affaires >= 200000)
                    com = 4000 + (chiffre_affaires - 200000) * 0.03;
                else
                {
                    if (chiffre_affaires <= 500000 && chiffre_affaires >= 400000)
                        com = 10000 + (chiffre_affaires - 400000) * 0.04;
                    else
                        com = 14000 + (chiffre_affaires - 500000) * 0.06;
                }
            }

            return com;
        }

        /// <summary>
        /// Méthode perettant de définir l'ancienneté du commercial au sein de l'entreprise en fonction de sa date de naissance et sa date d'embauche, l'ancienneté n'est incrémentée de 1 que si la date d'anniversaire est inférieure à la date actuelle.
        /// </summary>
        /// <returns></returns>
        public int donneAnciennete()
        {
            int anciennete;
            anciennete = DateTime.Today.Year - this.dateEmbauche.Year;
            DateTime dateAnniv;
            dateAnniv = new DateTime(DateTime.Today.Year, this.dateEmbauche.Month, this.dateEmbauche.Day);
            if (dateAnniv > DateTime.Today)
            {
                anciennete--;
            } 
            return anciennete; ;
        }
        #endregion




    }
}




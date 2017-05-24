using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercice4_Parametres_CalculRemu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4_Parametres_CalculRemu.Tests
{

    [TestClass()]
    public class CommercialTests
    {
        public Commercial[] TableauCommerciaux()
        {
            Commercial[] jeuxDEssai;
            Commercial Commercial_1 = new Commercial("jonathan", new DateTime(2016, 1, 1));
            Commercial Commercial_2 = new Commercial("marie", new DateTime(2016, 3, 2));
            Commercial Commercial_3 = new Commercial("julien", new DateTime(2016, 5, 3));
            Commercial Commercial_4 = new Commercial("benoit", new DateTime(2016, 7, 4));
            Commercial Commercial_5 = new Commercial("ph", new DateTime(2016, 9, 5));
            Commercial Commercial_6 = new Commercial("adri", new DateTime(2011, 10, 6));
            Commercial Commercial_7 = new Commercial("alex", new DateTime(2000, 12, 7));

            jeuxDEssai = new Commercial[] { Commercial_1, Commercial_2, Commercial_3, Commercial_4, Commercial_5, Commercial_6, Commercial_7 };

            return jeuxDEssai;
        }


        [TestMethod()]
        public void setDateEmbaucheTest()
        {
            Commercial[] jeuxDEssai = TableauCommerciaux();

            Commercial unCommercial = jeuxDEssai[2];
            unCommercial.setDateEmbauche(new DateTime(2016, 4, 5));

            DateTime dateAttendue = new DateTime(2016, 4, 5);
            DateTime dateEmbaucheCommercial = unCommercial.getDateEmbauche();
            Assert.AreEqual(dateAttendue, dateEmbaucheCommercial);
        }

        [TestMethod()]
        public void setCATest()
        {
            Commercial[] jeuxDEssai = TableauCommerciaux();
            Commercial unCommercial = jeuxDEssai[3];
            unCommercial.setCA(2, 50000);

            double ca_Attendu = 50000;
            double ca_Commercial = unCommercial.donneCaMois(2);
            Assert.AreEqual(ca_Attendu, ca_Commercial);
        }

        [TestMethod()]
        public void donneCaMoisTest()
        {
            Commercial[] jeuxDEssai = TableauCommerciaux();
            Commercial unCommercial = jeuxDEssai[4];

            unCommercial.setCA(3, 50000);
            double ca_commercial = unCommercial.donneCaMois(3);
            double ca_commercial_attendu = 50000;
            Assert.AreEqual(ca_commercial_attendu, ca_commercial);
        }

        [TestMethod()]
        public void getNomTest()
        {
            Commercial[] jeuxDEssai = TableauCommerciaux();
            Commercial unCommercial = jeuxDEssai[4];

            string leNom = unCommercial.getNom();
            string leNomAttendu = "ph";

            Assert.AreEqual(leNomAttendu, leNom);
        }

        [TestMethod()]
        public void calculBrutTest()
        {
            int resultat_attendu = 30000;
            int salaireBrut = Exercice4_Parametres_CalculRemu.Commercial.calculBrut(10000, 10000, 10000);
            Assert.AreEqual(resultat_attendu, salaireBrut);
        }

        [TestMethod()]
        public void calculPrimeTest()
        {
            Commercial[] jeuxDEssai = TableauCommerciaux();
            Commercial unCommercial1 = jeuxDEssai[4];
            Commercial unCommercial2 = jeuxDEssai[5];
            Commercial unCommercial3 = jeuxDEssai[6];

            int anciennete_commercial1 = unCommercial1.donneAnciennete();
            int anciennete_commercial2 = unCommercial2.donneAnciennete();
            int anciennete_commercial3 = unCommercial3.donneAnciennete();

            double prime_accordee_attendue_commercial1 = 0;
            double prime_accordee_commercial1 = 0;

            double prime_accordee_attendue_commercial2 = 92;
            double prime_accordee_commercial2 = 0;

            double prime_accordee_attendue_commercial3 = 450;
            double prime_accordee_commercial3 = 0;

            Exercice4_Parametres_CalculRemu.Commercial.calculPrime(anciennete_commercial1, ref prime_accordee_commercial1);
            Exercice4_Parametres_CalculRemu.Commercial.calculPrime(anciennete_commercial2, ref prime_accordee_commercial2);
            Exercice4_Parametres_CalculRemu.Commercial.calculPrime(anciennete_commercial3, ref prime_accordee_commercial3);


            Assert.AreEqual(prime_accordee_attendue_commercial1, prime_accordee_commercial1);
            Assert.AreEqual(prime_accordee_attendue_commercial2, prime_accordee_commercial2);
            Assert.AreEqual(prime_accordee_attendue_commercial3, prime_accordee_commercial3);
        }

        [TestMethod()]
        public void calculCommissionTest()
        {
            Commercial[] jeuxDEssai = TableauCommerciaux();
            Commercial unCommercial1 = jeuxDEssai[2];
            Commercial unCommercial2 = jeuxDEssai[3];
            Commercial unCommercial3 = jeuxDEssai[4];
            Commercial unCommercial4 = jeuxDEssai[4];

            unCommercial1.setCA(2, 100000);
            unCommercial2.setCA(3, 300000);
            unCommercial3.setCA(4, 450000);
            unCommercial4.setCA(5, 1000000);

            double ca_du_mois_commercial1 = unCommercial1.donneCaMois(2);
            double ca_du_mois_commercial2 = unCommercial2.donneCaMois(3);
            double ca_du_mois_commercial3 = unCommercial3.donneCaMois(4);
            double ca_du_mois_commercial4 = unCommercial4.donneCaMois(5);


            double commission_Attendue_Commercial1 = 2000;
            double commission_commercial1 = Exercice4_Parametres_CalculRemu.Commercial.calculCommission(ref ca_du_mois_commercial1);

            double commission_Attendue_Commercial2 = 7000;
            double commission_commercial2 = Exercice4_Parametres_CalculRemu.Commercial.calculCommission(ref ca_du_mois_commercial2);

            double commission_Attendue_Commercial3 = 12000;
            double commission_commercial3 = Exercice4_Parametres_CalculRemu.Commercial.calculCommission(ref ca_du_mois_commercial3);

            double commission_Attendue_Commercial4 = 44000;
            double commission_commercial4 = Exercice4_Parametres_CalculRemu.Commercial.calculCommission(ref ca_du_mois_commercial4);

            Assert.AreEqual(commission_Attendue_Commercial1, commission_commercial1);
            Assert.AreEqual(commission_Attendue_Commercial2, commission_commercial2);
            Assert.AreEqual(commission_Attendue_Commercial3, commission_commercial3);
            Assert.AreEqual(commission_Attendue_Commercial4, commission_commercial4);
        }

        [TestMethod()]
        public void donneAncienneteTest()
        {
            Commercial[] jeuxDEssai = TableauCommerciaux();
            Commercial unCommercial = jeuxDEssai[6];
            int anciennete_attendue = 15;
            int anciennete = unCommercial.donneAnciennete();

            Assert.AreEqual(anciennete_attendue, anciennete);
        }

        //[TestMethod()]
        //public void appelCALCULREMUTest()
        //{
        //    Commercial[] jeuxDEssai = TableauCommerciaux();
        //    Commercial unCommercial = jeuxDEssai[5];
        //    unCommercial.setCA(2, 100000);
        //    List<Commercial> liste_de_commerciaux = jeuxDEssai.Cast<Commercial>().ToList();
        //    Exercice4_Parametres_CalculRemu.Commercial.appelCALCULREMU(2, 3200, liste_de_commerciaux);

        //}
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForfaitSki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForfaitSki;

namespace ForfaitSki.Tests
{
    [TestClass()]
    public class ForfaitSkiTests
    {
        ForfaitSki unForfait = new ForfaitSki("guittard", "jonathan", new DateTime(2016, 01, 01), new DateTime(2016, 02, 01), new DateTime(1993, 10, 14));
        ForfaitSki deuxForfait = new ForfaitSki("eniona", "guillaume", new DateTime(2016, 01, 01), new DateTime(2016, 02, 01), new DateTime(1993, 10, 14));

        [TestMethod()]
        public void setNomTest()
        {
            string resultatAttendu = "DEPARDIEU";

            unForfait.setNom("DEPARDIEU");

            string resultatObtenu = unForfait.getNom();

            Assert.AreEqual(resultatAttendu, resultatObtenu);
        }

        [TestMethod()]
        public void getNomTest()
        {
            string resultatAttendu = "LePACMAN";
            unForfait.setNom("LePACMAN");
            string resultatObtenu = unForfait.getNom();
            Assert.AreEqual(resultatAttendu, resultatObtenu);
        }

        [TestMethod()]
        public void setPrenomTest()
        {
            string resultatAttendu = "Jean-Eude";
            unForfait.setPrenom("Jean-Eude");
            string resultatObtenu = unForfait.Prenom;
            Assert.AreEqual(resultatAttendu, resultatObtenu);
        }

        [TestMethod()]
        public void augmenteDernierNumTest()
        {
            int leNumeroAttendu = 1;
            int leNumeroObtenu = unForfait.Numero;

            Assert.AreEqual(leNumeroAttendu, leNumeroObtenu);
        }

        [TestMethod()]
        public void donnNbjoursTest()
        {
            int nbreJours = unForfait.donnNbjours();
            int resultatAttendu = 31;
            Assert.AreEqual(resultatAttendu, nbreJours);
        }

        [TestMethod()]
        public void donneAgeTest()
        {
            int ageAttendu = 22;

            int ageObtenu  = unForfait.donneAge();

            Assert.AreEqual(ageAttendu, ageObtenu);
        }
    }
}
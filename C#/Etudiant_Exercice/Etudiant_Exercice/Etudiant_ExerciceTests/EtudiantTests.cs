using Microsoft.VisualStudio.TestTools.UnitTesting;
using Etudiant_Exercice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etudiant_Exercice.Tests
{
    [TestClass()]
    public class EtudiantTests
    {
        private TestContext m_testContext;

        //Data
        public TestContext TestContext
        {
            get { return m_testContext; }
            set { m_testContext = value; }
        }
        Etudiant unEtudiant = new Etudiant("jonathan", 7);

        [TestMethod()]
        public void donneMentionTestAjourne()
        {


            string mentionAttendue = "ajourné";
            string mention = unEtudiant.donneMention();

            Assert.AreEqual(mentionAttendue, mention);
        }

        [TestMethod()]
        public void donneMentionTestOral()
        {
            Etudiant unEtudiant = new Etudiant("jonathan", 9);

            string mentionAttendue = "oral";
            string mention = unEtudiant.donneMention();

            Assert.AreEqual(mentionAttendue, mention);
        }

        [TestMethod()]
        public void donneMentionTestPassable()
        {
            Etudiant unEtudiant = new Etudiant("jonathan", 11);

            string mentionAttendue = "passable";
            string mention = unEtudiant.donneMention();

            Assert.AreEqual(mentionAttendue, mention);
        }

        [TestMethod()]
        public void donneMentionTestBien()
        {
            Etudiant unEtudiant = new Etudiant("jonathan", 15);

            string mentionAttendue = "bien";
            string mention = unEtudiant.donneMention();

            Assert.AreEqual(mentionAttendue, mention);
        }

        [TestMethod()]
        public void donneMentionTestTresBien()
        {
            Etudiant unEtudiant = new Etudiant("jonathan", 18);

            string mentionAttendue = "très bien";
            string mention = unEtudiant.donneMention();

            Assert.AreEqual(mentionAttendue, mention);
        }

        [TestMethod()]
        public void EtudiantTestNoteBac()
        {
            double note = (unEtudiant.NoteDuBac);
            double noteAttendue = 7;

            Assert.AreEqual(noteAttendue, note);
        }

        [TestMethod()]
        public void EtudiantTestCreationObjet()
        {
            Etudiant etudiantAttendu = new Etudiant("jonathan", 7);

            string etudiantAttenduString = etudiantAttendu.Nom + Convert.ToString(etudiantAttendu.NoteDuBac);
            string etudiantString = unEtudiant.Nom + Convert.ToString(unEtudiant.NoteDuBac);

            Assert.AreEqual(etudiantAttenduString, etudiantString);
        }


        [TestMethod()]
        public void EtudiantNoteDuBacTest()
        {
            Etudiant etudiant = new Etudiant("jonathan", 7);
            etudiant.NoteDuBac = 15;
            double noteAttendu = 15;
            double noteEtudiant = etudiant.NoteDuBac;


            Assert.AreEqual(noteAttendu,noteEtudiant);
        }


        [TestMethod()]
        public void EtudiantNomTest()
        {
            Etudiant etudiant = new Etudiant("jonathan", 7);
            etudiant.Nom = "gerard";
            string leNom_attendu = "gerard";
            string leNom_etudiant = etudiant.Nom;


            Assert.AreEqual(leNom_attendu, leNom_etudiant);
        }

    }
}
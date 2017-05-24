using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cas_Thali;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas_Thali.Tests
{
    [TestClass()]
    public class EtapeTests
    {
        static Etape uneEtape = new Etape(1,"une Description",10);
        [TestMethod()]
        public void EtapeTest()
        {

        }

        [TestMethod()]
        public void donneDureePrevueHHMMTest()
        {

        }

        [TestMethod()]
        public void getNumEtapeTest()
        {
            uint numEtapeAttendu = 1;
            uint numEtapeObtenu = uneEtape.getNumEtape();

            Assert.AreEqual(numEtapeAttendu,numEtapeObtenu);
        }

        [TestMethod()]
        public void getDureeEtapeTest()
        {

        }
    }
}
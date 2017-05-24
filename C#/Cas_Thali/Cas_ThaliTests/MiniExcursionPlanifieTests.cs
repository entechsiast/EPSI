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
    public class MiniExcursionPlanifieTests
    {
        static MiniExcursion uneMiniExcursion = new MiniExcursion(1,"une libelle",5);
        static  MiniExcursionPlanifie unExcursionPlanifie = new MiniExcursionPlanifie(uneMiniExcursion,new TimeSpan(12,00,00));
        [TestMethod()]
        public void MiniExcursionPlanifieTest()
        {

        }

        [TestMethod()]
        public void estCompleteTest()
        {

        }
    }
}
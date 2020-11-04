using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CentralitaInstanciada()
        {
            //Arrenge
            Centralita c = new Centralita();

            //Assert
            Assert.IsNotNull(c);
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void IguLlamadaLocal()
        {
            //Arrenge
            Centralita c = new Centralita();
            Local l1 = new Local("Hola", 23, "Chau", 23);
            Local l2 = new Local("Hola", 12, "Chau", 34);

            //Act
            c += l1;
            c += l2;
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void IguLlamadaProvincial()
        {
            //Arrenge
            Centralita c = new Centralita();
            Provincial p1 = new Provincial("Hola", Provincial.Franja.Franja_1, 12, "Chau"); 
            Provincial p2 = new Provincial("Hola", Provincial.Franja.Franja_3, 13, "Chau");

            //Act
            c += p1;
            c += p2;
        }

        [TestMethod]
        public void CompararLlamadas()
        {
            //Arrenge
            Local l1 = new Local("Hola", 23, "Chau", 23);
            Local l2 = new Local("Hola", 12, "Chau", 34);
            Provincial p1 = new Provincial("Hola", Provincial.Franja.Franja_1, 12, "Chau");
            Provincial p2 = new Provincial("Hola", Provincial.Franja.Franja_3, 13, "Chau");

            //Assert
            Assert.IsTrue(comparar(l1,l2,p1,p2));
            /*Assert.AreNotEqual(p1, l1);
            Assert.AreNotEqual(p1, l2);
            Assert.AreEqual(p1, p2);
            Assert.AreNotEqual(p2, l1);
            Assert.AreNotEqual(p2, l2);
            Assert.AreEqual(l1, l2);*/
        }

        private bool comparar(Local l1, Local l2, Provincial p1, Provincial p2)
        {
            if (l1 == l2 && l1 != p1 && l1 != p2 &&
                l2 != p1 && l2 != p2
                && p1 == p2)
            {
                return true;
            }


            return false;
        }
    }
}

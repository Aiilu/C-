using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void ProbarMetodoEstat()
        {
            //Act
            MiClase.MetodEstat();
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void ProbarConstructorUno()
        {
            //Act
            MiClase clase = new MiClase();
        }

        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void ProbarConstructorDos()
        {
            //Arrange
            int i = 2;

            //Act
            MiClase clase = new MiClase(i);
        }

        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void ProbarConstructorTres()
        {
            //Act
            OtraClase clase = new OtraClase();
            clase.OtraClaseInstancia();
        }
    }
}

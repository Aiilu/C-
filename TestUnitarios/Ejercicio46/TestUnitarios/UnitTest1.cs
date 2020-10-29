using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanciaVehiculo()
        {
            //Arrange
            Competencia c = new Competencia(23, 12, Competencia.TipoCompetencia.F1);

            //Assert
            Assert.IsNotNull(c.DevListaComp);
        }

        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void CargarMotoEnF1()
        {
            //Arrange
            Competencia c = new Competencia(23, 12, Competencia.TipoCompetencia.F1);
            MotoCross m = new MotoCross(23, "Bebe", 23);

            //Act
            bool rpt = c + m;
        }

        [TestMethod]
        public void CargarMotoEnMoto()
        {
            //Arrange
            Competencia c = new Competencia(23, 12, Competencia.TipoCompetencia.MotoCross);
            MotoCross m = new MotoCross(23, "Bebe", 23);

            //Act
            Assert.IsTrue(c + m);
        }

        [TestMethod]
        public void FiguraEnLaLista()
        {
            //Arrange
            Competencia c = new Competencia(23, 12, Competencia.TipoCompetencia.MotoCross);
            MotoCross m = new MotoCross(23, "Bebe", 23);

            //Act
            bool rpt = c + m;

            //Assert
            Assert.IsTrue(c == m);
        }

        [TestMethod]
        public void NoFiguraEnLaLista()
        {
            //Arrange
            Competencia c = new Competencia(23, 12, Competencia.TipoCompetencia.MotoCross);
            MotoCross m = new MotoCross(23, "Bebe", 23);

            //Act
            bool rpt = c + m;
            rpt = c - m;

            //Assert
            Assert.IsTrue(c != m);
        }
    }
}

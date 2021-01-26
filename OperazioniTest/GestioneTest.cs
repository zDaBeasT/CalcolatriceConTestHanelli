using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operazioni;

namespace OperazioniTest
{
    [TestClass]
    public class GestioneTest
    {
        [TestMethod]
        public void TestSommaPositivi()
        {
            int a = 3;
            int b = 7;
            int somma_aspettata = 10;
            int somma_effettiva;
            somma_effettiva = Gestione.Somma(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }

        [TestMethod]
        public void TestSommaNulli()
        {
            int a = 0;
            int b = 0;
            int somma_aspettata = 0;
            int somma_effettiva;
            somma_effettiva = Gestione.Somma(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }

        [TestMethod]
        public void TestSommaNegativi()
        {
            int a = -3;
            int b = -2;
            int somma_aspettata = -5;
            int somma_effettiva;
            somma_effettiva = Gestione.Somma(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }

        [TestMethod]
        public void TestSommaMisto()
        {
            int a = -10;
            int b = 1;
            int somma_aspettata = -9;
            int somma_effettiva;
            somma_effettiva = Gestione.Somma(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
    }
}

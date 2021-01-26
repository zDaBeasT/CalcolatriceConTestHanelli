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

        [TestMethod]
        public void TestDifferenzaPositivi()
        {
            int a = 9;
            int b = 7;
            int differenza_aspettata = 2;
            int differenza_effettiva;
            differenza_effettiva = Gestione.Differenza(a, b);
            Assert.AreEqual(differenza_aspettata, differenza_effettiva);
        }

        [TestMethod]
        public void TestSommaDecimalePositivi()
        {
            double a = 3.5;
            double b = 6.5;
            double somma_aspettata = 10;
            double somma_effettiva;
            somma_effettiva = Gestione.SommaDecimale(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }

        [TestMethod]
        public void TestProdottoPositivi()
        {
            int a = 3;
            int b = 5;
            int prodotto_aspettato = 15;
            int prodotto_effettivo;
            prodotto_effettivo = Gestione.Prodotto(a, b);
            Assert.AreEqual(prodotto_aspettato, prodotto_effettivo);
        }

        [TestMethod]
        public void TestQuozientePositivi()
        {
            int a = 10;
            int b = 2;
            int quoziente_aspettato = 5;
            int quoziente_effettivo;
            quoziente_effettivo = Gestione.Quoziente(a, b);
            Assert.AreEqual(quoziente_aspettato, quoziente_effettivo);
        }
    }
}

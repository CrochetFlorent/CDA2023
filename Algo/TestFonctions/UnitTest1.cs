namespace TestFonctions
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testMoyenne1()
        {
            double moyenne = FonctionsATester.Program.Moyenne(2, 5);
            Assert.AreEqual(moyenne, 3.5);
        }

        [TestMethod]
        public void testMoyenne2()
        {
            double moyenne2 = FonctionsATester.Program.Moyenne(-2, 5);
            Assert.AreEqual(moyenne2, 1.5);

        }

        [TestMethod]
        public void testPremier1()
        {
            bool premier2 = FonctionsATester.Program.Premier(2);
            Assert.IsTrue(premier2);
        }

        [TestMethod]
        public void testPremier2()
        {
            bool premier3 = FonctionsATester.Program.Premier(4);
            Assert.IsFalse(premier3);
        }

        [TestMethod]
        public void testPremier3()
        {
            bool premier4 = FonctionsATester.Program.Premier(7);
            Assert.IsTrue(premier4);

        }

        [TestMethod]
        public void testPremier4()
        {
            bool premier5 = FonctionsATester.Program.Premier(9);
            Assert.IsFalse(premier5);
        }


        [TestMethod]
        public void testBissextile()
        {
            bool annee = FonctionsATester.Program.Bissext(2000);
            Assert.IsTrue(annee);

        }

        [TestMethod]
        public void testBissextile2()
        {

            bool annee2 = FonctionsATester.Program.Bissext(2012);
            Assert.IsTrue(annee2);

        }

        [TestMethod]
        public void testBissextile3()
        {
            bool annee3 = FonctionsATester.Program.Bissext(1900);
            Assert.IsFalse(annee3);
        }

        [TestMethod]
        public void testBarnabe1()
        {
            int nbMagasins3 = FonctionsATester.Program.Barnabe(1);
            Assert.AreEqual(-1,nbMagasins3);
        }

        [TestMethod]
        public void testBarnabe2()
        {
            int nbMagasins5 = FonctionsATester.Program.Barnabe(2);
            Assert.AreEqual(1, nbMagasins5);
        }

        [TestMethod]
        public void testBarnabe3()
        {

            int nbMagasins6 = FonctionsATester.Program.Barnabe(3);
            Assert.AreEqual(2, nbMagasins6);
        }

        [TestMethod]
        public void testRechercheTableau1()
        {
            Boolean test1 = FonctionsATester.Program.RechercheTableau(5,new[] { 1, 2, 3, 4, 5, 6, 7 });
            Assert.IsTrue(test1);

        }

        [TestMethod]
        public void testRechercheTableau2()
        {

            Boolean test2 = FonctionsATester.Program.RechercheTableau(33, new[] { 1, 2, 3, 4, 5, 6, 7 });
            Assert.IsFalse(test2);
        }

        [TestMethod]
        public void testPalindrome1()
        {
            Boolean test1 = FonctionsATester.Program.Palindrome("lavval");
            Assert.IsTrue(test1);
        }

        [TestMethod]
        public void testPalindrome2()
        {
            Boolean test2 = FonctionsATester.Program.Palindrome("laval");
            Assert.IsTrue(test2);
        }

        [TestMethod]
        public void testPalindrome3()
        {
            Boolean test2 = FonctionsATester.Program.Palindrome("test");
            Assert.IsFalse(test2);
        }

        [TestMethod]
        public void testPalindrome4()
        {
            Boolean test2 = FonctionsATester.Program.Palindrome("");
            Assert.IsFalse(test2);
        }

        [TestMethod]
        public void testPalindrome5()
        {
            Boolean test2 = FonctionsATester.Program.Palindrome(" ");
            Assert.IsFalse(test2);
        }


    }
}
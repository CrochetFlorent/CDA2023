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
            double moyenne = FonctionsATester.Program.Moyenne(-2, 5);
            Assert.AreEqual(moyenne, 1.5);
        }

        [TestMethod]
        public void testPremier1()
        {
            bool premier = FonctionsATester.Program.Premier(2);
            Assert.IsTrue(premier);
        }

        [TestMethod]
        public void testPremier2()
        {
            bool premier = FonctionsATester.Program.Premier(4);
            Assert.IsFalse(premier);
        }

        [TestMethod]
        public void testPremier3()
        {
            bool premier = FonctionsATester.Program.Premier(7);
            Assert.IsTrue(premier);
        }

        [TestMethod]
        public void testPremier4()
        {
            bool premier = FonctionsATester.Program.Premier(9);
            Assert.IsFalse(premier);
        }

        [TestMethod]
        public void testBissextile1()
        {
            bool annee = FonctionsATester.Program.Bissext(2000);
            Assert.IsTrue(annee);
        }

        [TestMethod]
        public void testBissextile2()
        {
            bool annee = FonctionsATester.Program.Bissext(2012);
            Assert.IsTrue(annee);
        }

        [TestMethod]
        public void testBissextile3()
        {
            bool annee = FonctionsATester.Program.Bissext(1900);
            Assert.IsFalse(annee);
        }

        [TestMethod]
        public void testBarnabe1()
        {
            int nbMagasins = FonctionsATester.Program.Barnabe(1);
            Assert.AreEqual(-1,nbMagasins);
        }

        [TestMethod]
        public void testBarnabe2()
        {
            int nbMagasins = FonctionsATester.Program.Barnabe(2);
            Assert.AreEqual(1, nbMagasins);
        }

        [TestMethod]
        public void testBarnabe3()
        {
            int nbMagasins = FonctionsATester.Program.Barnabe(3);
            Assert.AreEqual(2, nbMagasins);
        }

        [TestMethod]
        public void testRechercheTableau1()
        {
            Boolean test = FonctionsATester.Program.RechercheTableau(5,new[] { 1, 2, 3, 4, 5, 6, 7 });
            Assert.IsTrue(test);
        }

        [TestMethod]
        public void testRechercheTableau2()
        {
            Boolean test = FonctionsATester.Program.RechercheTableau(33, new[] { 1, 2, 3, 4, 5, 6, 7 });
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void testPalindrome1()
        {
            Boolean test = FonctionsATester.Program.Palindrome("lavval");
            Assert.IsTrue(test);
        }

        [TestMethod]
        public void testPalindrome2()
        {
            Boolean test = FonctionsATester.Program.Palindrome("laval");
            Assert.IsTrue(test);
        }

        [TestMethod]
        public void testPalindrome3()
        {
            Boolean test = FonctionsATester.Program.Palindrome("test");
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void testPalindrome4()
        {
            Boolean test = FonctionsATester.Program.Palindrome("");
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void testPalindrome5()
        {
            Boolean test = FonctionsATester.Program.Palindrome(" ");
            Assert.IsFalse(test);
        }
        [TestMethod]
        public void testPalindrome21()
        {
            Boolean test = FonctionsATester.Program.Palindrome2("lavval");
            Assert.IsTrue(test);
        }

        [TestMethod]
        public void testPalindrome22()
        {
            Boolean test = FonctionsATester.Program.Palindrome2("laval");
            Assert.IsTrue(test);
        }

        [TestMethod]
        public void testPalindrome23()
        {
            Boolean test = FonctionsATester.Program.Palindrome2("test");
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void testPalindrome24()
        {
            Boolean test = FonctionsATester.Program.Palindrome2("");
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void testPalindrome25()
        {
            Boolean test = FonctionsATester.Program.Palindrome2(" ");
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void testChifumi1()
        {
            String winner = FonctionsATester.Program.Chifumi("p", "p");
            Assert.AreEqual(winner,"egalite");
        }
        [TestMethod]
        public void testChifumi2()
        {
            String winner = FonctionsATester.Program.Chifumi("p", "f");
            Assert.AreEqual(winner, "joueur2");
        }

        [TestMethod]
        public void testChifumi3()
        {
            String winner = FonctionsATester.Program.Chifumi("p", "c");
            Assert.AreEqual(winner, "joueur1");
        }

        [TestMethod]
        public void testChifumi4()
        {
            String winner = FonctionsATester.Program.Chifumi("f", "p");
            Assert.AreEqual(winner, "joueur1");
        }
        [TestMethod]
        public void testChifumi5()
        {
            String winner = FonctionsATester.Program.Chifumi("f", "f");
            Assert.AreEqual(winner, "egalite");
        }

        [TestMethod]
        public void testChifumi6()
        {
            String winner = FonctionsATester.Program.Chifumi("f", "c");
            Assert.AreEqual(winner, "joueur2");
        }

        [TestMethod]
        public void testChifumi7()
        {
            String winner = FonctionsATester.Program.Chifumi("c", "c");
            Assert.AreEqual(winner, "egalite");
        }

        [TestMethod]
        public void testChifumi8()
        {
            String winner = FonctionsATester.Program.Chifumi("c", "f");
            Assert.AreEqual(winner, "joueur1");
        }

        [TestMethod]
        public void testChifumi9()
        {
            String winner = FonctionsATester.Program.Chifumi("c", "p");
            Assert.AreEqual(winner, "joueur2");
        }
    }
}
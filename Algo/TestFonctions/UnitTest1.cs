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
            bool estPremier = FonctionsATester.Program.Premier(2);
            Assert.IsTrue(estPremier);
        }

        [TestMethod]
        public void testPremier2()
        {
            bool estPremier = FonctionsATester.Program.Premier(4);
            Assert.IsFalse(estPremier);
        }

        [TestMethod]
        public void testPremier3()
        {
            bool estPremier = FonctionsATester.Program.Premier(7);
            Assert.IsTrue(estPremier);
        }

        [TestMethod]
        public void testPremier4()
        {
            bool estPremier = FonctionsATester.Program.Premier(9);
            Assert.IsFalse(estPremier);
        }

        [TestMethod]
        public void testBissextile1()
        {
            bool estBissextile = FonctionsATester.Program.Bissextile(2000);
            Assert.IsTrue(estBissextile);
        }

        [TestMethod]
        public void testBissextile2()
        {
            bool estBissextile = FonctionsATester.Program.Bissextile(2012);
            Assert.IsTrue(estBissextile);
        }

        [TestMethod]
        public void testBissextile3()
        {
            bool estBissextile = FonctionsATester.Program.Bissextile(1900);
            Assert.IsFalse(estBissextile);
        }

        [TestMethod]
        public void testBarnabe1()
        {
            int nombreDeMagasins = FonctionsATester.Program.Barnabe(1);
            Assert.AreEqual(-1, nombreDeMagasins);
        }

        [TestMethod]
        public void testBarnabe2()
        {
            int nombreDeMagasins = FonctionsATester.Program.Barnabe(2);
            Assert.AreEqual(1, nombreDeMagasins);
        }

        [TestMethod]
        public void testBarnabe3()
        {
            int nombreDeMagasins = FonctionsATester.Program.Barnabe(3);
            Assert.AreEqual(2, nombreDeMagasins);
        }

        [TestMethod]
        public void testRechercheTableau1()
        {
            Boolean estDansLeTableau = FonctionsATester.Program.RechercheTableau(5,new[] { 1, 2, 3, 4, 5, 6, 7 });
            Assert.IsTrue(estDansLeTableau);
        }

        [TestMethod]
        public void testRechercheTableau2()
        {
            Boolean estDansLeTablea = FonctionsATester.Program.RechercheTableau(33, new[] { 1, 2, 3, 4, 5, 6, 7 });
            Assert.IsFalse(estDansLeTablea);
        }

        [TestMethod]
        public void testPalindrome1()
        {
            Boolean estUnPalindrome = FonctionsATester.Program.Palindrome("lavval");
            Assert.IsTrue(estUnPalindrome);
        }

        [TestMethod]
        public void testPalindrome2()
        {
            Boolean estUnPalindrome = FonctionsATester.Program.Palindrome("laval");
            Assert.IsTrue(estUnPalindrome);
        }

        [TestMethod]
        public void testPalindrome3()
        {
            Boolean estUnPalindrome = FonctionsATester.Program.Palindrome("test");
            Assert.IsFalse(estUnPalindrome);
        }

        [TestMethod]
        public void testPalindrome4()
        {
            Boolean estUnPalindrome = FonctionsATester.Program.Palindrome("");
            Assert.IsFalse(estUnPalindrome);
        }

        [TestMethod]
        public void testPalindrome5()
        {
            Boolean estUnPalindrome = FonctionsATester.Program.Palindrome(" ");
            Assert.IsFalse(estUnPalindrome);
        }
        [TestMethod]
        public void testPalindrome21()
        {
            Boolean estUnPalindrome = FonctionsATester.Program.Palindrome2("lavval");
            Assert.IsTrue(estUnPalindrome);
        }

        [TestMethod]
        public void testPalindrome22()
        {
            Boolean estUnPalindrome = FonctionsATester.Program.Palindrome2("laval");
            Assert.IsTrue(estUnPalindrome);
        }

        [TestMethod]
        public void testPalindrome23()
        {
            Boolean estUnPalindrome = FonctionsATester.Program.Palindrome2("test");
            Assert.IsFalse(estUnPalindrome);
        }

        [TestMethod]
        public void testPalindrome24()
        {
            Boolean estUnPalindrome = FonctionsATester.Program.Palindrome2("");
            Assert.IsFalse(estUnPalindrome);
        }

        [TestMethod]
        public void testPalindrome25()
        {
            Boolean estUnPalindrome = FonctionsATester.Program.Palindrome2(" ");
            Assert.IsFalse(estUnPalindrome);
        }

        [TestMethod]
        public void testChifumi1()
        {
            String gagnant = FonctionsATester.Program.Chifumi("p", "p");
            Assert.AreEqual(gagnant, "egalite");
        }
        [TestMethod]
        public void testChifumi2()
        {
            String gagnant = FonctionsATester.Program.Chifumi("p", "f");
            Assert.AreEqual(gagnant, "joueur2");
        }

        [TestMethod]
        public void testChifumi3()
        {
            String gagnant = FonctionsATester.Program.Chifumi("p", "c");
            Assert.AreEqual(gagnant, "joueur1");
        }

        [TestMethod]
        public void testChifumi4()
        {
            String gagnant = FonctionsATester.Program.Chifumi("f", "p");
            Assert.AreEqual(gagnant, "joueur1");
        }
        [TestMethod]
        public void testChifumi5()
        {
            String gagnant = FonctionsATester.Program.Chifumi("f", "f");
            Assert.AreEqual(gagnant, "egalite");
        }

        [TestMethod]
        public void testChifumi6()
        {
            String gagnant = FonctionsATester.Program.Chifumi("f", "c");
            Assert.AreEqual(gagnant, "joueur2");
        }

        [TestMethod]
        public void testChifumi7()
        {
            String gagnant = FonctionsATester.Program.Chifumi("c", "c");
            Assert.AreEqual(gagnant, "egalite");
        }

        [TestMethod]
        public void testChifumi8()
        {
            String gagnant = FonctionsATester.Program.Chifumi("c", "f");
            Assert.AreEqual(gagnant, "joueur1");
        }

        [TestMethod]
        public void testChifumi9()
        {
            String gagnant = FonctionsATester.Program.Chifumi("c", "p");
            Assert.AreEqual(gagnant, "joueur2");
        }

        [TestMethod]
        public void testYaourts()
        {
            string couleurLaPlusRepresentee, secondeCouleur;
            FonctionsATester.Program.Yaourts(new[] { "Jaune","Jaune", "Bleu", "Jaune", "Rouge","Vert", "Vert", "Vert", "Orange", "Vert","Rouge" },out couleurLaPlusRepresentee, out secondeCouleur);
            Assert.AreEqual("Vert", couleurLaPlusRepresentee);
            Assert.AreEqual("Jaune", secondeCouleur);
        }


        [TestMethod]
        public void testRetourTableau1()
        {
            int nombrePresent1, nombrePresent2;
            FonctionsATester.Program.RetourTableau(new[] { 1, 2, 2, 4, 6, 6, 7, 8, 9, 10 },2,6,out nombrePresent1,out nombrePresent2);
            Assert.AreEqual(2, nombrePresent1);
            Assert.AreEqual(2, nombrePresent2);
        }

        [TestMethod]
        public void testRetourTableau2()
        {
            int nombrePresent1, nombrePresent2;
            FonctionsATester.Program.RetourTableau(new[] { 1, 2, 2, 4, 6, 6, 7, 8, 9, 10 }, 1, 6, out nombrePresent1, out nombrePresent2);
            Assert.AreEqual(1, nombrePresent1);
            Assert.AreEqual(2, nombrePresent2);
        }

        [TestMethod]
        public void testRetourTableau3()
        {
            int nombrePresent1, nombrePresent2;
            FonctionsATester.Program.RetourTableau(new[] { 1, 2, 2, 4, 6, 6, 7, 8, 9, 10 }, 2, 7, out nombrePresent1, out nombrePresent2);
            Assert.AreEqual(2, nombrePresent1);
            Assert.AreEqual(1, nombrePresent2);
        }

        [TestMethod]
        public void testRetourTableau4()
        {
            int nombrePresent1, nombrePresent2;
            FonctionsATester.Program.RetourTableau(new[] { 1, 2, 2, 4, 6, 6, 7, 8, 9, 10 }, 9, 10, out nombrePresent1, out nombrePresent2);
            Assert.AreEqual(1, nombrePresent1);
            Assert.AreEqual(1, nombrePresent2);
        }

        [TestMethod]
        public void testRetourTableau5()
        {
            int nombrePresent1, nombrePresent2;
            FonctionsATester.Program.RetourTableau(new int[0], 9, 10, out nombrePresent1, out nombrePresent2);
            Assert.AreEqual(0, nombrePresent1);
            Assert.AreEqual(0, nombrePresent2);
        }

    }
}

/**************************************************************************
 *                                                                        *
 *  File:        UnitTest1.cs                                             *
 *  Copyright:   (c) 2008, Ingineria Programarii Proiect                  *
 *  Description: Proiect la materia "Ingineria Programarii"               *
 *               ce contine chestionare de cultura generala               *
 *               din diverse domenii.                                     *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProiectIP;
namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        //daca se da ca raspunsuri corecte valoarea de 0, ar trebui ca rezultatul sa dea 0
        [TestMethod]
        public void TestScor_0()
        {
            ProiectIP.Calculeaza c = new ProiectIP.Calculeaza(0, 64m);
            Assert.IsTrue(c.Valid);
            Assert.AreEqual(0, c.Rezultat);
        }

        //dacă se încearcă calcularea unui scor negativ, ar trebui ca flag-ul clasei să fie false pentru a semnala această problemă
        [TestMethod]
        public void TestScor_minus5()
        {
            ProiectIP.Calculeaza c = new ProiectIP.Calculeaza(-5, 64m);
            Assert.IsFalse(c.Valid);
        }
        //dacă se încearcă calcularea unui scor negativ, ar trebui ca flag-ul clasei să fie false pentru a semnala această problemă
        [TestMethod]
        public void TestScor_minusminus()
        {
            ProiectIP.Calculeaza c = new ProiectIP.Calculeaza(-5, -5);
            Assert.IsFalse(c.Valid);
        }
        //dacă se încearcă calcularea unui scor nul, ar trebui ca flag-ul clasei să fie false pentru a semnala această problemă
        [TestMethod]
        public void TestScor_zero()
        {
            ProiectIP.Calculeaza c = new ProiectIP.Calculeaza(0, 0);
            Assert.IsFalse(c.Valid);
        }
        //acest calcul ar trebui sa fie facut corect
        [TestMethod]
        public void TestScor_calcul()
        {
            ProiectIP.Calculeaza c = new ProiectIP.Calculeaza(4, 2);
            Assert.IsTrue(c.Valid);
            Assert.AreEqual(200, c.Rezultat);
        }

        //calculul anului in cazul asta ar trebui sa fie corect
        [TestMethod]
        public void TestCalculVarsta_varsta()
        {
            ProiectIP.CalculeazaVarsta c = new ProiectIP.CalculeazaVarsta(2000);
            Assert.IsTrue(c.Valid);
            Assert.AreEqual(22, c.Rezultat);
        }

        //dacă se introduce un an care nu există în câmpul de an, ar trebui ca flag-ul din clasa CalculeazaVarsta să fie false astfel încât să indice această eroare
        [TestMethod]
        public void TestCalculVarsta_minus()
        {
            ProiectIP.CalculeazaVarsta c = new ProiectIP.CalculeazaVarsta(-2000);
            Assert.IsFalse(c.Valid);
        }
        //dacă se introduce un an care nu există în câmpul de an(utilizatorul are mai putin de 16 ani), ar trebui ca flag-ul din clasa CalculeazaVarsta să fie false astfel încât să indice această eroare
        [TestMethod]
        public void TestCalculVarsta_maiMicCa16()
        {
            ProiectIP.CalculeazaVarsta c = new ProiectIP.CalculeazaVarsta(2020);
            Assert.IsFalse(c.Valid);
        }
        //dacă se introduce un an mai mare decat anul curent în câmpul de an(utilizatorul are mai mult de 100 de ani), ar trebui ca flag-ul din clasa CalculeazaVarsta să fie false astfel încât să indice această eroare
        [TestMethod]
        public void TestCalculVarsta_anViitor()
        {
            ProiectIP.CalculeazaVarsta c = new ProiectIP.CalculeazaVarsta(2080);
            Assert.IsFalse(c.Valid);
        }
        //se testeaza daca utilizatorul are 100 de ani, limita superioara
        [TestMethod]
        public void TestCalculVarsta_1922()
        {
            ProiectIP.CalculeazaVarsta c = new ProiectIP.CalculeazaVarsta(1922);
            Assert.IsTrue(c.Valid);
            Assert.AreEqual(100, c.Rezultat);
        }
        //ar trebui sa dea false daca acesta are 101 de ani
        [TestMethod]
        public void TestCalculVarsta_1921()
        {
            ProiectIP.CalculeazaVarsta c = new ProiectIP.CalculeazaVarsta(1921);
            Assert.IsFalse(c.Valid);
        }
        //dacă se introduce un an care nu există în câmpul de an(utilizatorul are mai mult de 100 de ani), ar trebui ca flag-ul din clasa CalculeazaVarsta să fie false astfel încât să indice această eroare
        [TestMethod]
        public void TestCalculVarsta_zero()
        {
            ProiectIP.CalculeazaVarsta c = new ProiectIP.CalculeazaVarsta(0);
            Assert.IsFalse(c.Valid);
        }
        //testăm dacă programul detectează o problemă dacă introducem un nume care contine o cifra
        [TestMethod]
        public void TestVerificaNume_litere()
        {
           
            Assert.IsFalse(ProiectIP.VerificaNume.AreDoarLitere("re3t"));
        }

        //aici se testeaza daca se introduce un nume corect
        [TestMethod]
        public void TestVerificaNume_litereCorect()
        {
            Assert.IsTrue(ProiectIP.VerificaNume.AreDoarLitere("Elena"));
        }
        //testăm dacă programul detectează o problemă dacă introducem un nume care incepe cu majuscula ce continte un caracter special
        [TestMethod]
        public void TestVerificaNume_semn()
        {
            Assert.IsFalse(ProiectIP.VerificaNume.AreDoarLitere("El%ena"));
        }
        //testăm dacă programul detectează o problemă dacă introducem un nume care incepe cu majuscula ce contine un spatiu
        [TestMethod]
        public void TestVerificaNume_spatiu()
        {
            Assert.IsFalse(ProiectIP.VerificaNume.AreDoarLitere("El ena"));
        }
        //testăm dacă programul detectează dacă introducem un nume care incepe cu majuscula si il pune ca valid
        [TestMethod]
        public void TestVerificaNume_literaMare()
        {
            Assert.IsTrue(ProiectIP.VerificaNume.IncepeCuLiteraMare("Elena"));
        }
        //testăm dacă programul detectează o problemă dacă introducem un nume scris cu  litere mici
        [TestMethod]
        public void TestVerificaNume_AreLitereDiferite_1()
        {
            Assert.IsTrue(ProiectIP.VerificaNume.ContineLitereDiferite("elena"));
        }

        //testăm dacă programul detectează o problemă dacă introducem un nume format din aceeași literă (mică în acest caz)
        [TestMethod]
        public void TestVerificaNume_AreLitereDiferite_2()
        {
            Assert.IsFalse(ProiectIP.VerificaNume.ContineLitereDiferite("eeee"));
        }
        //testăm dacă programul detectează o problemă dacă introducem un nume format din aceeași literă care incepe cu o litera mare
        [TestMethod]
        public void TestVerificaNume_AreLitereDiferite_3()
        {
            Assert.IsFalse(ProiectIP.VerificaNume.ContineLitereDiferite("Eeee"));
        }
        //testăm dacă programul detectează o problemă dacă introducem un nume format din aceeași literă (mica) care contine o litera mare care nu e nici la inceput nici la sfarsit
        [TestMethod]
        public void TestVerificaNume_AreLitereDiferite_4()
        {
            Assert.IsFalse(ProiectIP.VerificaNume.ContineLitereDiferite("eeEe"));
        }
        //verifica daca detecteaza ca numele e format din aceeasi litera daca se dau doar litere mari
        [TestMethod]
        public void TestVerificaNume_AreLitereDiferite_5()
        {
            Assert.IsFalse(ProiectIP.VerificaNume.ContineLitereDiferite("EEEE"));
        }
        //testăm dacă programul detectează o problemă dacă introducem un nume format din aceeași literă (mica în acest caz)
        [TestMethod]
        public void TestVerificaNume_literaMica()
        {
            Assert.IsFalse(ProiectIP.VerificaNume.IncepeCuLiteraMare("elena"));
        }
        //testăm dacă programul detectează o problemă dacă introducem un nume nul
        [TestMethod]
        public void TestVerificaNume_gol()
        {
            Assert.IsTrue(ProiectIP.VerificaNume.IncepeCuLiteraMare(""));
        }
        //verificam daca se returneaza cum trebuie enuntul Intrebarii
        [TestMethod]
        public void TestVerificaIntrebare()
        {
            ProiectIP.Intrebare a = new ProiectIP.Intrebare("enunt","var1","var2","var3","var4",3);
            Assert.AreEqual("enunt", a.Enunt);
        }
        //dacă una din întrebările date are ca variantă corectă a patra varianta
        [TestMethod]
        public void TestVerificaVariantaCorecta()
        {
            ProiectIP.Intrebare a = new ProiectIP.Intrebare("enunt", "var1", "var2", "var3", "var4", 4);
            Assert.AreEqual(4, a.VariantaCorecta);
        }
        //dacă una din întrebările date are ca variantă corectă una imposibilă
        [TestMethod]
        public void TestVerificaFlagIntrebare()
        {
            ProiectIP.Intrebare a = new ProiectIP.Intrebare("enunt", "var1", "var2", "var3", "var4", -1);
            Assert.IsFalse(a.VerificaFlag);
        }
        //dacă una din întrebările date are ca variantă corectă una prea mare

        [TestMethod]
        public void TestVerificaFlagIntrebareValoareMare()
        {
            ProiectIP.Intrebare a = new ProiectIP.Intrebare("enunt", "var1", "var2", "var3", "var4", 10);
            Assert.IsFalse(a.VerificaFlag);
        }

        //verificam daca extrage bine prima varianta
        
        [TestMethod]
        public void TestVerificaVarianta1()
        {
            ProiectIP.Intrebare a = new ProiectIP.Intrebare("enunt", "2321", "var2", "var3", "var4", 4);
            Assert.AreEqual("2321", a.Varianta1);
        }

        //verificam daca extrage bine a doua varianta
        [TestMethod]
        public void TestVerificaVarianta2()
        {
            ProiectIP.Intrebare a = new ProiectIP.Intrebare("enunt", "dsds", "a", "var3", "var4", 4);
            Assert.AreEqual("a", a.Varianta2);
        }

        //verificam daca extrage bine a triea varianta
        [TestMethod]
        public void TestVerificaVarianta3()
        {
            ProiectIP.Intrebare a = new ProiectIP.Intrebare("enunt", "dsds", "a", "var3", "var4", 4);
            Assert.AreEqual("var3", a.Varianta3);
        }
        //verificam daca extrage bine a patra varianta
        [TestMethod]
        public void TestVerificaVarianta4()
        {
            ProiectIP.Intrebare a = new ProiectIP.Intrebare("enunt", "dsds", "a", "var3", "var4", 4);
            Assert.AreEqual("var4", a.Varianta4);
        }
    }
}

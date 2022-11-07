
/**************************************************************************
 *                                                                        *
 *  File:        ScorFinal.cs                                             *
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectIP
{
    ///<summary>
    ///Aceasta clasa este folosita pentru a calcula scorul final, fiind un singleton deoarece avem nevoie de o singura instanta a ei,
    ///scorul final fiind doar unul. 
    ///</summary>
    public class ScorFinal : Scor
    {
        private static ScorFinal _scor;//instanta Singleton-ului, Membrul static ce va retine instanta clasei.
        private static int _intrebariCorecte = 0;//retine intrebarile corecte
        ///<summary>
        ///Constructorul privat.
        ///</summary>
        private ScorFinal()
        {
            _scor = null;
        }
        ///<summary>
        ///Metoda va returna instanta Singleton-ului. Daca acesta a fost deja creat, va returna instanta creata anterior, daca nu, va crea
        ///un nou obiect.
        ///</summary>
        public static ScorFinal Instance
        {
            get
            {
                if (_scor == null)
                    _scor = new ScorFinal();
                return _scor;
            }
        }
        ///<summary>
        ///Aceasta metoda adauga la scorul tinut pana intr-un punct, noul scor facut de utilizator la completarea unui modul.
        ///</summary>
        public void Adauga(int intrebariCorecte)
        {
            _intrebariCorecte = _intrebariCorecte + intrebariCorecte;
        }
        ///<summary>
        ///Metoda care calculeaza rezultatul.
        ///</summary>
        public override decimal Rezultat()
        {
            decimal x;
            try
            {

                Calculeaza c = new Calculeaza(_intrebariCorecte, 64m);
                x = c.Rezultat;

            }
            catch
            {
                x = 0m;
            }
            return x;
        }
        ///<summary>
        ///Metoda ce returneaza cate intrebari corecte au fost facute pana intr-un anumit punct.
        ///</summary>
        public int getCalculRaspuns()
        {
            return _intrebariCorecte;
        }

    }
}

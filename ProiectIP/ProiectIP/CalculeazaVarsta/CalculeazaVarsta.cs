
/**************************************************************************
 *                                                                        *
 *  File:        CalculeazaVarsta.cs                                      *
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
    ///Clasa CalculeazaVarsta se va folosi pentru a calcula varsta in functie de anul nasterii introdus de utilizator si de anul curent. Este nevoie de aceasta clasa pentru a sti daca persoana care se logheaza are intre 16 si 100 de ani sau daca a introdus o data valida.
    ///</summary>
    public class CalculeazaVarsta
    {
        private bool _valid { set; get; }
        private int _x;
        private int _y;
        private int _rezultat;
        /// <summary>
        /// Constructorul care primeste ca parametru un an si va verifica daca acesta este unul valid.
        /// </summary>
        /// <param name="y"></param>
        public CalculeazaVarsta(int y)
        {

            _x = DateTime.Now.Year;
            _y = y;
            _valid = true;
            if (y <= 0 || y > DateTime.Now.Year)
                _valid = false;
            if (_valid)
                Calcul();
        }
        /// <summary>
        /// Calculeaza varsta in functie de an si verifica daca este o varsta acceptata in aplicatia noastra.
        /// </summary>
        public void Calcul()
        {

            _rezultat = _x - _y;
            if (_rezultat < 16 || _rezultat > 100)
                _valid = false;
        }
        /// <summary>
        /// Returneaza daca argumentele date functiei sunt valide.
        /// </summary>
        public bool Valid
        {
            get
            {
                return _valid;
            }
        }
        /// <summary>
        /// Returneaza rezultatul calculului.
        /// </summary>
        public int Rezultat
        {
            get
            {
                return _rezultat;
            }
        }

    }
}


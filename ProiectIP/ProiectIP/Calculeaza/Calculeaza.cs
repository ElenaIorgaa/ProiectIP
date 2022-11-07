
/**************************************************************************
 *                                                                        *
 *  File:        Calculeaza.cs                                            *
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
    ///Clasa Calculeaza se va folosi pentru a calcula scorul in functie de numarul intrebarilor corecte si totale. Ea este apelata in clasele ScorPartial si ScorFinal.
    ///</summary>
    public class Calculeaza
    {
        private bool _valid { set; get; }
        private decimal _x;
        private decimal _y;
        private decimal _rezultat;
        /// <summary>
        /// Constructorul clasei care primeste cei 2 operanzi si face verificarea sa vada daca acestia sunt valizi.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Calculeaza(decimal x, decimal y)
        {

            _x = x;
            _y = y;
            _valid = true;
            if (x < 0 || y <= 0)
                _valid = false;
            if (_valid)
                Calcul();
        }
        /// <summary>
        /// Calculul scorului final care va fi folosit pentru a imparti numarul de raspunsuri corecte la numarul de intrebari pentru a obtine procentajul.
        /// </summary>
        public void Calcul()
        {
            _rezultat = _x / _y * 100m;
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
        public decimal Rezultat
        {
            get
            {
                return _rezultat;
            }
        }

    }
}

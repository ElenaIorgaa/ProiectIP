
/**************************************************************************
 *                                                                        *
 *  File:        ScorPartial.cs                                           *
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
    ///Clasa folosita pentru a calcula scorul utilizatorului dupa fiecare modul terminat
    ///</summary>
    public class ScorPartial : Scor
    {
        private static int _intrebariCorecte;//membru static ce va retine intrebarile corecte primite pentru a calcula scorul partial
        ///<summary>
        ///Constrctorul scorului partial.
        ///</summary>
        public ScorPartial(int intrebariCorecte)
        {
            _intrebariCorecte = intrebariCorecte;
        }
        ///<summary>
        ///Metoda ce calculeaza scorul.
        ///</summary>
        public override decimal Rezultat()
        {
            decimal x;
            try
            {
                Calculeaza c = new Calculeaza(_intrebariCorecte, 8);
                x = c.Rezultat;
            }
            catch
            {
                x = 0m;
            }
            return x;
        }
    }
}

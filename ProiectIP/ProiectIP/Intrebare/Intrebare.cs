
/**************************************************************************
 *                                                                        *
 *  File:        Intrebare.cs                                             *
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
    ///Clasa Intrebare este folosita pentru a ne permite sa cream un obiect de tip Intrebare, fiecare obiect avand un enunt, 4 variante si un
    ///int care va spune care varianta este cea corecta.
    ///</summary>
    public class Intrebare
    {
        private string _enunt;
        private string _var1;
        private string _var2;
        private string _var3;
        private string _var4;
        private int _varCorecta;
        public static int nr = 0;
        private bool _flag;
        ///Constructorul clasei.
        public Intrebare(string enunt, string var1, string var2, string var3, string var4, int varCorecta)
        {
            _flag = true;
            _enunt = enunt;
            _var1 = var1;
            _var2 = var2;
            _var3 = var3;
            _var4 = var4;
            _varCorecta = varCorecta;
            nr++;
            if (varCorecta < 0 || varCorecta > 5)
            {
                _flag = false;
            }
        }
        ///Returneaza enuntul intrebarii.
        public string Enunt
        {
            get
            {
                return _enunt;
            }
        }
        ///Returneaza prima varianta.
        public string Varianta1
        {
            get
            {
                return _var1;
            }
        }
        ///Returneaza a doua varianta.
        public string Varianta2
        {
            get
            {
                return _var2;
            }
        }
        ///Returneaza a treia varianta.
        public string Varianta3
        {
            get
            {
                return _var3;
            }
        }
        ///Returneaza a patra varianta.
        public string Varianta4
        {
            get
            {
                return _var4;
            }
        }
        ///Returneaza care este varianta corecta.
        public int VariantaCorecta
        {
            get
            {
                return _varCorecta;
            }
        }
        /// <summary>
        /// Verifica daca valoarea introdusa ca raspuns corect este valida.
        /// </summary>
        public bool VerificaFlag
        {
            get
            {
                return _flag;
            }
        }
    }
}

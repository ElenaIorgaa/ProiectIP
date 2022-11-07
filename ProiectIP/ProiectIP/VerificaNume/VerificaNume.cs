/**************************************************************************
 *                                                                        *
 *  File:        VerificaNume.cs                                          *
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
    ///Clasa care va verifica corectitudinea numelui introdus la logare.
    ///</summary>
    public class VerificaNume
    {

        /// <summary>
        ///Functia care vrifica daca string-ul introdus are doar litere.
        /// </summary>
        /// <param name="s"></param>
        /// <returns>returneaza true daca incepe cu litera mare si false daca cu mica</returns>
        public static bool AreDoarLitere(string s)
        {
            return s.All(char.IsLetter);
        }
        /// <summary>
        /// Functia care verifica daca string-ul incepe cu litera mare.
        /// </summary>
        /// <param name="s"></param>
        /// <returns>returneaza true daca incepe cu litera mare si false daca cu mica</returns>
        public static bool IncepeCuLiteraMare(string s)
        {
            if (s.Length > 0)
            {
                return Char.IsUpper(Convert.ToChar(s.Substring(0, 1)));
            }
            else return true;
        }
        /// <summary>
        /// Functie ce primeste ca parametru un string si va verifica daca contine litere diferite sau aceeasi litera ex: Aaaa va returna false.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool ContineLitereDiferite(string s)
        {
            if (s.Length > 0)
            {
                string b = s.ToLower();//le converteste la litere mici pentru a nu face diferenta de exemplu intre „a” și „A”
                char a = Convert.ToChar(b.Substring(0, 1));//extrage prima litera a textului
                int suma = 0;

                foreach (char i in b)
                {
                    if (i.Equals(a))//daca litera este identica cu prima litera a cuvantului
                        suma++;
                }
                if (suma == b.Length)//daca suma nu este egala cu numarul literelor, inseamna ca toate literele sunt identice
                    return false;
                else return true;
            }
            else return true;
        }
    }
}
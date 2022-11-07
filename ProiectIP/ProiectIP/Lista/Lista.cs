
/**************************************************************************
 *                                                                        *
 *  File:        Lista.cs                                                 *
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
    ///Un singleton care va retine o lista care va ramane accesibila si modificabila pe tot timpul programului.
    ///</summary>
    public class Lista
    {
        private List<int> _lista;
        private static Lista _instance;//instanta listei
        public static int moduleParcurse = 0;//o variabila ce retine cate module a parcurs utilizatorul
        ///<summary>
        ///Constructorul privat al Singleton-ului.
        ///</summary>
        private Lista()
        {
            _lista = new List<int>();
        }
        ///<summary>
        ///Daca nu exista deja o instanta a clasei, se creaza una. Daca exista, se returneaza cea creata.
        ///</summary>
        public static Lista Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Lista();
                return _instance;
            }
        }
        ///<summary>
        ///Metoda ce adauga la lista si in acelasi timp incremeneteaza numarul modulelor parcurse deoarece, odata ce adaugam
        ///un scor, inseamna ca am parcurs un modul.
        ///</summary>
        public void Add(int x)
        {
            _lista.Add(x);
            moduleParcurse++;
        }
        ///<summary>
        ///Verifica daca in lista exista deja acel modul, pentru a nu repeta din nou acelasi test.
        ///</summary>
        public bool Contains(int x)
        {
            if (_lista.Contains(x))
                return true;
            else return false;
        }

    }
}

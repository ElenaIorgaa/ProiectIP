
/**************************************************************************
 *                                                                        *
 *  File:        ChestioarFactory.cs                                      *
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
    ///Clasa de tip Factory ce va decide ce fel de obiect va fi creat in functie de tipul dat.
    ///</summary>
    public class ChestionarFactory
    {
        ///functia ce va returna chestionarul dorit in functie de tipul primit ca parametru
        private IChestionar _chestionar;
        public ChestionarFactory(int tip)
        {
            switch (tip)
            {
                case 1:
                    _chestionar = new ChestionarMatematica();
                    break;
                case 2:
                    _chestionar = new ChestionarGeografie();
                    break;
                case 3:
                    _chestionar = new ChestionarChimie();
                    break;
                case 4:
                    _chestionar = new ChestionarIstorie();
                    break;
                case 5:
                    _chestionar = new ChestionarSport();
                    break;
                case 6:
                    _chestionar = new ChestionarLimbaSiLiteraturaRomana();
                    break;
                case 7:
                    _chestionar = new ChestionarArta();
                    break;
                case 8:
                    _chestionar = new ChestionarMuzica();
                    break;
                default:
                    _chestionar = new ChestionarGeografie();
                    break;
            }
        }

        public IChestionar GetChestionar()
        {
            return _chestionar;
        }
    }
}


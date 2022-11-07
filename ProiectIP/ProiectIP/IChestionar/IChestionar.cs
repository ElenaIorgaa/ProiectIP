
/**************************************************************************
 *                                                                        *
 *  File:        IChestioar.cs                                            *
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
    ///Interfata ce trebuie sa fie implementata de fiecare clasa de tip chestionar
    ///</summary>
    public interface IChestionar
    {
        string GetEnunt(int x);//intoarce enuntul intrebarii
        string GetVar1(int x);//intoarce prima varianta
        string GetVar2(int x);//intoarce a doua varianta
        string GetVar3(int x);//intoarce a treia varianta
        string GetVar4(int x);//intoarce a patra varianta
        int GetRaspuns(int x);//intoarce raspunsul
        string Picture();//va intoarce ce tip de imagine trebuie afisata pe interfata

    }
}

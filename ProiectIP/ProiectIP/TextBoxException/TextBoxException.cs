
/**************************************************************************
 *                                                                        *
 *  File:        TextBoxException.cs                                      *
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
    ///Clasa ce reprezinta o exceptie de tip textbox.
    ///</summary>
    public class TextBoxException : Exception
    {
        String _message;
        public TextBoxException(String message)
        {
            _message = message + " eroare text box";
        }
        /// <summary>
        /// Returneaza mesajul exceptiei.
        /// </summary>
        public override String Message
        {
            get
            {
                return _message;
            }
        }
    }
}

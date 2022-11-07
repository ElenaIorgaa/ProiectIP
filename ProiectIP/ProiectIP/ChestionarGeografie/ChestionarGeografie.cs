
/**************************************************************************
 *                                                                        *
 *  File:        ChestioarGeografie.cs                                    *
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
using System.IO;
using Newtonsoft.Json;

namespace ProiectIP
{
    ///<summary>
    ///Aceasta este clasa care poate fi folista pentru a instantia un obiect de tip chestionar cu intrebari din domeniul Chimie.
    ///</summary>
    public class ChestionarGeografie : IChestionar
    {
        private List<Intrebare> _intrebari;
        public ChestionarGeografie()
        {
            _intrebari = new List<Intrebare>();
            string fileName = "IntrebariGeografie.json"; //numele fisierului JSON in care se afla datele
            try
            {
                using (StreamReader r = new StreamReader(fileName))//cu ajutorul StreamReader se extrag datele din fisierul cu numele setat mai sus
                {
                    string json = r.ReadToEnd(); //se citesc datele pana la final
                    _intrebari = JsonConvert.DeserializeObject<List<Intrebare>>(json);//deserializarea json-ului si adaugarea lui sub forma de lista cu obiecte de tipul Intrebare
                }
            }
            catch
            {
                ///daca nu se reuseste citirea din JSON, se creeaza prin simpla instantiere a unui obiect de tip intrebare
                _intrebari = new List<Intrebare>();
                _intrebari.Add(new Intrebare("Care este cel mai lung fluviu din Europa?", "Bucuresti", "Volga", "Dunarea", "Oltul", 2));
                _intrebari.Add(new Intrebare("Ce țară din America de Sud are cea mai mare suprafață?", "Franta", "Brazilia", "Anglia", "Argentina", 2));
                _intrebari.Add(new Intrebare("Cate continente exista pe pamant?", "2", "5", "1", "7", 4));
                _intrebari.Add(new Intrebare("Care este capitala Letoniei?", "Crypto", "Riga", "Paraguay", "Vilnius", 2));
                _intrebari.Add(new Intrebare("Care este capitala Islandei?", "Lisabona", "Budapesta", "Reykjavik", "Bucuresti", 3));
                _intrebari.Add(new Intrebare("Care este cel mai estic oraș al României?", "Sulina", "Galati", "Bucuresti", "Suceava", 1));
                _intrebari.Add(new Intrebare("Ce tip de lac este lacul Iezer?", "mare", "glaciar", "vulcanic", "de baraj natural", 2));
                _intrebari.Add(new Intrebare("Care este cel mai inalt munte de pe glob?", "Moldoveanu", "K2", "Everest", "Kangchenjunga", 3));
            }
        }

        public string GetEnunt(int x)
        {

            return _intrebari[x].Enunt;

        }
        public string GetVar1(int x)
        {

            return _intrebari[x].Varianta1;

        }
        public string GetVar2(int x)
        {

            return _intrebari[x].Varianta2;

        }
        public string GetVar3(int x)
        {

            return _intrebari[x].Varianta3;

        }
        public string GetVar4(int x)
        {

            return _intrebari[x].Varianta4;

        }
        public int GetRaspuns(int x)
        {

            return _intrebari[x].VariantaCorecta;

        }
        public string Picture()
        {
            return "geografie";
        }

    }
}

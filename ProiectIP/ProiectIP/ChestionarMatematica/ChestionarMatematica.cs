
/**************************************************************************
 *                                                                        *
 *  File:        ChestioarMatematica.cs                                   *
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
    ///Aceasta este clasa care poate fi folista pentru a instantia un obiect de tip chestionar cu intrebari din domeniul Matematica.
    ///</summary>
    public class ChestionarMatematica : IChestionar
    {
        private List<Intrebare> _intrebari;
        public ChestionarMatematica()
        {
            _intrebari = new List<Intrebare>();
            string fileName = "IntrebariMatematica.json"; //numele fisierului JSON in care se afla datele
            try
            {
                using (StreamReader r = new StreamReader(fileName))//cu ajutorul StreamReader se extrag datele din fisierul cu numele setat mai sus
                {
                    string json = r.ReadToEnd();//se citesc datele pana la final
                    _intrebari = JsonConvert.DeserializeObject<List<Intrebare>>(json);//deserializarea json-ului si adaugarea lui sub forma de lista cu obiecte de tipul Intrebare
                }
            }
            catch
            {
                ///daca nu se reuseste citirea din JSON, se creeaza prin simpla instantiere a unui obiect de tip intrebare
                _intrebari = new List<Intrebare>();
                _intrebari.Add(new Intrebare("Care este rezultatul operației 3452-112/2+2^7?", "3268", "Da", "3563", "4324", 1));
                _intrebari.Add(new Intrebare("Care este rezultatul operației 1*1?", "1", "Da", "3563", "0", 1));
                _intrebari.Add(new Intrebare("Cate laturi are un hexagon?", "2", "6", "Niciuna", "4", 2));
                _intrebari.Add(new Intrebare("Care este al 50-lea număr din această secvență? 5, 11, 17, 23, 29, 35, 41, …?", "Stai să scriu tot", "34343", "299", "Ana", 2));
                _intrebari.Add(new Intrebare("Care este modulul numărului complex z = (2 + 3i)(2 - 3i ) - (9 - 3i)?", "23", "-23", "5", "PI", 3));
                _intrebari.Add(new Intrebare("2 este ... ?", "prim", "impar", "frumos", "patrat perfect", 1));
                _intrebari.Add(new Intrebare("Rădăcina pătrată a lui 196 este ...", "38416", "14", "Nu are radacina patrata", "196", 2));
                _intrebari.Add(new Intrebare("Care este perimetrul unui pătrat cu latura de 8 cm?", "32 dm", "64 cm", "32 cm", "7 m", 3));
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
            return "math";
        }

    }
}

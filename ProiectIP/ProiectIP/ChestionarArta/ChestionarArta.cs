
/**************************************************************************
 *                                                                        *
 *  File:        ChestionarArta.cs                                        *
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
using Newtonsoft.Json;
using System.IO;

namespace ProiectIP
{
    ///<summary>
    ///Aceasta este clasa care poate fi folista pentru a instantia un obiect de tip chestionar cu intrebari din domeniul Arta.
    ///</summary>
    public class ChestionarArta : IChestionar
    {
        private List<Intrebare> _intrebari;

        public ChestionarArta()
        {
            _intrebari = new List<Intrebare>();
            string fileName = "IntrebariArta.json";// numele fisierului JSON in care se afla datele
            try
            {
                using (StreamReader r = new StreamReader(fileName))//))//cu ajutorul StreamReader se extrag datele din fisierul cu numele setat mai sus
                {
                    string json = r.ReadToEnd();//se citesc datele pana la final
                    _intrebari = JsonConvert.DeserializeObject<List<Intrebare>>(json);//deserializarea json-ului si adaugarea lui sub forma de lista cu obiecte de tipul Intrebare
                }
            }
            catch
            {
                ///daca nu se reuseste citirea din JSON, se creeaza prin simpla instantiere a unui obiect de tip intrebare
                _intrebari = new List<Intrebare>();
                _intrebari.Add(new Intrebare("În ce oraş s-a născt Michelangelo Bounarotti?", "Roma", "Bologna", "Florenta", "Milano", 3));
                _intrebari.Add(new Intrebare("Cine a pictat „Primăvara”?", "Monet", "Boticelli", "Gaugain", "Nu stiu", 2));
                _intrebari.Add(new Intrebare("Cine a pictat „Jucătorii de cărţi”? ", "Cezanne", "Manet", "Matisse", "Nu stiu", 1));
                _intrebari.Add(new Intrebare("Cine a sculptat “Faun si nimfa”?", "Brancusi", "Donatello", "Rodin", "Nu stiu", 3));
                _intrebari.Add(new Intrebare("Care este ţara de origine a pictorului Stanley Bleifeld?", "Anglia", "SUA", "Italia", "Spania", 2));
                _intrebari.Add(new Intrebare("În ce ţară a murit Salvator Dali? ", "Italia", "SUA", "Spania", "Romania", 3));
                _intrebari.Add(new Intrebare("Cine a pictat “Cina cea de taina”?", "George Călinescu", "Leonerdo da Vinci", "Monet", "Cezanne", 2));
                _intrebari.Add(new Intrebare("Cine a pictat “The Starry Night”?", "George Călinescu", "Leonerdo da Vinci", "Monet", "Vincent van Gogh", 4));
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
            return "arta";
        }

    }
}

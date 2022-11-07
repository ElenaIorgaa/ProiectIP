
/**************************************************************************
 *                                                                        *
 *  File:        ChestioarSport.cs                                        *
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
    ///Aceasta este clasa care poate fi folista pentru a instantia un obiect de tip chestionar cu intrebari din domeniul Sport.
    ///</summary>
    public class ChestionarSport : IChestionar
    {
        private List<Intrebare> _intrebari;
        public ChestionarSport()
        {
            _intrebari = new List<Intrebare>();
            string fileName = "IntrebariSport.json";//numele fisierului JSON in care se afla datele
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
                _intrebari.Add(new Intrebare("În ce an a devenit fotbalul sport olimpic?", "1900", "1800", "2000", "2010", 1));
                _intrebari.Add(new Intrebare("În ce fază a ajuns România la Campionatul Mondial din 1994?", "Sferturi", "Finale", "Nu a ajuns", "A castigat", 1));
                _intrebari.Add(new Intrebare("Ce joc de ciclism a derivat din fotbal?", "Niciunul", "Ciclobal", "Rugby", "Fotbalul american", 2));
                _intrebari.Add(new Intrebare("Cum se numește stadionul echipei Bayern Muchen?", "El Madrigal", "Wembley", "Rose Bowl", "Soccer City", 1));
                _intrebari.Add(new Intrebare("Câte minute are pauza unui meci de fotbal?", "24", "40", "12", "15", 4));
                _intrebari.Add(new Intrebare("Care este cel mai selecționat jucător din istoria naționalei de fotbal a României?", "Ianis Hagi", "Dorinel Munteanu", "Olimpiu Morutan", "Denis Alibec", 2));
                _intrebari.Add(new Intrebare("Care este cel mai mare teren de cricket din Anglia?", "FC", "Lisabona", "Domnului", "Florel", 3));
                _intrebari.Add(new Intrebare("În fotbalul american, câte puncte înscrii pentru un touchdown?", "3", "4", "6", "23", 3));
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
            return "sport";
        }

    }
}

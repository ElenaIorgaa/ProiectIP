
/**************************************************************************
 *                                                                        *
 *  File:        ChestioarMuzica.cs                                       *
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
    ///Aceasta este clasa care poate fi folista pentru a instantia un obiect de tip chestionar cu intrebari din domeniul Muzica.
    ///</summary>
    public class ChestionarMuzica : IChestionar
    {
        private List<Intrebare> _intrebari;
        public ChestionarMuzica()
        {
            _intrebari = new List<Intrebare>();
            string fileName = "IntrebariMuzica.json"; //numele fisierului JSON in care se afla datele
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
                _intrebari.Add(new Intrebare("Care este cealaltă limbă în care a cântat în mod regulat Celine Dion în anii 90?", "Franceza", "Italiana", "Romana", "Germana", 1));
                _intrebari.Add(new Intrebare("Tatăl cărui membru al Destiny's Child era managerul grupului?", "Beyonce", "LeToya Luckett", "LaTavia Roberson", "Kelly Rowland", 1));
                _intrebari.Add(new Intrebare("Maroon 5 și-a lansat albumul solo în 2002, intitulat Cântece despre ...cine?", "Mary", "Caroline", "Jane", "Helen", 3));
                _intrebari.Add(new Intrebare("Ce cântăreț a avut Panou Nr. 1 în ultimele patru decenii?", "Mariah Carey", "Justin Bieber", "Taylor Swift", "Michael Jackson", 1));
                _intrebari.Add(new Intrebare("Care compozitor clasic era surd?", "Johann Sebastian Bach", "Wolfgang Amadeus Mozart", "Richard Wagner", "Ludwig Van Beethoven", 4));
                _intrebari.Add(new Intrebare("Care astronom este mentionat în Bohemian Rhapsody?", "Galileo", "Charles Messier", "Ptolemeu", "Tycho Brahe", 1));
                _intrebari.Add(new Intrebare("Cine a fost primul chitarist principal al Metallica?", "Dave Mustaine", "Duane Allman", "Eddie Van Halen ", "Chuck Berry ", 1));
                _intrebari.Add(new Intrebare("Cine a cântat Spongebob pantaloni patrati theme pentru film?", "Avril Lavigne", "Taylor Swift", "Selena Gomez", "Justin Bieber", 1));
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
            return "muzica";
        }
        public List<Intrebare> ReturneazaLista()
        {
            return _intrebari;
        }

    }
}

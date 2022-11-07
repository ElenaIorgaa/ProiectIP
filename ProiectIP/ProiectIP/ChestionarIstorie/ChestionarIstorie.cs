
/**************************************************************************
 *                                                                        *
 *  File:        ChestioarIstorie.cs                                      *
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
    ///Aceasta este clasa care poate fi folista pentru a instantia un obiect de tip chestionar cu intrebari din domeniul Istorie.
    ///</summary>
    public class ChestionarIstorie : IChestionar
    {
        private List<Intrebare> _intrebari;
        public ChestionarIstorie()
        {

            _intrebari = new List<Intrebare>();
            string fileName = "IntrebariIstorie.json";//numele fisierului JSON in care se afla datele
            // string jsonString = File.ReadAllText(fileName);

            // _intrebari = JsonSerializer.Deserialize<Intrebare>(jsonString)!;
            try
            {
                using (StreamReader r = new StreamReader(fileName))//cu ajutorul StreamReader se extrag datele din fisierul cu numele setat mai sus
                {
                    {
                    string json = r.ReadToEnd();//se citesc datele pana la final
                        _intrebari = JsonConvert.DeserializeObject<List<Intrebare>>(json);//deserializarea json-ului si adaugarea lui sub forma de lista cu obiecte de tipul Intrebare
                    }
                }
            }
            catch
            {
                ///daca nu se reuseste citirea din JSON, se creeaza prin simpla instantiere a unui obiect de tip intrebare
                _intrebari.Add(new Intrebare("În ce an s-a născut Regele Mihai I?", "1921", "1999", "1840", "1400", 1));
                _intrebari.Add(new Intrebare("În ce țară s-a născut Adolf Hitler?", "Germania", "Austria", "Romania", "Rusia", 2));
                _intrebari.Add(new Intrebare("În ce an a reușit Mihai Viteazul unirea celor trei mari țări medievale?", "1600", "2200", "1800", "1400", 1));
                _intrebari.Add(new Intrebare("Când a inceput Primul Război Mondial?", "2000", "1800", "1914", "1600", 3));
                _intrebari.Add(new Intrebare("În ce an a intrat România în Uniunea Europeana?", "1600", "2007", "Niciodata", "1800", 2));
                _intrebari.Add(new Intrebare("În ce an a murit Prințesa Diana?", "Inca traieste", "1900", "2000", "1997", 4));
                _intrebari.Add(new Intrebare("Ce naționalitate are Papa Francisc I?", "Romana", "Engleza", "Argentiniana", "Franceza", 3));
                _intrebari.Add(new Intrebare("În ce oraș au fost executați soții Ceaușescu?", "Bucuresti", "Praga", "Targoviste", "Liesti", 3));
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
            return "istorie";
        }

    }
}

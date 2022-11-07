using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectIP
{
    ///<summary>
    ///Aceasta clasa da functionalitatea lui Form2, care reprezinta interfata afisata atunci cand un chestionar este in curs, care afiseaza
    ///intrebarile si variantele.
    ///</summary>
    public partial class Form2 : Form
    {
        private int _raspunsCorect;//variabila ce va retine care este raspunsul corect al intrebarii
        private int _numarIntrebare = 1;//variabila ce retine la care intrebare se afla utilizatorul
        private ScorFinal _scorFinal;//aceasta va crea o instanta a scorului final(singleton) la inceput si dupa o va retine pe aceeasi tot timpul programului
        private int _nrIntrebariCorecte=0;//variabila ce inregistreaza cate intrebari corecte a dat utilizatorul

        private static Lista l;//lista in care se vor adauga modulele parcurse pentru ca utilizatorul sa nu poata parcurge acelasi modul de mai multe ori
        
        public Form2()
        {
            InitializeComponent();
            Question(_numarIntrebare);
            _scorFinal=ScorFinal.Instance;
            l = Lista.Instance;
            labelSucces.Text = $"Succes, {Form1.nume}";
           
        }

        ///metoda care varifica daca raspunsul dat de utilizator este corect sau nu
        private void CheckAnswer(object sender, EventArgs e)
        {
            var s = (Button)sender;
            int tag = Convert.ToInt32(s.Tag);
            ///daca raspunsuleste corect si numarul intrebarii <=8,atunci numarul intrebarii se incrementeaza si se apeleaza functia ce va
            ///lansa in executie intrebarea cu acel numar din domeniul ales
            ///la scorul final se va adauga 1 
            ///numarul de intrebari corecte la care a raspuns utilizatorul se va incrementa
            ///daca nu, doar se va incrementa numarul intrebarii si se va trece la intrebarea urmatoare
            if (tag == _raspunsCorect && _numarIntrebare<=8)
            {
                _numarIntrebare++;
                Question(_numarIntrebare);
                _scorFinal.Adauga(1);
                _nrIntrebariCorecte++;
                //MessageBox.Show("Raspuns corect");
            }
            else
            {
                _numarIntrebare++;
                Question(_numarIntrebare);
            }
            ///daca s-a terminat numarul de intrebari din chestionar se decide daca se va deschide optiunea de a alege un alt modul, sau 
            ///daca s-au parcurs toate si testul a luat sfarsit.
            if (_numarIntrebare == 9)

            {
                if (Lista.moduleParcurse == 10)
                {
                    this.Hide();
                    Form f3 = new Form3(_nrIntrebariCorecte,true);
                    f3.Show();
                    _numarIntrebare = 1;
                }
                else
                {
                    this.Hide();
                    Form3 f3 = new Form3(_nrIntrebariCorecte,false);
                    f3.Show();
                    _numarIntrebare = 1;
                }
            }

        }
        ///aceasta metoda decide in functie de domeniul ales in Form1 ce chestionar va fi lansat in executie si apoi pe rand, fiecare intrebare
        private void Question(int nr)
        {

            if (nr <= 8)

            {
                ChestionarFactory fact = new ChestionarFactory(Form1.domeniu);
                IChestionar cs = fact.GetChestionar();
                labelQuestion.Text = cs.GetEnunt(nr - 1);
                var1.Text = cs.GetVar1(nr - 1);
                var2.Text = cs.GetVar2(nr - 1);
                var3.Text = cs.GetVar3(nr - 1);
                var4.Text = cs.GetVar4(nr - 1);
                _raspunsCorect = cs.GetRaspuns(nr - 1);
                string nume = cs.Picture();
                ///in functie de domeniu se va alege ce imagine va fi afisata pe interfata
                if(nume=="math")
                {
                    pictureBoxChestionar.Image = ProiectIP.Properties.Resources.math;
                }
                else if(nume=="geografie")
                {
                    pictureBoxChestionar.Image = ProiectIP.Properties.Resources.geografie;
                }
                else if(nume=="muzica")
                {
                    pictureBoxChestionar.Image = ProiectIP.Properties.Resources.muzica;
                }
                else if (nume == "arta")
                {
                    pictureBoxChestionar.Image = ProiectIP.Properties.Resources.arta;
                }
                else if (nume == "chimie")
                {
                    pictureBoxChestionar.Image = ProiectIP.Properties.Resources.chimie;
                }
                else if (nume == "sport")
                {
                    pictureBoxChestionar.Image = ProiectIP.Properties.Resources.sport;
                }
                else if (nume == "romana")
                {
                    pictureBoxChestionar.Image = ProiectIP.Properties.Resources.romana;
                }
                else if (nume == "istorie")
                {
                    pictureBoxChestionar.Image = ProiectIP.Properties.Resources.istorie;
                }
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxChestionar_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Clasa pentru butonul de Help care va afisa utilizatorului help-ul asociat programului.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHelpChestionar_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Help-for-Project.chm");
        }

        private void labelSucces_Click(object sender, EventArgs e)
        {

        }
    }
}

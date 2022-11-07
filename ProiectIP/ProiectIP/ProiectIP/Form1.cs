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
    ///Clasa ce va lansa in executie interfata pentru meniul chestionarului care permite utilizatorului sa aleaga ce modul sa parcurga.
    ///</summary>
    public partial class Form1 : Form
    {
        public static int domeniu;//domeniul pe care il alege utilizatorul
        private Lista l;//singetonul care tine lista in care vom cauta modulele pe care le parcurgem, pentru a evita reincercarea lor
        public static string nume;
        public static int varsta;

        ///constructorul public al clasei
        public Form1()
        {
            l = Lista.Instance;
            InitializeComponent();
            Form2 f2 = new Form2();
            labelWelcome.Text = $"Bine ai venit, {nume}!";
            if(nume!=null)
            {
                textBoxNume.Enabled = false;
                textBoxVarsta.Enabled = false;
                buttonGeografie.Enabled = true;
                buttonMatematica.Enabled = true;
                buttonChimie.Enabled = true;
                buttonMuzica.Enabled = true;
                buttonArta.Enabled = true;
                buttonSport.Enabled = true;
                buttonIstorie.Enabled = true;
                buttonRomana.Enabled = true;

            }


        }

        ///functia care ne lasa sa parcurgem un domeniu daca acesta nu a fost parcurs deja
        private void AlegeDomeniu(int x)
        {
            domeniu = x;
            if (l.Contains(domeniu))
            {
                MessageBox.Show("Deja ati parcurs acest modul!");
            }
            else
            {

                l.Add(domeniu);
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }
        }
        private void labelTitlu_Click(object sender, EventArgs e)
        {

        }

        ///la apasarea fiecarui buton va fi lansata in executie functia de mai sus function(domeniu), iar ca parametru primeste domeniul
        ///ales de utilizator, pentru a stii ce chestionar sa fie lansat in executie
        private void buttonGeografie_Click(object sender, EventArgs e)
        {
            AlegeDomeniu(2);

        }

        private void buttonMatematica_Click(object sender, EventArgs e)
        {
            AlegeDomeniu(1);
 
        }

        private void buttonChimie_Click(object sender, EventArgs e)
        {

            AlegeDomeniu(3);
        }

        private void buttonIstorie_Click(object sender, EventArgs e)
        {
            AlegeDomeniu(4);
        }

        private void buttonSport_Click(object sender, EventArgs e)
        {
            AlegeDomeniu(5);
        }

        private void buttonRomana_Click(object sender, EventArgs e)
        {
            AlegeDomeniu(6);
        }

        private void buttonArta_Click(object sender, EventArgs e)
        {
            AlegeDomeniu(7);
        }

        private void buttonMuzica_Click(object sender, EventArgs e)
        {
            AlegeDomeniu(8);
        }

        private void textBoxNume_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                //if (textBoxNume.Text.All(char.IsLetter) == false)
                if(VerificaNume.AreDoarLitere(textBoxNume.Text)==false)
                    throw new InvalidNameException((textBoxNume.Text));

                if (textBoxNume.Text.Length > 10)
                {
                    
                    throw new TextBoxException("Mai mult de 10 caractere, ");
                    
                }
              
            }
            catch(InvalidNameException n)
            {
                MessageBox.Show(String.Format("{0}. Numele nu poate contine numere, spatii sau semne", n.Message));
                textBoxNume.Text = "";
            }
            catch(TextBoxException t)
            {
                MessageBox.Show(String.Format("{0}. Numele e prea lung", t.Message));
                textBoxNume.Text = "";

            }
            try { 
              if(VerificaNume.IncepeCuLiteraMare(textBoxNume.Text)==false)
                {
                    throw new TextBoxException("Numele trebuie sa inceapa cu litera mare!");
                }}
              catch(TextBoxException r)
            {
                MessageBox.Show(String.Format("{0} ", r.Message));
                textBoxNume.Text = "";
            }


        }


        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Help-for-Project.chm");
        }

        private void buttonSeteaza_Click(object sender, EventArgs e)
        {
            if (l.Contains(9) || l.Contains(10))
            {
                MessageBox.Show("Deja ati setat datele!");
            }
            else
            {
               

                string x = textBoxVarsta.Text;
                try
                {
                    int y = int.Parse(x);
                    CalculeazaVarsta c = new CalculeazaVarsta(y); 
                    varsta = c.Rezultat;

                    if (c.Valid == true && textBoxNume.Text!="" && VerificaNume.ContineLitereDiferite(textBoxNume.Text)==true)
                    {
                        nume = textBoxNume.Text;
                        labelWelcome.Text = $"Bine ai venit, {textBoxNume.Text}!";
                        l.Add(9);
                        l.Add(10); 
                        textBoxNume.Enabled = false;
                        textBoxVarsta.Enabled = false;
                        buttonGeografie.Enabled = true;
                        buttonMatematica.Enabled = true;
                        buttonChimie.Enabled = true;
                        buttonMuzica.Enabled = true;
                        buttonArta.Enabled = true;
                        buttonSport.Enabled = true;
                        buttonIstorie.Enabled = true;
                        buttonRomana.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Date incorecte, reincercati!");
                        textBoxNume.Text = "";
                        textBoxVarsta.Text = "";


                    }
                }
                catch
                {
                    MessageBox.Show("Nu e un an valid!");
                }
               
               


            }
        }

        private void pictureBoxQuizNight_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {

        }

        private void labelNume_Click(object sender, EventArgs e)
        {

        }

        private void labelDomeniu_Click(object sender, EventArgs e)
        {

        }

        private void textBoxVarsta_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (textBoxVarsta.Text.Any(char.IsLetter) == true)
                    throw new Exception("Anul nasterii nu poate contine litere");
            }
            catch
            {
                MessageBox.Show("Anul nasterii nu poate contine litere");
                textBoxVarsta.Text = "";
            }

            try
            {
                if (textBoxVarsta.Text.Contains('-') || textBoxVarsta.Text.Contains('+') || textBoxVarsta.Text.Contains('`') || textBoxVarsta.Text.Contains('~') || textBoxVarsta.Text.Contains('%') || textBoxVarsta.Text.Contains('#') || textBoxVarsta.Text.Contains('&') || textBoxVarsta.Text.Contains('^'))
                    throw new Exception("Anul nasterii nu poate contine astfel de caractere");
            }
            catch
            {
                MessageBox.Show("Anul nasterii nu poate contine astfel de caractere");
                textBoxVarsta.Text = "";
            }
        }
    }

    [Serializable]
    public class InvalidNameException : Exception
    {
        public InvalidNameException() { }

        public InvalidNameException(string name)
            : base(String.Format("Nume invalid: {0}", name))
        {

        }
    }

}

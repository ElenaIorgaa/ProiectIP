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
    ///Clasa ce da functionalitatea lui Form3, Form3 fiind interfata afisata atunci cand un modul este completat,
    ///sau cand tot testul este terminat.
    ///</summary>
    public partial class Form3 : Form
    {
        private bool _flag=false;
        ///constructorul public
        public Form3(int scor, bool flag)
        {
            if (flag == false)//daca s-a primit un flag care e pe false, inseamna ca testul inca nu s-a terminat, ci utilizatorul a completat un singur modul
            {
                InitializeComponent();
                ScorPartial p = new ScorPartial(scor);
                labelPunctaj.Text = p.Rezultat().ToString();
                labelFelicitari.Text = $"FELICITARI, {Form1.nume}!";
            }
            else if(flag==true)//daca s-a primit un flag care e pe true, inseamna ca utilizatorul a completat toate modulele si trebuie afisat scorul final.
            {
                InitializeComponent();
                ScorFinal p = ScorFinal.Instance;
                labelPunctaj.Text = p.Rezultat().ToString();
                labelFelicitari.Text = $"FELICITARI, {Form1.nume}! AI TERMINAT";
                buttonAlegeDomeniu.Text = "INCHIDE TESTUL";
                _flag = true;//variabila _flag devine true instiintand programul ca a terminat si se poate inchide
            }
        }


        private void buttonAlegeDomeniu_Click(object sender, EventArgs e)
        {
            if (_flag == false)//daca _flag e false inseamna ca programul nu s-a terminat deci utilizatorul trebuie sa aiba optiunea de a alege un alt domeniu
            {
                Form1 form = new Form1();
                this.Hide();
                form.ShowDialog();
            }
            else//daca _flag este true inseamna ca testul s-a terminat si programul poate fi inchis
            {
                Application.Exit();
            }
            
        }

        private void labelPunctaj_Click(object sender, EventArgs e)
        {

        }

        private void labelFelicitari_Click(object sender, EventArgs e)
        {

        }

        private void labelScorFinal_Click(object sender, EventArgs e)
        {

        }

        private void labelProcent_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

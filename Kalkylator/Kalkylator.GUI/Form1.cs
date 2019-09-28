using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkylator.GUI
{
    public partial class Form1 : Form
    {
        Kalkylator InputNum = new Kalkylator();
       
        public Form1()
        {
            InitializeComponent();
            InputNum.Value1 = 0;
            InputNum.Value2 = 0;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string inputdata = textBox1.Text;
            UpdateValue(inputdata, "Box1");



        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string inputdata = textBox2.Text;
            UpdateValue(inputdata, "Box2");
            
           


        }
        //splitrar upp algorithmen methoden safeinput till två delar. En del är del av klassen Kalkylator och andra delen är en lokal metod.
        //Den i klassen kontrollera om inga ick nummeriska karaktärer är med 
        // den lokala delen kontrollerar och hanterar den del som är kopplat med funktionerna i Winform samt sätter värderna.
        private void UpdateValue(string data, string RefCall)
        {
            bool inputState = InputNum.SafeInput(data);
            if (inputState == true)
            {
                long Longdata = long.Parse(data);
                if(RefCall == "Box1")
                {
                    InputNum.Value1 = Longdata;
                }
                else if(RefCall == "Box2")
                {
                    InputNum.Value2 = Longdata;
                }

            }
            else if(inputState == false)
            {
                if (RefCall == "Box1")
                {
                    InputNum.Value1 = 0;
                    textBox1.Clear();
                }
                else if (RefCall == "Box2")
                {
                    InputNum.Value2 = 0;
                    textBox2.Clear();
                }

            }
        }
        


        


    }
}

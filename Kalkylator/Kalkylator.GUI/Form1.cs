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
            bool datastate = InputNum.SafeInput(inputdata);
            if (datastate == true)
            {
                long Longdata = long.Parse(inputdata);
                InputNum.Value1 = Longdata;
            }
            else
            {
                InputNum.Value1 = 0;
                textBox1.Clear();
            }


        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string inputdata = textBox2.Text;
            bool datastate = InputNum.SafeInput(inputdata);
            if (datastate == true)
            {
                long Longdata = long.Parse(inputdata);
                InputNum.Value2 = Longdata;
            }
            else
            {
                InputNum.Value2 = 0;
                textBox2.Clear();
            }
        }
        //14 rader kod. plus med textBox1 är det 28 rader kod

        //storleken på koden är ungefär lika stor mellan den seperata metoden och den sammalagda koden(textbox1 + textbox2) med samma funktion.
        //Den onödig delen i denna metod är den del som ska avgöra vilken box den ska ändra osv, Det är detta som gör metoden större än det skulle ha behövt.
        //Därför kan jag lika gärna ha koden direkt i textBoxfunktionerna än att dela på en metod. 
        //För det skulle ändå blivit ungfär lika stor kod ändå och ta bort onödig sortings funktion

        //private void UpdateValue(string data, string RefCall)
        //{
        //    bool inputState = InputNum.SafeInput(data);
        //    if (inputState == true)
        //    {
        //        long Longdata = long.Parse(data);
        //        if(RefCall == "Box1")
        //        {
        //            InputNum.Value1 = Longdata;
        //        }
        //        else if(RefCall == "Box2")
        //        {
        //            InputNum.Value2 = Longdata;
        //        }
        //    }
        //    else if(inputState == false)
        //    {
        //        if (RefCall == "Box1")
        //        {
        //            InputNum.Value1 = 0;
        //            textBox1.Clear();
        //        }
        //        else if (RefCall == "Box2")
        //        {
        //            InputNum.Value2 = 0;
        //            textBox2.Clear();
        //        }
        //    }
        //}
        //// totalt 29 Rader 


        


    }
}

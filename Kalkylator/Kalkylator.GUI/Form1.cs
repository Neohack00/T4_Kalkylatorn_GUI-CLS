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
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string inputdata = textBox1.Text;
            SafeInput(inputdata, "Value 1");
            
          

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string inputdata = textBox2.Text;
            SafeInput(inputdata, "Value 2");

        }

        private void SafeInput(string inputdata, string sender)
        {
            
            bool letterfree = true;
            bool markfree = true;
            bool numberApproved = false;
            string abc = "abcdefghijklmnopqrstuvwxyzåäö";
            string ABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";
            string markers = "!#¤%&/()=?`´'*^~¨-_., <>½";

            foreach (char inputwordx in inputdata)
            {
                string strx = inputwordx.ToString();
                for (int i = 0; i <= 9; i++)
                {
                    string stri = i.ToString();
                    if (strx == stri)
                    {
                        numberApproved = true;
                    }
                }
                foreach (char smallLetters in abc)
                {
                    string StrSletters = smallLetters.ToString();
                    if (StrSletters == strx)
                    {
                        letterfree = false;
                    }
                }
                foreach (char BigLetters in ABC)
                {
                    string StrBletters = BigLetters.ToString();
                    if (StrBletters == strx)
                    {
                        letterfree = false;
                    }
                }
                foreach (char mark in markers)
                {
                    string Strmark = mark.ToString();
                    if (Strmark == strx)
                    {
                        markfree = false;
                    }
                }
            }
           
            if (sender == "Value 1")
            {
                if (textBox1.Visible == true && numberApproved == true && letterfree == true && markfree == true)
                {
                    long longdata = long.Parse(inputdata);
                    InputNum.Value1 = longdata;

                }
                else
                {

                    InputNum.Value1 = 0;
                    textBox1.Clear();              
                }
            }
            else if (sender == "Value 2")
            {
                if (textBox2.Visible == true && numberApproved == true && letterfree == true && markfree == true)
                {
                    long longdata = long.Parse(inputdata);
                    InputNum.Value2 = longdata;
                }
                else
                {

                    InputNum.Value2 = 0;
                    textBox2.Clear();
                }

            }
        }


    }
}

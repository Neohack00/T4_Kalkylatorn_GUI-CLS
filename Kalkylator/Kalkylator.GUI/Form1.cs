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
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string inputdata = textBox1.Text;
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


            if (textBox1.Visible == true && numberApproved == true && letterfree == true && markfree == true)
            {
                long longdata = long.Parse(inputdata);
                InputNummber1.Num1 = longdata;
            }
            else
            {
                textBox1.Clear();
            }

        }

    }
}

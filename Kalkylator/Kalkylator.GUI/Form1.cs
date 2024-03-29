﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kalk.Component;
namespace Kalkylator.GUI
{
    public partial class Form1 : Form
    {
        Kalk.Component.Kalkylator InputNum = new Kalk.Component.Kalkylator();
       
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

        //Add button
        private void button1_Click(object sender, EventArgs e)
        {
            InputNum.Add();
            ShowResult();
        }
        //Sub Button
        private void button2_Click(object sender, EventArgs e)
        {
            InputNum.Sub();
            ShowResult();
        }

        //Div Button
        private void button3_Click(object sender, EventArgs e)
        {
            InputNum.Div();
            ShowResult();
        }
        //Mult Button
        private void button4_Click(object sender, EventArgs e)
        {
            InputNum.Mult();
            ShowResult();

        }

        private void ShowResult()
        {
            listBox1.Items.Add(string.Format("{0} {1} {2} = {3}", InputNum.Value1, InputNum.Operation, InputNum.Value2, InputNum.Result));   
        }
    }
}

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

        //Add button
        private void button1_Click(object sender, EventArgs e)
        {
            long result = InputNum.Add();
            listBox1.Items.Add(result);
        }
    }
}

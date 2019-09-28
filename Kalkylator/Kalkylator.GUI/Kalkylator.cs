using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkylator.GUI
{
    class Kalkylator
    {
        public long Value1 { get; set; }
        public long Value2 { get; set; }
        
        public long Add()
        {
            long result = Value1 + Value2;
            return result;
        }
        public long Sub()
        {
            long result = Value1 - Value2;
            return result;
        }
        public long Div()
        {
            long result = Value1 / Value2;
            return result;
        }
        public long Mult()
        {
            long result = Value1 * Value2;
            return result;
        }





        public bool SafeInput(string inputdata)
        {

            bool letterfree = true;
            bool markfree = true;
            bool numberApproved = false;
            bool approved;
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


            if(numberApproved == true && letterfree == true && markfree == true)
            {
                approved = true;
                return approved;
            }
            else
            {
                approved = false;
                return approved;
            }



            }
        }
}

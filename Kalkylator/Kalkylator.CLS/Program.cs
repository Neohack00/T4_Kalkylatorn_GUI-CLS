using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kalk.Component;

namespace Kalkylator.CLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Kalk.Component.Kalkylator Kalkylator = new Kalk.Component.Kalkylator();
            string inputdata1;
            long longData;
            string inputdata2;
            bool ReDo = true;
            string UserChoice;


            while (ReDo == true)
            {
                Console.WriteLine("Welcome to Kalkylator.CLS");
                Console.WriteLine("You will select two value that will be calculated on an chossen operation\n");
                Console.WriteLine("Let's start with select one of the folling Operation you want to use");
                do
                {
                    Console.WriteLine("Addition (+)\nSubtraction (-)\nDivision (/)\nMultiplication (*)");
                    Console.WriteLine("Type in the operations symbols to select it: ");
                    UserChoice = Console.ReadLine();
                    if (UserChoice == "+")
                    {
                        Kalkylator.Operation = '+';
                    }
                    else if(UserChoice == "-")
                    {
                        Kalkylator.Operation = '-';
                    }
                    else if (UserChoice == "/")
                    {
                        Kalkylator.Operation = '/';

                    }
                    else if (UserChoice == "*")
                    {
                        Kalkylator.Operation = '*';
                    }
                    Console.Clear();
                } while (UserChoice != "*" && UserChoice != "/" && UserChoice != "+" && UserChoice != "-");
                bool inputState = false;
               
                do
                {
                    Console.Clear();
                    Console.WriteLine("Enter Value 1: ");
                    inputdata1 = Console.ReadLine();            
                    inputState = Kalkylator.SafeInput(inputdata1);
                } while (inputState == false);
                longData = long.Parse(inputdata1);
                Kalkylator.Value1 = longData;
      
                do
                {
                    Console.Clear();
                    Console.WriteLine("{0} {1}", Kalkylator.Value1, Kalkylator.Operation);
                    Console.WriteLine("Enter Value 2: ");
                    inputdata2 = Console.ReadLine();
                    inputState = Kalkylator.SafeInput(inputdata2);
                } while (inputState == false);
                longData = long.Parse(inputdata2);
                Kalkylator.Value2 = longData;
                if (Kalkylator.Operation == '+')
                {
                    Kalkylator.Add();
                }
                else if (Kalkylator.Operation == '-')
                {
                    Kalkylator.Sub();
                }
                else if (Kalkylator.Operation == '/')
                {
                    Kalkylator.Div();
                }
                else if (Kalkylator.Operation == '*')
                {
                    Kalkylator.Mult();
                }
                Console.Clear();
                Console.WriteLine("{0} {1} {2} = {3}\n", Kalkylator.Value1 , Kalkylator.Operation , Kalkylator.Value2 , Kalkylator.Result);
                do
                {
                    Console.WriteLine("Do you want to restart? 'Yes' or 'No': ");
                    UserChoice = Console.ReadLine();
                    if (UserChoice == "Yes" || UserChoice == "yes")
                    {
                        Console.Clear();
                    }
                    if (UserChoice == "No" || UserChoice == "no")
                    {
                        Console.WriteLine("Goodbye");
                        ReDo = false;
                    }
                } while (UserChoice != "yes" && UserChoice != "Yes" && UserChoice != "no" && UserChoice != "No");

                            }
        }
    }
}

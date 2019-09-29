using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkylator.CLS
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputdata1;
            string inputdata2;
            bool ReDo = true;
            string UserChoice;



            Console.WriteLine("Welcome to Kalkylator.CLS");
            Console.WriteLine("You will select two value that will be calculated on an chossen operation\n");
            
            Console.WriteLine("Let's start with select one of the folling Operation you want to use");
            Console.WriteLine("Addition (+)\nSubtraction (-)\nDivision (/)\nMultiplication (*)");
            Console.WriteLine("Type in the operations symbols to select it");
            //if satser som avgör vilken symbol som använder har valt. Plus en do sats för att gör inputet säkert.
            Console.Clear();
            Console.WriteLine("Enter Value 1: ");
            inputdata1 = Console.ReadLine();
            //Skickar in datan på SafeInput för kontrollera om datan är ett nummer. Om detta är så fortsätt om inte skriv igen
            //Omvandlar stringen till en Long och för in den till Kalkylator.Value1
            Console.WriteLine("'Value 1' 'Operation' ");
            Console.WriteLine("Enter Value 2");
            inputdata2 = Console.ReadLine();



            //beror på vilken räken operation som har valts så kallas Kalkylator klassen för utföra uträkningem
            //Kommer sen Skrivas ut resultat från de förvarande proppsen i Klassen.
            //Allt det kommer vara i en while loop där användaren kommer till frågas om den vill fortsätta eller sluta. Om sluta bryter vi loopen.

        }
    }
}

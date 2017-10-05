//prompt the user to enter a language. Based on the language the user input, display "Hello!" in that language.
//Use a switch statement to choose what to display. 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a language: ");

            string lang = Console.ReadLine();

            switch (lang)
            {
                case "French":
                    Console.WriteLine("Bonjour!");
                    break;

                case "Spanish":
                    Console.WriteLine("Hola!");
                    break;
                case "German":
                    Console.WriteLine("Guten Tag!");
                    break;
                case "Italian":
                    Console.WriteLine("Ciao!");
                    break;



            }       






        }
    }
}

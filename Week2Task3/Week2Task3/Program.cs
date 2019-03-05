using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks for the users first and last name and stores them in separate variables.
            Console.WriteLine("Please enter your first name: ");
            var fname = Console.ReadLine();

            //asks for the last name of the user
            Console.WriteLine("Please enter your last name: ");
            var lname = Console.ReadLine();

            //concatenates the 2 variables together to create 1 variable with both names joined.
            var fullname = fname + " " + lname;
            Console.WriteLine("Your name is {0}", fullname); //displays the users name using the variable "fullname" instead or "fname" and "lname"

            Console.ReadLine();
        }
    }
}

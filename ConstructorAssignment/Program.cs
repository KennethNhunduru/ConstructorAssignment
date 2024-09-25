using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a const variable.
            const string lastName = "Nhunduru";

            //Create a variable using the keyword “var.”

            var firstName = "Kenneth"; //The type for firstName is implied

            var fullName = firstName + " " + lastName; //The type for fullname is implied

            Console.WriteLine("Your full name is {0} ", fullName);
            Console.ReadLine();

        }
    }
}

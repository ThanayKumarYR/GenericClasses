using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generic classes !Starting the project");
            try
            {
                //Largest among integer numbers
                IntegerObject integer = new IntegerObject(12, 43, 8);
                int large = Maximum.MaxOfInput(integer);
                integer.Display(large);
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            
        }
    }
}

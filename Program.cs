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
                int largeint = Maximum.MaxOfInput(integer);
                integer.PrintObject();
                integer.Display(largeint);

                //Largest among floating numbers
                FloatObject floatObject = new FloatObject(0.4f, 0.35f, 0.6f);
                float largefloat = Maximum.MaxOfInput(floatObject);
                floatObject.PrintObject();
                floatObject.Display(largefloat);
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            
        }
    }
}

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
                //Integer Testcase - 1: Largest among integer numbers
                IntegerObject integer = new IntegerObject(12, 43, 8);
                integer.PrintObject();
                int largeint = Maximum.MaxOfInput(integer);
                integer.Display(largeint);

                //Integer Testcase - 2: Largest among integer numbers
                IntegerObject integer1 = new IntegerObject(12, 43, 8,98,99,798,1890,0,76,576,45);
                integer1.PrintObject();
                int largeint1 = Maximum.MaxOfInput(integer1);
                integer1.Display(largeint1);

                //Integer Testcase - 3: Largest among integer numbers
                IntegerObject integer2 = new IntegerObject(78,87);
                integer2.PrintObject();
                int largeint2 = Maximum.MaxOfInput(integer2);
                integer2.Display(largeint2);



                //Float Testcase - 1: Largest among floating numbers
                FloatObject floatObject = new FloatObject(0.4f, 0.35f, 0.6f);
                floatObject.PrintObject();
                float largefloat = Maximum.MaxOfInput(floatObject);
                floatObject.Display(largefloat);

                //Float Testcase - 2: Largest among floating numbers
                FloatObject floatObject1 = new FloatObject(0.4f, 0.35f, 0.6f,0.4589f,1.23f,-4.78f);
                floatObject1.PrintObject();
                float largefloat1 = Maximum.MaxOfInput(floatObject1);
                floatObject1.Display(largefloat1);

                //Float Testcase - 3: Largest among floating numbers
                FloatObject floatObject2 = new FloatObject(0.35f);
                floatObject2.PrintObject();
                float largefloat2 = Maximum.MaxOfInput(floatObject2);
                floatObject2.Display(largefloat2);

                //Strings TestCase - 1: Largest among strings
                StringObject stringObject = new StringObject("Apple", "Peach", "Banana");
                stringObject.PrintObject();
                string largestring = Maximum.MaxOfInput(stringObject);
                stringObject.Display(largestring);

                //Strings TestCase - 2: Largest among strings
                StringObject stringObject1 = new StringObject("A", "B", "C","D","Z","G","K","ZZ");
                stringObject1.PrintObject();
                string largestring1 = Maximum.MaxOfInput(stringObject1);
                stringObject1.Display(largestring1);

                //Strings TestCase - 3: Largest among strings
                StringObject stringObject2 = new StringObject("Arun", "Sujan", "Thanay","Suprita","Lalitha");
                stringObject2.PrintObject();
                string largestring2 = Maximum.MaxOfInput(stringObject2);
                stringObject2.Display(largestring2);
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            
        }
    }
}

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
                //int largeint = Maximum.MaxOfInput(integer);
                //integer.Display(largeint);
                Maximum.TestMaximum(integer.Number);


                //Integer Testcase - 2: Largest among integer numbers
                IntegerObject integer1 = new IntegerObject(12, 43, 8, 98, 99, 798, 1890, 0, 76, 576, 45);
                integer1.PrintObject();
                //int largeint1 = Maximum.MaxOfInput(integer1);
                //integer1.Display(largeint1);
                Maximum.TestMaximum(integer1.Number);


                //Integer Testcase - 3: Largest among integer numbers
                IntegerObject integer2 = new IntegerObject(78, 87);
                integer2.PrintObject();
                //int largeint2 = Maximum.MaxOfInput(integer2);
                //integer2.Display(largeint2);
                Maximum.TestMaximum(integer2.Number);



                //Float Testcase - 1: Largest among floating numbers
                FloatObject floatObject = new FloatObject(0.4f, 0.35f, 0.6f);
                floatObject.PrintObject();
                //float largefloat = Maximum.MaxOfInput(floatObject);
                //floatObject.Display(largefloat);
                Maximum.TestMaximum(floatObject.Number);

                //Float Testcase - 2: Largest among floating numbers
                FloatObject floatObject1 = new FloatObject(0.4f, 0.35f, 0.6f, 0.4589f, 1.23f, -4.78f);
                floatObject1.PrintObject();
                //float largefloat1 = Maximum.MaxOfInput(floatObject1);
                //floatObject1.Display(largefloat1);
                Maximum.TestMaximum(floatObject1.Number);

                //Float Testcase - 3: Largest among floating numbers
                FloatObject floatObject2 = new FloatObject(0.35f);
                floatObject2.PrintObject();
                //float largefloat2 = Maximum.MaxOfInput(floatObject2);
                //floatObject2.Display(largefloat2);
                Maximum.TestMaximum(floatObject2.Number);

                //Strings TestCase - 1: Largest among strings
                StringObject stringObject = new StringObject("Apple", "Peach", "Banana");
                stringObject.PrintObject();
                //string largestring = Maximum.MaxOfInput(stringObject);
                //stringObject.Display(largestring);
                Maximum.TestMaximum(stringObject.Strings);

                //Strings TestCase - 2: Largest among strings
                StringObject stringObject1 = new StringObject("A", "B", "C", "D", "Z", "G", "K", "ZZ");
                stringObject1.PrintObject();
                //string largestring1 = Maximum.MaxOfInput(stringObject1);
                //stringObject1.Display(largestring1);
                Maximum.TestMaximum(stringObject1.Strings);

                //Strings TestCase - 3: Largest among strings
                StringObject stringObject2 = new StringObject("Arun", "Sujan", "Thanay", "Suprita", "Lalitha");
                stringObject2.PrintObject();
                //string largestring2 = Maximum.MaxOfInput(stringObject2);
                //stringObject2.Display(largestring2);
                Maximum.TestMaximum(stringObject2.Strings);

                //Integer TestCase - 4: Largest among integers using Generic Methode
                IntegerObject integerObject3 = new IntegerObject(1, 2, 3, 4, 5);
                integerObject3.PrintObject();
                Maximum.TestMaximum<int>(integerObject3.Number);

                //Float TestCase - 4: Largest among float using Generic Methode
                FloatObject floatObject3 = new FloatObject(0.45f,0.35f,0.98f,1.19f);
                floatObject3.PrintObject();
                Maximum.TestMaximum<float>(floatObject3.Number);

                //String TestCase - 4: Largest among string using Generic Methode
                StringObject stringObject3 = new StringObject("'1'","'3'","'45'","'99.56'");
                stringObject3.PrintObject();
                Maximum.TestMaximum<string>(stringObject3.Strings);

            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            
        }
    }
}

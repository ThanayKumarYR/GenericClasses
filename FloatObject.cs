using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    class FloatObject
    {
        public float[] Number { get; set; } = { 0, 0, 0 };

        public void Display(float num)
        {
            Console.WriteLine($"Largest number is {num}");
        }

        public void PrintObject()
        {
            Console.Write("\n The enetered floating numbers are = ");
            foreach (float item in this.Number)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
        public FloatObject(float firstnumber,float secondnumber,float thirdnumber)
        {
            Number[0] = firstnumber;
            Number[1] = secondnumber;
            Number[2] = thirdnumber;
        }
    }
}

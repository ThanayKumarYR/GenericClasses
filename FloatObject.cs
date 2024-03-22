using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    class FloatObject
    {
        public List<float> Number { get; set; } = new List<float>();

        public void Display(float num)
        {
            Console.WriteLine($"Largest float is {num}");
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
        public FloatObject(params float[] floats)
        {
            foreach (var item in floats)
            {
                Number.Add(item);
            }
        }
    }
}

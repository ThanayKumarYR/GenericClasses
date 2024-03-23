using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    class Maximum
    {
        public static int MaxOfInput(IntegerObject  integer) 
        {
            int large = 0;
            foreach (int item in integer.Number)
            {
                if (large < item) large = item;
            }
            PrintMax<int>(large);
            return large;
        }

        public static float MaxOfInput(FloatObject floatnumber)
        {
            float large = 0;
            foreach (float item in floatnumber.Number)
            {
                if (large < item) large = item;
            }
            PrintMax<float>(large);
            return large;
        }

        public static string MaxOfInput(StringObject stringObject)
        {
            string large = "";
            foreach (string item in stringObject.Strings)
            {
                if (large.CompareTo(item) < 0) large = item;
            }
            PrintMax<string>(large);
            return large;
        }

        public static void PrintMax<T>(T variable)
        {
            string items = string.Join(Environment.NewLine, variable);
            Console.WriteLine("Printing the largest via Generic Method: " + items);
        }

        public static void TestMaximum<T>(List<T> arr)
        {
            T large = arr.ElementAt(0);
            foreach (T item in arr)
            {
                if(Comparer<T>.Default.Compare(large,item)<0) large = item;
            }
            PrintMax<T>(large);  
        }
    }
}

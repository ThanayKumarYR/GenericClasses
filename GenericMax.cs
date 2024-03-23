using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    public class GenericMax<T>
    {
        private T[] Values { get; set; }

        public GenericMax(params T[] values)
        {
            Values = values;
            PrintArray();
        }

        private void PrintArray()
        {
            Console.Write($"\nArray type is '{Values.GetType()}' and values are = ");
            foreach (T item in Values)
            {
                Console.Write(item+ ", ");
            }
            Console.WriteLine();
        }

        private static void PrintMax(T variable)
        {
            Console.WriteLine("Printing the largest via Generic Class: " + variable);
        }

        public void TestMaximum()
        { 
            T large = Values[0];
            foreach (T item in Values) 
            {
                if(Comparer<T>.Default.Compare(large,item)<0) large = item;
            }
            PrintMax(large);
        }
    }
}

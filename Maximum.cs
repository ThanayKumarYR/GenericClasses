﻿using System;
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
            return large;
        }

        public static float MaxOfInput(FloatObject floatnumber)
        {
            float large = 0;
            foreach (float item in floatnumber.Number)
            {
                if (large < item) large = item;
            }
            return large;
        }
    }
}
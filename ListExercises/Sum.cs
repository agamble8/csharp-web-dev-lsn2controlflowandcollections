using System;
using System.Collections.Generic;
using System.Text;

namespace ListExercises
{
    class Sum
    {
        public static float AddList(List<float> args)
        {
            float total = 0;
            foreach(float item in args) {
                total += item;

            }
            return total;
        }
    }
}

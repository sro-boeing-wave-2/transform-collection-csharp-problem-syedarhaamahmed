using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public static class Transform 
    {
        public static int [] Map(this int[] x, Func<int, int> y)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = y(x[i]);
            }
            return x;
        }
    }
}

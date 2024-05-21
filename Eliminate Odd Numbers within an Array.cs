using System;
using System.Collections.Generic;
using System.Linq;

public class Program
    {
        public static int[] NoOdds(int[] arr)
        {
					return arr.Where(number => number % 2 == 0).ToArray();
        }
    }

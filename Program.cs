using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
//using System.

namespace GoogleQual
{
    class Program
    {
        List<int> tempHolding = new List<int>();
        static int count = 0;
        static void Main(string[] args)
        {
            
            List<int> plates = new List<int>();
            //read in file here,
            //OR, fill in your own numbers below for testing:
            //++++++++++++++++++++++++++
            plates.Add(96);
            plates.Add(1);
            plates.Add(1);
            plates.Add(1);
            //+++++++++++++++++++++++++++++++
            Solve(plates);
        }

        //THis function will only concern itself with the highest stack, and return the optimal 
        //splits vs "Eats" value. 
        public static int Solve(List<int> plates)
        {
            int highest_stack = plates.Max(); //first, lets get the max stack
            int solved = highest_stack;
            int stack = highest_stack;
            for (int flatten = 1; flatten < highest_stack; ++flatten)//
            {
                int splits = 0;
                splits += (stack - 1) / flatten; //
                solved = System.Math.Min(solved, splits + flatten);// 
            }
            return solved;
        }

    }
}

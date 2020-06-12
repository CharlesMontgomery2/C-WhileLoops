using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int step = 0;       // The loop will start at at zero but line 16 adds 1 to the step            
            while (step < 10)   // while loop will state that the step will stop at 9 which line 16 will add 1 the step to be 10
            {
                Console.WriteLine(step + 1); // This will display the number of steps 
                step++;  // Controls the loop adding 1 to each time it is looped so that eventually will hit step < 10
            }
            Console.WriteLine();
        }
    }
}

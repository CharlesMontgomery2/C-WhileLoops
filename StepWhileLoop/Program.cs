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
            int step = 0;
            while (step < 10)
            {
                Console.WriteLine(step + 1);
                step++;
            }
            Console.WriteLine();
        }
    }
}

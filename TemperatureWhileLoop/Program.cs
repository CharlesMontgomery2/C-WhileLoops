using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureWhileLoop
{
    class Program //Battle wants wrong battle?
    {

        static double FtoC(double tempInF)  //Method to convert Temp
        {
            return (tempInF - 32) * 5 / 9; //This will return what ever answer for the equation
        }
        static void Main(string[] args)
        {
            int step = 0;  //This starts the loop at step 0
            while (step < 10)  // This will stop the loop step at 9 which is less than 10
            {
                //(32°F − 32) × 5/9 = 0°C is the formula to convert F° to C°
                double F = step * 10; // The step for each loop will multiply by 10
                double C = FtoC(F); // C° is converted by the method which returns the degrees in F°
                Console.WriteLine($"line {step}: {F:F2}°F = {C:F3}°C"); // $ uses the step as a variable F2 will give 2 decimal points
                step++; // This will control the loop by adding 1 each time it loops through with out it it will loop the same first loop infinately

            }
        }
    }
}


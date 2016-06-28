using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto myCar = new Auto();
            myCar.currentSpeed = 0;
            myCar.Model = "SwiftDezire";
            myCar.Year = 2009;
            myCar.Maker = "volvo";
            myCar.Miles = 50000;
            myCar.Color = "Silver";
            Console.WriteLine(myCar.Maker + "  " + myCar.Model);

            int myCurrentSpeeed = 0;
            myCurrentSpeeed = myCar.Accelerator(3);
            myCar.Accelerator(1);
            myCar.Accelerator(2);
            myCar.Accelerator(1);
            myCurrentSpeeed = myCar.Accelerator(2);
            Console.WriteLine("The Current speed of the car is: " + myCurrentSpeeed);

            string message = myCar.speedLimitViolation(10, "Warning!");

            Console.Beep();

            Console.WriteLine(message);
            //Console.WriteLine(message1);
            myCurrentSpeeed = myCar.Decelerator(10);
            Console.WriteLine("The reduced  speed of the car is: " + myCurrentSpeeed);

            Console.ReadLine();
        }
    }
}

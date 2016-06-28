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
            
            Engine v4 = new Engine();
            v4.Size = "v4";
            v4.HorsePower = 200;
            v4.FuelConsumptionRate = 1.5;

            Engine v6 = new Engine();
            v6.Size = "v6";
            v6.HorsePower = 600;
            v6.FuelConsumptionRate = 1.6;

            Engine v8 = new Engine();
            v8.Size = "v8";
            v8.HorsePower = 800;
            v8.FuelConsumptionRate = 1.8;

            //Auto myCar = new Auto();
            //myCar.Engine = v4;

            //Console.WriteLine(myCar.Engine.FuelConsumptionRate+ " and  " +myCar.Engine.HorsePower);
            //Console.ReadLine();

            AssemblyRobot Robot = new AssemblyRobot();
            Auto newCar = Robot.AssemblyCar("154li", v8);

            Console.WriteLine(newCar.Engine.FuelConsumptionRate+ " and  " +newCar.Engine.HorsePower);
            //Console.ReadLine();

            newCar.customer.LastName = "Nalubolu";
            newCar.customer.Address = "vemdalsgatan 51";
            newCar.customer.DateOfPurchace = DateTime.Now;
            Console.WriteLine("my last Name :" + " " + newCar.customer.DateOfPurchace);
            Console.ReadLine();
            
            
           
        }
        
        
    }
}

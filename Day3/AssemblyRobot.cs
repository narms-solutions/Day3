using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class AssemblyRobot
    {
        public Auto AssemblyCar(int year,Engine engineType)
        {
            Auto myCar = new Auto();
            myCar.Year = year;
            myCar.Engine = engineType;
            return myCar;
        }
    }
}

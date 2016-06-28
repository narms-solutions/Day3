using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class AssemblyRobot
    {
        public Auto AssemblyCar(string model,Engine engineType)
        {
            Auto myCar = new Auto();
            myCar.Model = model;
            myCar.Engine = engineType;
            return myCar;
        }
    }
}

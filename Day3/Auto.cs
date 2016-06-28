using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Auto
    {
        private int speed;
        public int Year;
        public int Miles;
        private string make;
        public string Model;
        public string Color;
        public Engine Engine;

        public string Maker
        {
            get { return make; }
            set
            {
                switch (value)
                {
                    case "oldsMobile":
                        make = value;
                        break;
                    case "volvo":
                        make = value;
                        break;
                    default:
                        throw new Exception  ("invalid Maker");
                        
                }
               
            }
        }
        public int currentSpeed
        {
            get { return speed; }
            set
            {
                if (value < 0)
                    speed = 0;
                else if (value > 10)
                    speed = 10;
                else
                    speed = value;
            }
        }


        public int Accelerator(int incrementedSpeed)
        {
            currentSpeed += incrementedSpeed;
            myText("the current speed:" + speed);
            return currentSpeed;

        }
        public int Decelerator(int decrementedSpeed)
        {
            currentSpeed -= decrementedSpeed;
            myText("The current speed:" +speed);
            return currentSpeed;
        }
        public string speedLimitViolation(int speedLimit, string initialMessage)
        {
            string message = "";
            if (currentSpeed > speedLimit)
                // initialMessage = "warning!";
                message = initialMessage + "Too Fast!";
            else
                message = "No worries !! It's ok!";
            //initialMessage = "No worries!";
            return message;
        }

        private void myText(string message)
        {
            Console.Write("From Helper Method....");
            Console.WriteLine(message);

        }
   


        }
    }

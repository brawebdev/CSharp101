using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Value_Types
{
    class Program
    {
        public enum GenderType
        {
            Male = 1, Female, Unknown
        }

        static void Main(string[] args)
        {
            //-- Declaration
            int myAge;

            //-- Initialization
            myAge = 23;

            //-- Integer Types
            byte by = 255;
            short s = 32767;
            int i = 100;
            long yTMinutesWatched = 999999999999999999;
            float PI = 3.1415926f;
            double d = 780.23d;
            decimal p = 7.8m;
            int? noValue = null;

            //-- Booleans
            bool isEarly = true;

            //-- Boolean Logic/Conditionals
            if (isEarly)
                Console.WriteLine("Need more coffee.");

            //-- Declare Enum
            GenderType myGender = GenderType.Male;

            switch (myGender)
            {
                case GenderType.Female:
                    Console.WriteLine("Welcome Miss");
                    break;
                case GenderType.Male:
                    Console.WriteLine("Welcome Sir");
                    break;
                case GenderType.Unknown:
                    Console.WriteLine("Welcome");
                    break;
            }
        }
    }
}

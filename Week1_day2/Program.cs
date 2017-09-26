using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_day2
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstInitial = 'N';

            bool isTired = true;

            float number = 2.164403304907294849383961032f;
            decimal partialNum = 2.164403304907294849383961032m;
            double someNumber = 2.164403304907294849383961032;

            Console.WriteLine(number);
            Console.WriteLine(partialNum);
            Console.WriteLine(someNumber);

            // % modulus divides and checks remainders

            int jarrydAge = 32;
            int danielAge = 33;
            Console.WriteLine(jarrydAge == danielAge);
            Console.WriteLine(jarrydAge != danielAge);
        }
    }
}

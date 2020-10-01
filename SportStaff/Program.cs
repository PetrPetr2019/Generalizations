using System;
using System.Collections.Generic;

namespace SportStaff
{
    class Program
    {
        static void Main(string[] args)
        {

            var stuList = new List<Students<int, bool>>
            {
                new  Students<int, bool>("Tomas", 22, 2, true, 5),
                new Students<int, bool>("Jimm", 18, 1, false, 4)
                
            };
          

            Console.ReadLine();

        }
    }
}

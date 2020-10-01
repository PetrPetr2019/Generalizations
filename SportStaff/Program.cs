using System;
using System.Collections.Generic;

namespace SportStaff
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Ctudents<int, bool>> stuList = new List<Ctudents<int, bool>>
            {
                new  Ctudents<int, bool>("Tomas", 22, 2, true, 5),
                new Ctudents<int, bool>("Jimm", 18, 1, false, 4)
                
            };
          

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitBranches
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("Ford");

            Console.WriteLine(c1.getName());
            Console.ReadKey();
        }
    }
}

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
            Engine e1 = new Engine(2000);

            Console.WriteLine(e1.getCapacity());
            Console.ReadKey();
            //comment
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitBranches
{
    class Engine
    {
        private int Capacity;

        public Engine(int capacity)
        {
            this.Capacity = capacity;
        }

        public int getCapacity()
        {
            return this.Capacity;
        }
    }
}

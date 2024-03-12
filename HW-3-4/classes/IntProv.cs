using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_4
{
    internal class IntProv : IProvider<int>
    {
        public int Rand()
        {
            Random rnd = new Random();
            return rnd.Next(0, 1000);
        }
        public int ByUser()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}

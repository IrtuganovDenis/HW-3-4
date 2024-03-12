using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_4
{
    internal class BoolProv : IProvider<bool>
    {
        public bool Rand()
        {
            Random rnd = new Random();
            bool[] a = new bool[] { true, false };
            return a[rnd.Next(0, 1)];
        }

        public bool ByUser()
        {
            return int.Parse(Console.ReadLine()) == 1;
        }

    }
}

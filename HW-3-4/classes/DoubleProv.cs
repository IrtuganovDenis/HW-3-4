using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_4
{
    internal class DoubleProv : IProvider<double>
    {
        Random rnd = new Random();
        public double Rand()
        {
            return Math.Round(rnd.NextDouble(), 3) + rnd.Next(0, 1000);
        }

        public double ByUser()
        {
            return double.Parse(Console.ReadLine());
        }

    }
}

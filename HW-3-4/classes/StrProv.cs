using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_4
{
    internal class StrProv : IProvider<string>
    {
        private static Random rnd = new Random();
        public string Rand()
        {
            string s = "";
            string abs = "abcdefghijklmnopqrstuvwxyz";
            int n = rnd.Next(1, 10);
            for (int i = 0; i < n; i++)
            {
                s += abs[rnd.Next(26)];
            }
            return s;
        }

        public string ByUser()
        {
            return Console.ReadLine();
        }
    }
}

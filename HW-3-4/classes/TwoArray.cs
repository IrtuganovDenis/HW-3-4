using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_4
{
    sealed class TwoArray<T> : BaseClass<T>
    {
        private static int n;
        private static int m;
        public T[,] a;

        public TwoArray(IProvider<T> provider, bool B) : base(provider, B) { }

        /*
        public override void Fill(bool B)
        {
            if (B)
            {
                FillByUser();
            }
            else
            {
                RandFill();
            }

        }
        */

        protected override void FillByUser()
        {
            Console.WriteLine("Введите количество элементов массива:");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите элементы массива:");
            a = new T[n, m];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = provider.ByUser();
                }
            }
        }

        protected override void RandFill()
        {
            Random rnd = new Random();
            n = rnd.Next(1, 100);
            m = rnd.Next(1, 100);
            T[,] a = new T[n, m];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = provider.Rand();
                }
            }
        }

        public override void Print()
        {
            Console.WriteLine("Двумерный массив:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}

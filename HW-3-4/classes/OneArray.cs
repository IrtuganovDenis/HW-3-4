using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_4
{
    sealed class OneArray<T> : BaseClass<T>
    {
        private int n;
        private bool b = false;
        public T[] a;

        public OneArray(IProvider<T> provider, bool B) : base(provider, B){ }


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
            Console.WriteLine("Введите элементы массива:");
            a = new T[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = provider.ByUser();
            }
        }

        protected override void RandFill()
        {
            Random rnd = new Random();
            n = rnd.Next(1, 100);
            a = new T[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = provider.Rand();
            }
        }

        public override void Print()
        {
            Console.WriteLine("Одномерный массив:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        
    }
}
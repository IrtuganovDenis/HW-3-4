using HW_3_4;
using System;
using System.Reflection;
using System.Security.Claims;

namespace HW_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m, t;
            bool b;

            BoolProv bp = new BoolProv();
            DoubleProv dp = new DoubleProv();
            IntProv ip = new IntProv();
            StrProv sp = new StrProv();
            IPrinter[] array = new IPrinter[8];


            Console.WriteLine("Введите количество эелементов одномерного массива");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите способ ввода элементов одномерного массива (1 - вручную, 0 - рандомно)");
            t = int.Parse(Console.ReadLine());
            b = t == 1 ? true : false;
            array[0] = new OneArray<bool>(bp, b);
            array[1] = new OneArray<double>(dp, b);
            array[2] = new OneArray<int>(ip, b);
            array[3] = new OneArray<string>(sp, b);


            Console.WriteLine("Введите размер двумерного массива");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите способ ввода элементов двумерного массива (1 - вручную, 0 - рандомно)");
            t = int.Parse(Console.ReadLine());
            b = t == 1 ? true : false;
            array[0] = new TwoArray<bool>(bp, b);
            //array[1] = new OneArray<double>(dp, b);
            //array[2] = new OneArray<int>(ip, b);
            //array[3] = new OneArray<string>(sp, b);

            foreach (IPrinter a in array)
            {
                array.Print();

                Console.WriteLine();
            }
        }
    }

}
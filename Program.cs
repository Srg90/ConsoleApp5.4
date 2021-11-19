using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Список из 20 случайных чисел от -50 до 50");
            Console.WriteLine();
            const int N = 20;
            int[] number = new int[N];
            Random random = new Random();
            int j = 1;
            int nechet = 0;
            int chet = 0;

            for (int i = 0; i < N; i++)
            {

                number[i] = random.Next(-50, 50);
                Console.Write("{0} ", number[i]);
                

                
            }

            Console.WriteLine();

            int k2 = number[1] % 2;
            int k4 = number[3] % 2;
            int k6 = number[5] % 2;
            int k8 = number[7] % 2;
            int k10 = number[9] % 2;
            int k12 = number[11] % 2;
            int k14 = number[13] % 2;
            int k16 = number[15] % 2;
            int k18 = number[17] % 2;
            int k20 = number[19] % 2;


            //for (int i = 0; i < N; i++)
            //{
              //  number[i] = number[i] % 2;
               // Console.Write("{0,3}", number[i]);
            //}
            // if (number[1] % 2 == 0)
            //{
            // chet++;
            //}

            if (k2 != 0 & k2 > 0)
            {
                nechet++;
            }
            if (k4 != 0 & k4 > 0)
            {
                nechet++;
            }
            if (k6 != 0 & k6 > 0)
            {
                nechet++;
            }
            if (k8 != 0 & k8 > 0)
            {
                nechet++;
            }
            if (k10 != 0 & k10 > 0)
            {
                nechet++;
            }
            if (k12 != 0 & k12 > 0)
            {
                nechet++;
            }
            if (k14 != 0 & k14 > 0)
            {
                nechet++;
            }
            if (k16 != 0 & k16 > 0)
            {
                nechet++;
            }
            if (k18 != 0 & k18 > 0)
            {
                nechet++;
            }
            if (k20 != 0 & k20 > 0)
            {
                nechet++;
            }

                         
            Console.WriteLine();
            Console.WriteLine("Число 2 в списке = {0} ", number[1]);
            Console.WriteLine("Число 4 в списке = {0} ", number[3]);
            Console.WriteLine("Число 6 в списке = {0} ", number[5]);
            Console.WriteLine("Число 8 в списке = {0} ", number[7]);
            Console.WriteLine("Число 10 в списке = {0} ", number[9]);
            Console.WriteLine("Число 12 в списке = {0} ", number[11]);
            Console.WriteLine("Число 14 в списке = {0} ", number[13]);
            Console.WriteLine("Число 16 в списке = {0} ", number[15]);
            Console.WriteLine("Число 18 в списке = {0} ", number[17]);
            Console.WriteLine("Число 20 в списке = {0} ", number[19]);


            
            Console.WriteLine();
            //Console.WriteLine("Количество четных чисел = {0}", +chet);
            Console.WriteLine();
            Console.WriteLine("Количество положительных нечетных чисел = {0}", +nechet);
            Console.WriteLine();
            
            Console.ReadKey();
        }
    }
}

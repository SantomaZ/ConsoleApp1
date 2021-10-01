using System;
using System.Linq;

namespace TESTING
{
    class Program
    {
        static void Main(string[] args)

        {

            while (true)

            { 

                try

                {

                Console.Write("Введи количество элементов: ");

                int quan = int.Parse(Console.ReadLine());

                int[] mass = new int[quan];

                for (int i = 0; i < quan; i++)

                {

                    Console.Write("Введи " + (i + 1) + "й элемент: ");

                    mass[i] = int.Parse(Console.ReadLine());

                }

                for (int i = 0; i < quan - 1; i++)

                {

                    Console.Write(mass[quan - 1 - i] + ", ");

                }

                Console.Write(mass[0]);

                Console.WriteLine();

                int sum = 0;

                for (int i = 0; i < quan; i++)

                {

                    sum = (mass[i] % 2) == 0 ? sum + mass[i] : sum + 0;

                }

                Console.WriteLine("Сумма чётных чисел: " + sum + "!");

                int cont = mass[0];

                for (int i = 0; i < quan; i++)

                {

                cont = mass[i] < cont ? cont = mass[i] : cont;

                }

                Console.WriteLine("Наименьшее число: " + cont);

                    Console.WriteLine(mass.Where(i=> i % 2 == 0).Sum());

                    int[] result = mass.OrderByDescending(i => i).ToArray();

                   

                }

                catch

                {
                Console.WriteLine("Еще раз!");
                }

            Console.ReadLine();

            }

        }
    }
}

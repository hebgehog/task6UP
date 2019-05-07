using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6UP
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1, a2, a3, M, N = 0, counter = 0, jj = 0, ak = 0;
            bool exit = false;
            Console.WriteLine("Введите N: ");
            while (!exit)
            {
                N = wwww();
                if (N < 3) { Console.WriteLine("Миниальная длинна послдовательности 3, повторите ввод"); }
                else { exit = true; }
            }
            Console.WriteLine("Введите а1: ");
            a1 = wwww();
            Console.WriteLine("Введите а2: ");
            a2 = wwww();
            Console.WriteLine("Введите а3: ");
            a3 = wwww();
            Console.WriteLine("Введите M: ");
            M = wwww();
            List<int> list = new List<int>();
            list.Add(a1);
            list.Add(a2);
            list.Add(a3);

            while (list.Count < N)
            {
                ak = list.ElementAt(list.Count - 3) + ((list.ElementAt(list.Count - 2)) / 3) + (3 * list.ElementAt(list.Count - 1));
                list.Add(ak);
            }
            Console.WriteLine("Вывод последовательности: ");
            foreach (int s in list)
                Console.Write(s + " ");
            Console.WriteLine("\nНомера элементов равных M: ");
            foreach (int g in list)
            {
                jj++;
                if (g == M) { counter++; Console.Write(jj); }
            }
            if (counter == 0) { Console.WriteLine("Нет таких элементов"); }
            else
            {
                Console.WriteLine("\nКоличество таких элементов: " + counter);
            }
            Console.ReadKey();
        }
        static int wwww()
        {
            while (true)
            {
                int number;
                if (int.TryParse(Console.ReadLine(), out number))
                    return number;
                else
                    Console.WriteLine("Ошибка, введите еще раз");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace task6UP
{
    class Program
    {
        static void Main(string[] args)
        {
            float a1, a2, a3, M;
            int N = 0, counter = 0, jj = 0;
            float ak = 0;
            bool exit = false;
            Console.WriteLine("Введите N: ");
            while (!exit){
                N = wwww1();
                if (N < 3) { Console.WriteLine("Минимальная длинна последовательности 3, повторите ввод"); }
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
            List<float> list = new List<float>();
            list.Add(a1);
            list.Add(a2);
            list.Add(a3);
            while (list.Count < N){
                ak = list.ElementAt(list.Count - 1) + ((list.ElementAt(list.Count - 2)) / 3) + (3 * list.ElementAt(list.Count - 3));
                list.Add(ak);
            }
            Console.WriteLine("Вывод последовательности: ");
            foreach (float s in list)
                Console.Write(s + " ");
            Console.WriteLine("\nНомера элементов равных M: ");
            string d = M.ToString("N2");
            foreach (float g in list){
                jj++;
                string dd = g.ToString("N2");
                if (d.Equals(dd)) { counter++; Console.Write(jj); }
            }
            if (counter == 0) { Console.WriteLine("Нет таких элементов"); }
            else{Console.WriteLine("\nКоличество таких элементов: " + counter);}
            Console.ReadKey();
        }
        static float wwww()
        {
            while (true){
                float number;
                if (float.TryParse(Console.ReadLine(), out number))
                    return number;
                else
                    Console.WriteLine("Ошибка, введите еще раз");
            }
        }
        static int wwww1()
        {
            while (true){
                int number;
                if (int.TryParse(Console.ReadLine(), out number))
                    return number;
                else
                    Console.WriteLine("Ошибка, введите еще раз");
            }
        }
    }
}

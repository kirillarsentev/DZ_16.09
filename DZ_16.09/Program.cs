using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_16._09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ДЗ 1.Вывести число e");
            double e = Math.Round(Math.E, 1);
            Console.WriteLine(e);



            Console.WriteLine("ДЗ 2.Вывести 2 числа одно над другим");
            string str = "50 10";
            string[] strs = str.Split();
            foreach (string strings in strs)
            {
                Console.WriteLine(strings);

            }

            Console.WriteLine("ДЗ 3. Вывести числа столбиком");
            string number = "10 20 30 40";
            string[] numbers = number.Split();
            foreach (string n in numbers)
            {
                Console.WriteLine(n);
            }


            Console.WriteLine("ДЗ 4.Вывести число на 10 больше");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num + 10);

            
        }
    }
}

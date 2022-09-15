﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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

            Console.WriteLine("ДЗ 5. Найти периметр");
            int side = 10;
            double Per = Math.Pow(side, 2);
            Console.WriteLine(Per);

            Console.WriteLine("ДЗ 6. Найти длину окружности и плошадь круга ");
            double radius = 10;
            double Pi = 3.14;
            double Length = 2 * Pi * radius;
            double S = Math.Pow(radius, 2) * Pi;
            Console.WriteLine(Length);
            Console.WriteLine(S);



            Console.WriteLine("ДЗ 7. Найти Cosx");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Math.Cos(x);
            Console.WriteLine(y);



            Console.WriteLine("ДЗ 8. Периметр трапеции");
            double base_1 = 10;
            double base_2 = 30;
            double height = 10;
            double d = (base_2 - base_2) / 2;
            double c = d * d + height * height;
            Console.WriteLine(base_1 + base_2 + 2 * c);


            Console.WriteLine("ДЗ 9.Найти стоимость покупки");
            double apple = 2;
            double candies = 3;
            double biscuit = 4;
            double apple_kg = 30;
            double candies_kg = 35;
            double biscuit_kg = 40;
            Console.WriteLine("Стоимость покупки; " + apple * apple_kg + candies * candies_kg + biscuit * biscuit_kg);


            Console.WriteLine("ДЗ 10. Вывести МИР ТРУД МАЙ");
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир\n \tТруд\n \t\tМай");




            Console.WriteLine("ДЗ 11.Вывести 2 числа");
            Console.WriteLine("Введите 2 числовые переменные:");
            string num_1 = Console.ReadLine();
            string num_2 = Console.ReadLine();

            if (double.TryParse(num_1.Replace('.', ','), out double a))
            {
                if (double.TryParse(num_2.Replace('.', ','), out double b))
                    Console.WriteLine(num_2 + " - " + num_1);
            }
            else
            {
                Console.WriteLine("Не удалось распознать первое число, попробуйте еще раз.");
            }



            Console.WriteLine("ДЗ 12.");
            Console.WriteLine("Выберите фигуру");
            string figure = Console.ReadLine();

            if (figure == "треугольник")
            {
                Console.WriteLine("Выберите площадь или периметр");
                string action = Console.ReadLine();
                if (action == "площадь")
                {
                    Console.WriteLine("Введите сторону основания треугольника");
                    Console.WriteLine("Введите высоту треугольника");


                    double triangle_side = Convert.ToDouble(Console.ReadLine());
                    double triangle_base = Convert.ToDouble(Console.ReadLine());
                    double triangel_sqr = (triangle_base * triangle_side) / 2;

                    Console.WriteLine("Введите одну из сторон четырехугольника");
                    double rectangle_1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите вторую из сторон четырехугольника");
                    double rectangle_2 = Convert.ToDouble(Console.ReadLine());

                    double rectangale = rectangle_1 * rectangle_2;

                    Console.WriteLine("Введите радиус окружности");
                    double rad = Convert.ToDouble(Console.ReadLine());
                    double square_rad = 3.14 * Math.Pow(rad, 2);


                    Console.WriteLine(" Площадь треугольника:" + triangel_sqr);
                    Console.WriteLine(" Площадь четырехугольника:" + rectangale);
                    Console.WriteLine(" Площадь круга:" + square_rad);




                }
                else if (action == "периметр")
                {
                    Console.WriteLine("Ввдите первую сторону треугольника");
                    double treug1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ввдите вторую сторону треугольника");
                    double treug2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ввдите третью сторону треугольника");
                    double treug3 = Convert.ToDouble(Console.ReadLine());

                    double per_treug = treug1 + treug2 + treug3;

                    Console.WriteLine("Ввдите первую сторону четырехугольника");
                    double chet1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ввдите вторую сторону четырехоугольника");
                    double chet2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ввдите третью сторону четырехугольника");
                    double chet3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ввдите четвертую сторону четырехоугольника");
                    double chet4 = Convert.ToDouble(Console.ReadLine());

                    double per_chet = chet1 + chet2 + chet3 + chet4;

                    Console.WriteLine("Ввдите радиус окружности");
                    double rad_1 = Convert.ToDouble(Console.ReadLine());

                    double per_krug = 2 * 3.14 * rad_1;

                    Console.WriteLine(" Периметр треугольника:" + per_treug);
                    Console.WriteLine(" Периметр четырехоугольника:" + per_chet);
                    Console.WriteLine(" Периметр круга:" + per_krug);


                }

            }
            else if (figure == "четырехугольник")
            {
                Console.WriteLine("Выберите площадь или периметр");
                string action = Console.ReadLine();
                if (action == "площадь")
                {

                    Console.WriteLine("Введите одну из сторон четырехугольника");
                    double rectangle_1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите вторую из сторон четырехугольника");
                    double rectangle_2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите высоту треугольника");
                    double triangle_side = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите сторону основания треугольника");
                    double triangle_base = Convert.ToDouble(Console.ReadLine());
                    double triangel_sqr = (triangle_base * triangle_side) / 2;

                    double rectangale = rectangle_1 * rectangle_2;

                    Console.WriteLine("Введите радиус окружности");
                    double rad = Convert.ToDouble(Console.ReadLine());
                    double square_rad = 3.14 * Math.Pow(rad, 2);

                    Console.WriteLine(" Площадь четырехоугольника:" + rectangale);
                    Console.WriteLine(" Площадь треугольника:" + triangel_sqr);
                    Console.WriteLine(" Площадь круга:" + square_rad);




                }
                else if (action == "периметр")
                {
                    Console.WriteLine("Ввдите первую сторону четырехугольника");
                    double chet1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ввдите вторую сторону четырехоугольника");
                    double chet2 = Convert.ToDouble(Console.ReadLine());

                    double per_chet = (chet1 + chet2) * 2;


                    Console.WriteLine("Ввдите первую сторону треугольника");
                    double treug1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ввдите вторую сторону треугольника");
                    double treug2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ввдите третью сторону треугольника");
                    double treug3 = Convert.ToDouble(Console.ReadLine());

                    double per_treug = treug1 + treug2 + treug3;

                    Console.WriteLine("Введите радиус окружности");
                    double rad_1 = Convert.ToDouble(Console.ReadLine());

                    double per_krug = 2 * 3.14 * rad_1;

                    Console.WriteLine(" Периметр круга:" + per_krug);
                    Console.WriteLine(" Периметр треугольника:" + per_treug);
                    Console.WriteLine(" Периметр четырехугольника:" + per_chet);
                    

                }

            }
            else if (figure == "круг")
            {
                Console.WriteLine("Выберите площадь или периметр");
                string action = Console.ReadLine();
                if (action == "площадь")
                {
                    Console.WriteLine("Введите радиус окружности");
                    double rad = Convert.ToDouble(Console.ReadLine());
                    double square_rad = 3.14 * Math.Pow(rad, 2);

                    Console.WriteLine("Введите одну из сторон четырехугольника");
                    double rectangle_1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите вторую из сторон четырехугольника");
                    double rectangle_2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите высоту треугольника");
                    double triangle_side = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите сторону основания треугольника");
                    double triangle_base = Convert.ToDouble(Console.ReadLine());
                    double triangel_sqr = (triangle_base * triangle_side) / 2;

                    double rectangale = rectangle_1 * rectangle_2;


                    Console.WriteLine(" Площадь круга:" + square_rad);
                    Console.WriteLine(" Площадь четырехоугольника:" + rectangale);
                    Console.WriteLine(" Площадь треугольника:" + triangel_sqr);
                    




                }
                else if (action == "периметр")
                {
                    Console.WriteLine("Введите радиус окружности");
                    double rad_1 = Convert.ToDouble(Console.ReadLine());

                    double per_krug = 2 * 3.14 * rad_1;

                    Console.WriteLine("Ввдите первую сторону треугольника");
                    double treug1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ввдите вторую сторону треугольника");
                    double treug2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ввдите третью сторону треугольника");
                    double treug3 = Convert.ToDouble(Console.ReadLine());

                    double per_treug = treug1 + treug2 + treug3;

                    Console.WriteLine("Ввдите первую сторону четырехугольника");
                    double chet1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ввдите вторую сторону четырехоугольника");
                    double chet2 = Convert.ToDouble(Console.ReadLine());

                    double per_chet = (chet1 + chet2) * 2;

                    Console.WriteLine(" Периметр круга:" + per_krug);
                    Console.WriteLine(" Периметр треугольника:" + per_treug);
                    Console.WriteLine(" Периметр четырехугольника:" + per_chet);
                    

                }
            }
            Console.WriteLine("ДЗ 13.Вывести число");
            double Chislo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Вы ввели число:" + Chislo);


            Console.WriteLine("ДЗ 14. Вывести 2 кг , 13 17");
            Console.WriteLine("2 кг\n13 17");


            Console.WriteLine("ДЗ 15. Вывести 4 случайных числа");
            Random rnd = new Random();

            string val = Convert.ToString(rnd.Next());  //Получить очередное случайное число
            string val1 = Convert.ToString(rnd.Next()); //Получить очередное случайное число
            string val2 = Convert.ToString(rnd.Next()); //Получить очередное случайное число
            string val3 = Convert.ToString(rnd.Next()); //Получить очередное случайное число
            Console.WriteLine(val + '\n'+ val1 + '\n' + val2 + '\n' + val3 + '\n');


            Console.WriteLine("ДЗ 16.Решить квадратное уравнение");
          
            Console.WriteLine("Введите число a :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число c :");
            int num_3 = int.Parse(Console.ReadLine());
            double discrim = num2*num2 - 4 * num1 * num_3;
            
            if ( discrim < 0)
            {
                Console.WriteLine("Корней нет");
            }
            else if (discrim == 0)
            {
                double x1 = -1 * num2 / 2 * num1;
                Console.WriteLine("Единственный корень : " + x1);

            }
            else
            {
                double x2 = (-num2 + Math.Pow(discrim, 0.5)) / (2 * num1);
                double x3 = (-num2 - Math.Pow(discrim, 0.5)) / (2 * num1);
                Console.WriteLine("Корень 1 : " + x2 + "\n" + "Корень 2 : " + x3);
            }

            Console.WriteLine("ДЗ 17.Среднее арифметическое , геометрическое");
            Console.WriteLine("Введите первое число");
            int var_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int var_2 = Convert.ToInt32(Console.ReadLine());
            double arph = (var_1 + var_2) / 2;
            double geom = Math.Sqrt(var_1 * var_2);
            Console.WriteLine("Средне арифметическое : " + arph + "\n" + "Средне геометрическое : " + geom);


            Console.WriteLine("ДЗ 18. Расстояние между точками");
            Console.WriteLine("Введите X1 : ");
            double x_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y1 : ");
            double y_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите X2 : ");
            double x_2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y2 : ");
            double y_2 = Convert.ToDouble(Console.ReadLine());
            double dis = Math.Sqrt(Math.Pow(x_1-x_2, 2) + Math.Pow(y_1 - y_2, 2));
            Console.WriteLine(dis);
        }
       
            
    }       
}

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
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
            foreach (string n_1 in numbers)
            {
                Console.WriteLine(n_1);
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


            Console.WriteLine("ДЗ 19. ОБмен значений.Часть а");
            string a1 = Console.ReadLine();
            string b1 = Console.ReadLine();
            string c1 = Console.ReadLine();
            string d1  = b1;
            b1 = c1;
            c1 = a1;
            a1 = d1;


            Console.WriteLine( a1 + " " + b1 + " " + c1);
            Console.WriteLine("Часть б");
            d1 = b1;
            b1 = a1;
            a1 = c1;
            c1 = d1;
            Console.WriteLine(a1 + " " + b1 + " " + c1);

            Console.WriteLine("ДЗ 20");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Прошло " + n / 3600 + " часов");
            Console.WriteLine("Прошло " + (n % 3600) / 60  + " минут");
            Console.WriteLine("Прошло " + n / 60 + " секунд");


            Console.WriteLine(" ДЗ 21. Отрезать прямоугольник");
            int size1 = 543;
            int size2 = 130;
            int area1 = size1 * size2;
            int area2 = 130 * 130;
            Console.WriteLine(area1 / area2);

            Console.WriteLine("ДЗ 22.");
            Console.WriteLine("Ведите число");
            string chislo = Console.ReadLine();
            string chislo1 = chislo.Remove(chislo.Length -1 , 1);
            Console.WriteLine(chislo[chislo.Length - 1] + chislo1 );

            Console.WriteLine("ДЗ 23");
            Console.WriteLine("Введите число > 999 :");
            int chislo_1 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Количество сотен : " + chislo_1 / 100 + '\n' + "Количество тысяч : " + chislo_1 / 1000);

            Console.WriteLine("ДЗ 24");
            string fournum = Console.ReadLine();

            Console.WriteLine("Число справа налево : " + fournum[3] + fournum[2] + fournum[1] + fournum[0]);
            Console.WriteLine("После перестановки 1 и 2, 3 и 4 цифры : " + fournum[1] + fournum[0] + fournum[3] + fournum[2]);
            Console.WriteLine("После перестановки 2 и 3 цифры : " + fournum[0] + fournum[2] + fournum[1] + fournum[3]);
            Console.WriteLine("После перестановки первых и вторых двух цифр : " + fournum[2] + fournum[3] + fournum[0] + fournum[1]); 

            Console.WriteLine("Дз 25");
            Console.WriteLine("Введите число принадлежащее отрезку [100;999] : ");
            string chst = Console.ReadLine();
            string index = Convert.ToString(chst[2]);
           
            int chst1 = Convert.ToInt32(chst);
            int chst2 = (chst1 - Convert.ToInt32(index)) / 10 ;
            string chst3 = chst[2] + Convert.ToString(chst2);
            Console.WriteLine(chst3); 



            Console.WriteLine("ДЗ 26");
            Console.WriteLine("Введите время : часы, минуты, секунды");
            int hour = Convert.ToInt32(Console.ReadLine());
            int min = Convert.ToInt32(Console.ReadLine());
            int sec = Convert.ToInt32(Console.ReadLine());
            double ugol = ((360 / 12) * hour + (0.5 * min) + (0.0083 * sec));
            Console.WriteLine(ugol); 





            Console.WriteLine("ДЗ 27");
            Console.WriteLine("Задание 27");
            double Y = 2; 
            double clockwise = 57.3 * Y;
            int hour1 = Convert.ToInt16(Math.Truncate(clockwise / 30));
            double min1 = clockwise - hour1 * 30;
            double min2 = min1 * 2;
            double min3 = min2 * 6;
            int m = Convert.ToInt32(min2);
            Console.WriteLine("Угол минутной стрелки :" + min3 +  "градусов, часов " + hour1 + ", полных минут " + m );







            Console.WriteLine("ДЗ 28");
            Console.WriteLine("Введите 3 числа");
            int chis1 = Convert.ToInt32(Console.ReadLine());
            int chis2 = Convert.ToInt32(Console.ReadLine());
            int chis3 = Convert.ToInt32(Console.ReadLine());
            if( Math.Abs(chis1) > Math.Abs(chis2) & Math.Abs(chis1) >  Math.Abs(chis3))
            {
                Console.WriteLine(chis1);
            }
            else if(Math.Abs(chis2) > Math.Abs(chis1) & Math.Abs(chis2) > Math.Abs(chis3))
            {
                Console.WriteLine(chis2);
            }
            else if(Math.Abs(chis3) > Math.Abs(chis2) & Math.Abs(chis3) > Math.Abs(chis1))
            {
                Console.WriteLine(chis3);
            }
            else
            {
                Console.WriteLine("Числа одинаковые");
            }


            Console.WriteLine("ДЗ 29");
            List<double> numbers1 = new List<double>();
            Console.WriteLine("Введите 3 числа");
            numbers1.Add(Convert.ToDouble(Console.ReadLine()));
            numbers1.Add(Convert.ToDouble(Console.ReadLine()));
            numbers1.Add(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Сумма равна: " + (numbers1.Min() + numbers1.Max()));



            Console.WriteLine("ДЗ 30");
            Console.WriteLine("Ведите число");
            int digit1 = Convert.ToInt32(Console.ReadLine());
            int count1 = 0;
            int i1 = 1;
            while(i1 <= digit1)
            {
                if (digit1 % i1 == 0)
                {
                    count1 += 1;

                }
                i1 += 1;
            }
            Console.WriteLine(count1);



            Console.WriteLine("ДЗ 31");
            List<double> roots = new List<double>();
            double kf_a = double.Parse(Console.ReadLine());
            double kf_b = double.Parse(Console.ReadLine());
            double kf_c = double.Parse(Console.ReadLine());
            double kf_d = double.Parse(Console.ReadLine());
            int count = -100;
            int root = -100;
            while (count <= 100)
            {
                if ((kf_a * Math.Pow(root, 3) + (kf_b * Math.Pow(root, 2)) + (kf_c * root) + kf_d) == 0)
                {
                    roots.Add(root);

                }
                count += 1;
                root += 1;

            }
            int colroots = roots.Count;
            if (colroots == 1)
            {
                Console.WriteLine("Уравнение имеет 1 корень: " + roots[0]);

            }
            else if (colroots == 2)
            {
                Console.WriteLine("Уравнение имеет 2 корня: " + '\n' + "Первый корень: " + roots[0] + '\n' + "Второй корень: " + roots[1]);
            }

            else if (colroots == 3)
            {
                Console.WriteLine("Уравнение имеет 3 корня: " + '\n' + "Первый корень: " + roots[0] + '\n' + "Второй корень: " + roots[1] + '\n' + "Третий корень" + roots[2]);
            }
            else
            {
                Console.WriteLine("Уравнение не имеет корней");
            }


            Console.WriteLine("ДЗ 32");
            Console.WriteLine("Введите первый член прогрессии : ");
            double prog1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второй член прогрессии : ");
            double prog2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите номер элемента прогрессии : ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            double chlenprog = prog1 + ((prog2 - prog1) * (n1 - 1));
            Console.WriteLine("Искомый член равен :" + chlenprog); 



            Console.WriteLine("ДЗ 33");

            Console.WriteLine("Введите информацию о себе");
            Console.WriteLine("Вы пенсионер?");
            string infa1 = Console.ReadLine();
            Console.WriteLine("Вы студент?");
            string infa2 = Console.ReadLine();
            Console.WriteLine("Вы трудоустроен?");
            string infa3 = Console.ReadLine();

            if ((infa1 == "да" && infa3 == "нет") || (infa2 == "да" && infa3 == "нет"))
            {
                Console.WriteLine("Соболезную! Вам одобрили кредит");

            }
            else
            {
                Console.WriteLine("Вам не одобрили кредит");
            }







            Console.WriteLine("ДЗ 34");
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine("Как вас зовут?");
            string name1 = Console.ReadLine();
            Console.WriteLine("Здравствуйте, " + name1); 

            
            
            Console.WriteLine("ДЗ 35");
            Random random = new Random();

            Console.ReadLine();
            Console.WriteLine("Как тебя зовут?");
            string name2 = Console.ReadLine();
            Console.WriteLine("Привет, " + name2);
            Console.ReadLine();
            Console.WriteLine("Да");
            Console.ReadLine();
            Console.WriteLine("Нет");
            
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Но могу показать");
            
            int color = random.Next(1, 10);

            while (color > 0)
            {
                Console.BackgroundColor++;
                color--;
            }
            Console.Clear();

            System.Threading.Thread.Sleep(5000);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("ДЗ 36");
            Random r = new Random();
            double Result = 0;

            Result = r.NextDouble(); 
            Result *= Math.Pow(10, 12);
            Result = Math.Round(Result);
            Console.WriteLine(Result);
            int chet = 0, nechet = 0,i = 12, sum = 0;
            while (i > 0)
            {
                if (i % 2 == 0)
                    chet += (int)(Result % 10);
                else
                    nechet += (int)(Result % 10);

                i--;
                Result /= 10;
            }
            chet *= 3;
            sum = chet + nechet;
            if (sum % 10 != 0)
                chet = (sum / 10) * 10 + 10;
            Console.WriteLine(chet - sum);




        }
    }
}





            




       










    
          


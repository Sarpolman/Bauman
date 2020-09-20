using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Ширшов А.С ИУ5-35Б");
            Console.ResetColor();
            double A, B, C;
            A = B = C = 0.0;
            if (!(args.GetLength(0) == 3 && Double.TryParse(args[0], out A) && Double.TryParse(args[1], out B) && Double.TryParse(args[2], out C))) //Проверка параметров приложения
            {
                //При ошибке ввод с клавиатуры
                Console.WriteLine("Введите коэфициенты:");
                string input;
                while (true)
                {
                    Console.Write("А=");
                    input = Console.ReadLine();
                    if (Double.TryParse(input, out A))
                        break;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неправильный ввод");
                    Console.ResetColor();
                }

                while (true)
                {
                    Console.Write("B=");
                    input = Console.ReadLine();
                    if (Double.TryParse(input, out B))
                        break;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неправильный ввод");
                    Console.ResetColor();
                }

                while (true)
                {
                    Console.Write("C=");
                    input = Console.ReadLine();
                    if (Double.TryParse(input, out C))
                        break;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неправильный ввод");
                    Console.ResetColor();
                }
            }

            Console.WriteLine($"Введённое уравнение:{A}x^4+{B}x^2+{C}");

            if (A == 0)
            {
                if (-C / B >= 0)
                {
                    double x1 = Math.Sqrt(-C / B);
                    double x2 = -Math.Sqrt(-C / B);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Корни:x1={x1} x2={x2}");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Корней нет");
                    Console.ResetColor();
                }


            }
            else {

                double D1 = B * B - 4 * A * C;
                if (D1 < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Корней нет");
                    Console.ResetColor();

                }
                else if (D1 == 0)
                {
                    double res = -B / (2 * A);
                    if (res < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Корней нет");
                        Console.ResetColor();
                    }
                    else
                    {
                        double x1 = Math.Sqrt(res);
                        double x2 = -x1;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Корни:x1={x1} x2={x2}");
                        Console.ResetColor();
                    }

                }
                else
                {
                    D1 = Math.Sqrt(B * B - 4 * A * C);

                    double res1 = (-B + D1) / (2 * A); //res1=X1^2
                    double res2 = (-B - D1) / (2 * A);//res2=X2^2

                    if ((res1 >= 0) && (res2 >= 0))
                    {
                        double x1 = Math.Sqrt(res1);
                        double x2 = -Math.Sqrt(res1);
                        double x3 = Math.Sqrt(res2);
                        double x4 = -Math.Sqrt(res2);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Корни:x1={x1} x2={x2} x3={x3} x4={x4}");
                        Console.ResetColor();
                    }

                    if ((res1 >= 0) && (res2 < 0))
                    {
                        double x1 = Math.Sqrt(res1);
                        double x2 = -Math.Sqrt(res1);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Корни:x1={x1} x2={x2}");
                        Console.ResetColor();
                    }

                    if ((res1 < 0) && (res2 >= 0))
                    {
                        double x3 = Math.Sqrt(res2);
                        double x4 = -Math.Sqrt(res2);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Корни:x1={x3} x2={x4}");
                        Console.ResetColor();
                    }

                    if ((res1 < 0) && (res2 < 0))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Корней нет");
                        Console.ResetColor();
                    }
                }
            }
            Console.ReadKey();
        }
    }
}


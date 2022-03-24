
// 1. Задана последовательность n вещественных чисел.
// Вычислить сумму чисел, порядковые номера которых являются простыми числами.

using System;

namespace ConsoleApp30
{
    internal class Program
    {
        static void Input(double[] mas)
        {
            Random rand = new Random();
            for (int i = 0; i < mas.Length; i++)
                mas[i] = rand.Next(100) + rand.NextDouble();
        }
        static void Printf(double[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
                Console.WriteLine("{0,6:F}", mas[i]);
        }
        static bool Prime(int a)
        {
            if (a < 2)
                return false;
            int temp;
            for (int i = 2; i <= a / 2; i++)
            {
                temp = a % i;
                if (temp == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main()
        {
            try
            {
                double Summa = 0;
                Console.Write(" Введите количество элементов массива, n = ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("\n");
                double[] Mas = new double[n];
                Input(Mas);
                Printf(Mas);

                    for (int i = 0; i <= Mas.Length; i++)
                {
                    if (Prime(i))
                    {
                        Summa += Mas[i-1];
                        Console.Write("\t" + i + " - простое число \n");
                    }
                }
                Console.WriteLine(" \n Сумма элементов = " + Summa);
            }
            catch (FormatException)
            {
                Console.WriteLine(" Введено нечисловое значение ");
            }
            catch(OverflowException)
            {
                Console.WriteLine(" error ");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine(" Ошибка ");
            }
        }

    }
}


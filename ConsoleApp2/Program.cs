using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._02._23_HW_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Певрое задание
            Console.WriteLine("It's easy to win forgiveness for being wrong \n being right is what gets you into real trouble \n Bjarne Stroustrup \n");
            #endregion

            #region Второе задание
            int[] num = new int[5];
            Console.WriteLine("Записываем пять чисел: ");
            for (int i = 0; i < num.Length; i++)
                num[i] = Convert.ToInt32(Console.ReadLine());
            int sum = 0, multi = 1, min = num[0], max = num[0];
            for (int i = 0; i < num.Length; i++)
            {
                if (min > num[i])
                    min = num[i];
                if (max < num[i])
                    max = num[i];
                multi *= num[i];
                sum += num[i];
            }
            Console.WriteLine($"Сумма = {sum}\nПроизведение = {multi}\nМинимум = {min}  Mаксимум = {max}\n");
            #endregion

            #region Третье задание
            string buf = Console.ReadLine();
            Console.Write("Обратно: ");
            for (int i = buf.Length - 1; i >= 0; i--)
                Console.Write($"{buf[i]}");
            #endregion

            #region Четвертое задание
            int last_one = 0, last_two = 1;
            Console.Write("Лимит ");
            int limit = Convert.ToInt32(Console.ReadLine());
            Console.Write($"{last_one} {last_two} ");
            int last_buf;
            while (true)
            {
                if (last_one + last_two > limit)
                    break;
                last_buf = last_two;
                last_two = last_one + last_two;
                last_one = last_buf;
                Console.Write($"{last_two} ");
            }
            #endregion

            #region Пятое задание
            Console.Write("Записываем минимум");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Записываем максимум");
            int B = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < B - A + 1; i++)
            {
                for (int j = 0; j < A + i; j++)
                    Console.Write($"{A + i}");
                Console.WriteLine();
            }
            #endregion

            #region Шестое задание
            Console.WriteLine("\n Первое - Вертикально  , Второе - Горезонтально ");
            int type = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n тип данных сивола");
            string buf_char = Console.ReadLine();
            Console.Write("Кол-во ");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                if (type == 1)
                    Console.WriteLine($"{buf_char}");
                else
                    Console.Write($"{buf_char}");
            }
            Console.WriteLine();
            #endregion
        }
    }
}
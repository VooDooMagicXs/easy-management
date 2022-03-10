using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isWork = true;
            int[] tables = { 5, 2, 6, 7, 8 };
            while (isWork)
            {
                Console.SetCursorPosition(0, 20);
                for (int i = 0; i < tables.Length; i++)
                {
                    Console.WriteLine($"за столом {i + 1} свободно {tables[i]} мест");
                }
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("\nадм кафе");
                Console.WriteLine("\n1 - бронь стола\n\n2 - выход из программы");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int userTable, userPlace;
                        Console.WriteLine("выберите номер стола");
                        userTable = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine("выберите количество мест");
                        userPlace = Convert.ToInt32(Console.ReadLine());
                        if (tables.Length < userTable)
                        {
                            Console.WriteLine("нет такого стола");
                            break;
                        }
                        if (tables[userTable] < userPlace)
                        {
                            Console.WriteLine("нет столько свободных мест");
                        }
                        else
                        {
                            tables[userTable] -= userPlace;
                        }
                        break;

                    case 2:
                        isWork = false;
                        break;

                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
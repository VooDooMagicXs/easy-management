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
            bool isOpen = true;
            string[,] books = { 
                {"Достоевский","Куприн", "Пушкин" },
                { "Лермонтов" , "Декарт" , "Гоголь" },
                {"Маяковский","Есенин","Булгаков" } };
            while (isOpen)
            {
                Console.WriteLine("Добро пожаловать!");
                Console.WriteLine("1 - узнать книгу по индексу\n2 - найти книгу по автору\n3 - вывести всех авторов\n4 - выход");
                Console.Write("выберите действие");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int rows;
                        int cols;
                        Console.Write("полка:");
                        rows = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.Write("номер:");
                        cols = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine($"на {rows + 1} полке под номером {cols + 1} {books[rows,cols]}");
                        break;
                    case 2:
                        string autor;
                        bool autorIsFind = false;
                        Console.WriteLine("Поиск по автору:");
                        autor = Console.ReadLine();
                        for (int i = 0; i < books.GetLength(0); i++)
                        {
                            for(int j = 0; j < books.GetLength(1); j++)
                            {
                                if(autor.ToLower() == books[i,j].ToLower())
                                {
                                    Console.WriteLine($"{autor} на {i+1} полке под номером {j + 1}");
                                    autorIsFind = true;
                                }   
                            }
                        }
                        if (!autorIsFind)
                        {
                            Console.WriteLine("такого автора нет в нашей библиотеке");
                        }
                        break;
                    case 3:
                        for(int i = 0; i < books.GetLength(0); i++)
                        {
                            for(int j = 0; j < books.GetLength(1); j++)
                            {
                                Console.WriteLine(books[i,j]);
                            }
                        }
                        break;
                    case 4:
                        isOpen = false;
                        break;
                }
                Console.WriteLine("Нажмите любую кнопку");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

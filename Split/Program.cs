using System;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Добро пожаловать в программу: Раскол!");

            string text;
            string[] separators = { ",", ".", "!", "?", ";", ":", " " };
            string[] words;

            Console.Write("\n Введите текст |Пример жила была бабушка и дедушка|: ");
            text = Console.ReadLine();

            words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("\n Вывод массива слов, в котором каждое слово с новой строки text = ");
            foreach (var word in words)
            {
                Console.WriteLine(" " + word);
            }
            Console.WriteLine();
        }
    }
}
using System;
using System.Collections.Generic;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isWork = true;           

            Dictionary<string, string> words = new Dictionary<string, string>();

            words.Add("Книга", "Бумажная продукцая, источник любой информации, например словарь или детектив.");
            words.Add("Интернет", "Всемирная система объединенных сетей. В интернете можно найти юбую информацию в короткий срок.");
            words.Add("Кот", "Существо, которое может жрать, бегать, спать.");
            words.Add("Собака", "Лучший друг человека.");
            words.Add("Печенька", "Еда, может использоваться как награда.");
            words.Add("Программист", "Человек который быстро клацает по клавиатуре за печеньки.");
            words.Add("ЯЮниор", "Лучшая школа IT");

            Console.WriteLine("В нашем словаре на данный момент есть опредееления следующим словам: \n");          

            while (isWork)
            {
                ShowAllWords(words);

                Console.WriteLine("\nВведите слово из словаря и мы выдадим его значение.");

                TryFindWord(words);
            }
        }

        static void ShowAllWords(Dictionary<string, string> words)
        {
            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} ");
            }
        }

        static void TryFindWord(Dictionary<string, string> words)
        {
            string userInput = Console.ReadLine();

            char space = '-';

            if (words.ContainsKey(userInput))
            {
                Console.Clear();
                Console.WriteLine($"{userInput} {space} {words[userInput]}\n");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("В нашем словаре пока нет этого слова, извините.\n");
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isWork = true;           

            Dictionary<string, string> wordsAndMeanings = new Dictionary<string, string>();

            wordsAndMeanings.Add("Книга", "Бумажная продукцая, источник любой информации, например словарь или детектив.");
            wordsAndMeanings.Add("Интернет", "Всемирная система объединенных сетей. В интернете можно найти юбую информацию в короткий срок.");
            wordsAndMeanings.Add("Кот", "Существо, которое может жрать, бегать, спать.");
            wordsAndMeanings.Add("Собака", "Лучший друг человека.");
            wordsAndMeanings.Add("Печенька", "Еда, может использоваться как награда.");
            wordsAndMeanings.Add("Программист", "Человек который быстро клацает по клавиатуре за печеньки.");
            wordsAndMeanings.Add("ЯЮниор", "Лучшая школа IT");

            Console.WriteLine("В нашем словаре на данный момент есть опредееления следующим словам: \n");          

            while (isWork)
            {
                ShowAllWords(wordsAndMeanings);

                Console.WriteLine("\nВведите слово из словаря и мы выдадим его значение.");

                TryGetMeanings(wordsAndMeanings);
            }
        }

        static void ShowAllWords(Dictionary<string, string> wordsAndMeanings)
        {
            foreach (var word in wordsAndMeanings)
            {
                Console.WriteLine($"{word.Key} ");
            }
        }

        static void TryGetMeanings(Dictionary<string, string> wordsAndMeanings)
        {
            string userInput = Console.ReadLine();

            char space = '-';

            if (wordsAndMeanings.ContainsKey(userInput))
            {
                Console.Clear();
                Console.WriteLine($"{userInput} {space} {wordsAndMeanings[userInput]}\n");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("В нашем словаре пока нет этого слова, извините.\n");
            }
        }
    }
}

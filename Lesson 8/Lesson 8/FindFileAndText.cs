using System.IO;
using System;
using System.Linq;

namespace Lesson_8
{
    // Объедините две предыдущих работы(практические работы 2 и 3):
    // поиск файла и поиск текста в файле написав утилиту которая ищет
    // файлы определенного расширения с указанным текстом.Рекурсивно.
    // Пример вызова утилиты: utility.exe txt текст.
    public class FindFileAndText
    {
        public static void SearchFileAndText(string directory, string extension, string text)
        {
            string[] files = Directory.GetFiles(directory, "*" + extension, SearchOption.AllDirectories);
            foreach (string file in files)
            {
                if (File.ReadLines(file).Any(line => line.Contains(text)))
                {
                    Console.WriteLine(file);
                }
            }
        }

    }
}
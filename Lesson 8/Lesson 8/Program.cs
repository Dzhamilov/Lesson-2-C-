using System;

namespace Lesson_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindFileAndText.SearchFileAndText("d:\\Education", ".txt", "деньги");

            /*
             *1. Напишите консольную утилиту для копирования файлов 
                Пример запуска: utility.exe file1.txt file2.txt
                        FindFileAndText.SearchFile(args[0], args[1], args[2]);

                        foreach (var line in FindFileAndText.list)
                        {
                            Console.WriteLine(line);
                        }

                         * Напишите утилиту читающую тестовый файл и выводящую на экран строки содержащие искомое слово.
                        using (StreamReader sr = new StreamReader(args[0]))
                        {
                            while (!sr.EndOfStream)
                            {
                                var tempString = sr.ReadLine();
                                if (tempString.Contains(args[1]))
                                {
                                    Console.WriteLine(tempString);
                                }
                            }
                        }

                    }
                        /*
                        if (args.Length < 2)
                        {
                            Console.WriteLine("Нет параметров для запуска");
                        }
                        else
                        {
                            if (!File.Exists(args[0]))
                            {
                                using (StreamWriter sw = new StreamWriter(args[0]))
                                {
                                    sw.WriteLine("Сгенерированная строка");
                                }
                            }
                            using (StreamWriter sw = new StreamWriter(args[1]))
                            {
                                using (StreamReader sr = new StreamReader(args[0]))
                                {
                                    sw.Write(sr.ReadToEnd());
                                }
                            }
                        }


                        SearchFile(args[0], args[1]);
                        foreach (string arg in list)
                        {
                            Console.WriteLine(arg);
                        }


                    }

             Напишите утилиту рекурсивного поиска файлов в заданном каталоге и подкаталогах
             Пример запуска: utility.exe c:\t file1.txt

                    static List<string> list = new List<string>();
                    public static void SearchFile(string path, string fileName)
                    {
                        list.AddRange(Directory.GetFiles(path, fileName, SearchOption.AllDirectories));


                          var files = Directory.GetFiles(path);

                        foreach (var file in files)
                        {
                            if (Path.GetFileName(file) == fileName) 
                            { 
                                list.Add(file);
                            }
                        }

                        foreach (var dir in Directory.GetDirectories(path))
                        {
                            SearchFile(dir, fileName);
                        }
                        */
        }
    }
}

using System;
using System.Collections.Generic;

namespace salomgruppa
{
    internal class BookSearch
    {
        private List<string> books = new List<string> { "1984", "Brave New World", "Fahrenheit 451", "Sherlock Holmes" };

        public void SearchBook(string bookName)
        {
            if (books.Contains(bookName))
            {
                Console.WriteLine($"{bookName} kitobi mavjud.");
                Console.WriteLine("Kitob haqida ma'lumot olishni istaysizmi? (Ha / Yo'q)");

                string answer = Console.ReadLine().Trim().ToLower();

                if (answer == "ha")
                {
                    Console.WriteLine($"{bookName} haqida qisqacha ma'lumot: ");
                    switch (bookName)
                    {
                        case "1984":
                            Console.WriteLine("Muallif: George Orwell ");
                            Console.WriteLine("Nashr yili: 1949");
                            Console.WriteLine("Sahifalar: ~328.");
                            break;
                        case "Brave New World":
                            Console.WriteLine("Muallif: Aldous Huxley");
                            Console.WriteLine("Nashr yili: 1932");
                            Console.WriteLine("Sahifalar: ~311");
                            break;
                        case "Fahrenheit 451":
                            Console.WriteLine("Muallif: Ray Bradbury");
                            Console.WriteLine("Nashr yili: 1953");
                            Console.WriteLine("Sahifalar: ~249");
                            break;
                        case "Sherlock Holmes":
                            Console.WriteLine("Muallif: Arthur Conan Doyle");
                            Console.WriteLine(" Nashr yili: 1887");
                            Console.WriteLine("Sahifalar: ~200-400");
                            break;
                        default:
                            Console.WriteLine("Bu kitob haqida hozircha ma'lumot yo'q.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Yaxshi, boshqa kitoblarni qidirishingiz mumkin.");
                }
            }
            else
            {
                Console.WriteLine("Kechirasiz, bu kitob to‘plamda mavjud emas.");
            }
        }
    }

    

}

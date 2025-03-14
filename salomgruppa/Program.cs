﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;
using System.Numerics;
using System.Xml.Linq;
using salomgruppa;
class Program
{
    private static readonly string Token = "8062141478:AAE6iXU4bnn2vmrbzL0uX3mvv2cNudto6bI"; // Bot tokenini shu yerga qo‘ying
    private static readonly long ChatId = -1002402040732; // O‘zingizning Telegram ID yoki guruh ID

    static async Task Main()
    {
        TelegramService telegramService = new TelegramService(Token, ChatId);
        string login1 = "Ali";
        string parol1 = "Ali0930";
        string book1 = "A Dictionary of the English Language";
        string book2 = "Ducks, Newburyport";
        string book3 = "2666";
        string book4 = "The Count of Monte Cristo";
        string book5 = "Harry Potter and the Philosopher's Stone";
        string book6 = "And then There Were None";
        string book7 = "7.1984";
        string book8 = "8.Brave New World";
        string book9 = "9.Fahrenheit 451";
        string book10 = "10.Sherlock Holmes";
        Console.WriteLine("                                      ONLINE KUTUBXONAGA HUSH KELIBSIZ");
        Console.WriteLine("1. Tizimga kirish");
        Console.WriteLine("2. Ro'yxatdan o'tish");
        int a = int.Parse(Console.ReadLine());
        Console.Clear();
        if (a == 1)
        {

            Console.Write("Login: ");
            string login = Console.ReadLine();
            Console.Write("Parol: ");
            string parol = Console.ReadLine();
            while (login == login1 && parol == parol1)
            {
                string message = $"🆕 Tarmoqqa ushbu foydalanuvchi  kirdi! {login1}";
                await telegramService.SendTelegramMessage(message);
                Console.Clear();
                Console.WriteLine("Tizimga hush kelibsiz !");
                Console.WriteLine("Bolimni tanlang...");
                Console.WriteLine("1. Kitob buyurtma qilish");
                Console.WriteLine("2. Kitob qo`shish");
                Console.WriteLine("3. Kitoblar haqida malumot");
                Console.WriteLine("4. Kitob qidirish ");
                Console.WriteLine("5. Chiqish");
                Console.WriteLine("6 Oniline kitob o'qish ");
                int bolim = int.Parse(Console.ReadLine());
                Console.Clear();
                if (bolim == 4)
                {
                    BookSearch bookSearch = new BookSearch();
                    Console.Write("Qidirayotgan kitob nomini kiriting: ");
                    string bookName = Console.ReadLine();
                    bookSearch.SearchBook(bookName);
                }
                    if (bolim == 3)
                    {
                        Console.WriteLine("1 = A Dictionary of the English Language");
                        Console.WriteLine("2 = Ducks, Newburyport");
                        Console.WriteLine("3 = 2666");
                        Console.WriteLine("4 = The Count of Monte Cristo");
                        Console.WriteLine("5 = Harry Potter and the Philosopher's Stone");
                        Console.WriteLine("6 = And then There Were None");
                        Console.WriteLine("7.1984");
                        Console.WriteLine("8.Brave New World");
                        Console.WriteLine("9.Fahrenheit 451");
                        Console.WriteLine("10.Sherlock Holmes");
                        Console.WriteLine();
                        Console.Write("Batafsil ma'lumor olish uchun Tanlang: ");
                        string choice = Console.ReadLine();
                        Console.Clear();
                        if (choice == "Book1")
                        {
                            Console.WriteLine("              A Dictionary of the English Language");
                            Console.WriteLine("Language -> English");
                            Console.WriteLine("Author -> Samuel Johnson");
                            Console.WriteLine("Pages -> 2348");
                            Console.WriteLine("Year -> 1755");
                            Console.WriteLine("Price -> 30$");
                            Console.WriteLine();
                            Console.WriteLine("1. Ortga qaytish");
                            Console.WriteLine("2. Boshqa amal bajarmayman");
                            int amal = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (amal == 1)
                            {
                                continue;
                            }
                            else if (amal == 2)
                            {
                                Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                                break;
                            }
                        }
                        else if (choice == "Book2")
                        {
                            Console.WriteLine("                 Ducks, Newburyport");
                            Console.WriteLine("Language -> English");
                            Console.WriteLine("Author -> Lucy Ellmann");
                            Console.WriteLine("Pages -> 1030");
                            Console.WriteLine("Year -> 2019");
                            Console.WriteLine("Price -> 20$");
                            Console.WriteLine();
                            Console.WriteLine("1. Ortga qaytish");
                            Console.WriteLine("2. Boshqa amal bajarmayman");
                            int amal = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (amal == 1)
                            {
                                continue;
                            }
                            else if (amal == 2)
                            {
                                Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                                break;
                            }
                        }
                        else if (choice == "Book3")
                        {
                            Console.WriteLine("              2666");
                            Console.WriteLine("Language -> English");
                            Console.WriteLine("Author -> Roberto Bolano");
                            Console.WriteLine("Pages -> 1100");
                            Console.WriteLine("Year -> 2004");
                            Console.WriteLine("Price -> 25$");
                            Console.WriteLine();
                            Console.WriteLine("1. Ortga qaytish");
                            Console.WriteLine("2. Boshqa amal bajarmayman");
                            int amal = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (amal == 1)
                            {
                                continue;
                            }
                            else if (amal == 2)
                            {
                                Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                                break;
                            }
                        }
                        else if (choice == "Book4")
                        {
                            Console.WriteLine("              The Count of Monte Cristo");
                            Console.WriteLine("Language -> English");
                            Console.WriteLine("Author -> Alexandre Dumas");
                            Console.WriteLine("Pages -> 1276");
                            Console.WriteLine("Year -> 1844");
                            Console.WriteLine("Price -> 15$");
                            Console.WriteLine();
                            Console.WriteLine("1. Ortga qaytish");
                            Console.WriteLine("2. Boshqa amal bajarmayman");
                            int amal = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (amal == 1)
                            {
                                continue;
                            }
                            else if (amal == 2)
                            {
                                Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                                break;
                            }
                        }
                        else if (choice == "Book5")
                        {
                            Console.WriteLine("              Harry Potter and the Philosopher's Stone");
                            Console.WriteLine("Language -> English");
                            Console.WriteLine("Author -> J.K. Rowling");
                            Console.WriteLine("Pages -> 223");
                            Console.WriteLine("Year -> 1997");
                            Console.WriteLine("Price -> 10$");
                            Console.WriteLine();
                            Console.WriteLine("1. Ortga qaytish");
                            Console.WriteLine("2. Boshqa amal bajarmayman");
                            int amal = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (amal == 1)
                            {
                                continue;
                            }
                            else if (amal == 2)
                            {
                                Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                                break;
                            }
                        }
                        else if (choice == "Book6")
                        {
                            Console.WriteLine("              And then There Were None");
                            Console.WriteLine("Language -> English");
                            Console.WriteLine("Author -> Agatha Christie");
                            Console.WriteLine("Pages -> 272");
                            Console.WriteLine("Year -> 1939");
                            Console.WriteLine("Price -> 10$");
                            Console.WriteLine();
                            Console.WriteLine("1. Ortga qaytish");
                            Console.WriteLine("2. Boshqa amal bajarmayman");
                            int amal = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (amal == 1)
                            {
                                continue;
                            }
                            else if (amal == 2)
                            {
                                Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                                break;
                            }
                        }
                        else if (choice == "Book7")
                        {
                            Console.WriteLine("              Harry Potter and the Philosopher's Stone");
                            Console.WriteLine("Language -> English");
                            Console.WriteLine("Author -> J.K. Rowling");
                            Console.WriteLine("Pages -> 223");
                            Console.WriteLine("Year -> 1997");
                            Console.WriteLine("Price -> 10$");
                            Console.WriteLine();
                            Console.WriteLine("1. Ortga qaytish");
                            Console.WriteLine("2. Boshqa amal bajarmayman");
                            int amal = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (amal == 1)
                            {
                                continue;
                            }
                            else if (amal == 2)
                            {
                                Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                                break;
                            }
                        }
                    }
                    else if (bolim == 6)
                    {
                        Console.Clear();
                        Console.WriteLine("Bizda ayni damda 5-ta online kitob mavjud");
                        Console.WriteLine("1. SAHRO ");
                        Console.WriteLine("2. SHAYTANAT ");
                        Console.WriteLine("3. JANGCHI ");
                        Console.WriteLine("4. VAQT ");
                        Console.WriteLine("5. HALQA ");
                        Console.Write("");
                        int k6 = int.Parse(Console.ReadLine());
                        if (k6 == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Sahro kitobini o'qishingiz mumkin!!!");
                        }
                        else if (k6 == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Shaytanat kitobini o'qishingiz mumkin!!!");
                        }
                        else if (k6 == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Jangchi kitobini o'qishingiz mumkin!!!");

                        }
                        else if (k6 == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("Vaqt kitobini o'qishingiz mumkin!!!");
                        }
                        else if (k6 == 5)
                        {
                            Console.Clear();
                            Console.WriteLine("Halqa kitobini o'qishingiz mumkin!!!");
                        }
                        Console.WriteLine();
                        Console.WriteLine("1. Ortga qaytish");
                        Console.WriteLine("2. Boshqa amal bajarmayman");
                        int amal = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (amal == 1)
                        {
                            continue;
                        }
                        else if (amal == 2)
                        {
                            Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                            break;
                        }
                    }
                    else if (bolim == 1)
                    {
                        Console.Write("Qaysi kitobdan buyurtma bermoqchisiz ( Masalan -> book1 ) : ");
                        string order = Console.ReadLine();
                        if (order == "book1")
                        {
                            Console.WriteLine(book1);
                            Console.WriteLine("Kitob soni: ");
                            int numb = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.Write("Manzilingizni kiriting: ");
                            string manzil = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine($"Sizning {numb} ta {book1} kitobingiz 2-3 kun ichida yetkazib beriladi.");
                            Console.WriteLine();
                            Console.WriteLine("Bizning kutubxonamizdan foydalanganingiz uchun rahmat !");
                            string message1 = $" Yangi buyurtma!!!\n " +
                                $"🆕 Ushbu foydalanuvchi:   {login1}\n" +
                                $"   Kitob nomi: {book1}\n" +
                                $"   Buyurtma manzili: {manzil}\n" +
                                $"   Buyurtma soni: {numb}";
                            await telegramService.SendTelegramMessage(message1);
                            Console.WriteLine();
                            Console.WriteLine("1. Ortga qaytish");
                            Console.WriteLine("2. Boshqa amal bajarmayman");
                            int amal = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (amal == 1)
                            {
                                continue;
                            }
                            else if (amal == 2)
                            {
                                Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                                break;
                            }
                        }
                        else if (order == "book2")
                        {
                            Console.WriteLine(book2);
                            Console.WriteLine("Kitob soni: ");
                            int numb = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.Write("Manzilingizni kiriting: ");
                            string manzil = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine($"Sizning {numb} ta {book2} kitobingiz 2-3 kun ichida yetkazib beriladi.");
                            Console.WriteLine();
                            Console.WriteLine("Bizning kutubxonamizdan foydalanganingiz uchun rahmat !");
                            string message1 = $" Yangi buyurtma!!!\n " +
                                $"🆕 Ushbu foydalanuvchi:   {login1}\n" +
                                $"   Kitob nomi: {book2}\n" +
                                $"   Buyurtma manzili: {manzil}\n" +
                                $"   Buyurtma soni: {numb}";
                            await telegramService.SendTelegramMessage(message1);
                            Console.WriteLine();
                            Console.WriteLine("1. Ortga qaytish");
                            Console.WriteLine("2. Boshqa amal bajarmayman");
                            int amal = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (amal == 1)
                            {
                                continue;
                            }
                            else if (amal == 2)
                            {
                                Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                                break;
                            }
                        }
                        else if (order == "book3")
                        {
                            Console.WriteLine(book3);
                            Console.WriteLine("Kitob soni: ");
                            int numb = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.Write("Manzilingizni kiriting: ");
                            string manzil = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine($"Sizning {numb} ta {book3} kitobingiz 2-3 kun ichida yetkazib beriladi.");
                            Console.WriteLine();
                            Console.WriteLine("Bizning kutubxonamizdan foydalanganingiz uchun rahmat !");
                            Console.WriteLine();
                            string message1 = $" Yangi buyurtma!!!\n " +
                                $"🆕 Ushbu foydalanuvchi:   {login1}\n" +
                                $"   Kitob nomi: {book3}\n" +
                                $"   Buyurtma manzili: {manzil}\n" +
                                $"   Buyurtma soni: {numb}";
                            await telegramService.SendTelegramMessage(message1);
                            Console.WriteLine("1. Ortga qaytish");
                            Console.WriteLine("2. Boshqa amal bajarmayman");
                            int amal = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (amal == 1)
                            {
                                continue;
                            }
                            else if (amal == 2)
                            {
                                Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                                break;
                            }
                        }
                        else if (order == "book4")
                        {
                            Console.WriteLine(book4);
                            Console.WriteLine("Kitob soni: ");
                            int numb = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.Write("Manzilingizni kiriting: ");
                            string manzil = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine($"Sizning {numb} ta {book4} kitobingiz 2-3 kun ichida yetkazib beriladi.");
                            Console.WriteLine();
                            Console.WriteLine("Bizning kutubxonamizdan foydalanganingiz uchun rahmat !");
                            Console.WriteLine();
                            string message1 = $" Yangi buyurtma!!!\n " +
                                $"🆕 Ushbu foydalanuvchi:   {login1}\n" +
                                $"   Kitob nomi: {book4}\n" +
                                $"   Buyurtma manzili: {manzil}\n" +
                                $"   Buyurtma soni: {numb}";
                            await telegramService.SendTelegramMessage(message1);
                            Console.WriteLine("1. Ortga qaytish");
                            Console.WriteLine("2. Boshqa amal bajarmayman");
                            int amal = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (amal == 1)
                            {
                                continue;
                            }
                            else if (amal == 2)
                            {
                                Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                                break;
                            }
                        }
                        else if (order == "book5")
                        {
                            Console.WriteLine(book5);
                            Console.WriteLine("Kitob soni: ");
                            int numb = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.Write("Manzilingizni kiriting: ");
                            string manzil = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine($"Sizning {numb} ta {book5} kitobingiz 2-3 kun ichida yetkazib beriladi.");
                            Console.WriteLine();
                            Console.WriteLine("Bizning kutubxonamizdan foydalanganingiz uchun rahmat !");
                            Console.WriteLine();
                            string message1 = $" Yangi buyurtma!!!\n " +
                                $"🆕 Ushbu foydalanuvchi:   {login1}\n" +
                                $"   Kitob nomi: {book5}\n" +
                                $"   Buyurtma manzili: {manzil}\n" +
                                $"   Buyurtma soni: {numb}";
                            await telegramService.SendTelegramMessage(message1);
                            Console.WriteLine("1. Ortga qaytish");
                            Console.WriteLine("2. Boshqa amal bajarmayman");
                            int amal = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (amal == 1)
                            {
                                continue;
                            }
                            else if (amal == 2)
                            {
                                Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                                break;
                            }
                        }
                        else if (order == "book6")
                        {
                            Console.WriteLine(book6);
                            Console.WriteLine("Kitob soni: ");
                            int numb = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.Write("Manzilingizni kiriting: ");
                            string manzil = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine($"Sizning {numb} ta {book6} kitobingiz 2-3 kun ichida yetkazib beriladi.");
                            Console.WriteLine();
                            Console.WriteLine("Bizning kutubxonamizdan foydalanganingiz uchun rahmat !");
                            Console.WriteLine();
                            string message1 = $" Yangi buyurtma!!!\n " +
                                $"🆕 Ushbu foydalanuvchi:   {login1}\n" +
                                $"   Kitob nomi: {book6}\n" +
                                $"   Buyurtma manzili: {manzil}\n" +
                                $"   Buyurtma soni: {numb}";
                            await telegramService.SendTelegramMessage(message1);
                            Console.WriteLine("1. Ortga qaytish");
                            Console.WriteLine("2. Boshqa amal bajarmayman");
                            int amal = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (amal == 1)
                            {
                                continue;
                            }
                            else if (amal == 2)
                            {
                                Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                                break;
                            }
                        }
                    }

                    else if (bolim == 2)
                    {
                        Console.Write("Kitob nomini kiriting: ");
                        string kitob2 = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Kitob muallifini kiriting: ");
                        string kitob2author = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Kitobga yangi id kiriting: ");
                        int kitob2id = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Kitob sahifasini kiriting: ");
                        int kitob2page = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Kitobga narx kiriting: ");
                        int kitob2price = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Kitob tili: ");
                        string kitob2language = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Kitob nashr yili: ");
                        int kitob2year = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine($"Nomi:  {kitob2}");
                        Console.WriteLine($"Authori:  {kitob2author}");
                        Console.WriteLine($"Id:  {kitob2id}");
                        Console.WriteLine($"Sahifalar soni:  {kitob2page}");
                        Console.WriteLine($"Narxi:  {kitob2price}");
                        Console.WriteLine($"Tili:  {kitob2language}");
                        Console.WriteLine($"Yili:  {kitob2year}");
                        Console.WriteLine();
                        Console.WriteLine("Yangi kitobni qo`shishni tasdiqlaysizmi? ");
                        Console.WriteLine("1. Ha     2. Yoq ");
                        int tasdiq = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (tasdiq == 1)
                        {
                            Console.WriteLine("Yangi kitob qo`shildi !");
                            Console.WriteLine();
                            string message2 = $" Kitob javonga yangi kitob qo'shildi!!!/n " +
                                $"🆕 Ushbu foydalanuvchi:   {login1}\n" +
                                $"   Kitob nomi: {kitob2}\n" +
                                $"   Kitob muallifi: {kitob2author}\n" +
                                $"   Id : {kitob2id}\n" +
                                $"   Sahifalar soni: {kitob2page}\n" +
                                $"   Narxi:  {kitob2price}\n" +
                                $"   Yili:  {kitob2year}";
                            await telegramService.SendTelegramMessage(message2);
                            Console.WriteLine("1. Ortga qaytish");
                            Console.WriteLine("2. Boshqa amal bajarmayman");
                            int amal = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (amal == 1)
                            {
                                continue;
                            }
                            else if (amal == 2)
                            {
                                Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                                break;
                            }
                        }
                    }
                    if (bolim == 4)
                    {
                        Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                        break;

                    }
                
            }
                if (login != login1 || parol != parol1)
                {
                    Console.WriteLine("Login yoki parol noto`g`ri !");
                    return;
                }
            
        }
        else if (a == 2)
        {

            Console.Write("New Login: ");
            string login2 = Console.ReadLine();
            Console.Write("New Parol: ");
            string parol2 = Console.ReadLine();
            Console.WriteLine("Ro'yxatdan o'tdingiz !");
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("Tizimga kirish uchun login va parolni kiriting: ");
            Console.Write("Login: ");
            string login = Console.ReadLine();
            Console.Write("Parol: ");
            string parol = Console.ReadLine();
            Console.Clear();
            while (login == login2 && parol == parol2)
            {
                string message = $"🆕 Yangi foydalanuvchu ro'yhatdan o'tdi!\n" +
                    $"Login: {login2}\n" +
                    $"Parol: {parol2}";
                await telegramService.SendTelegramMessage(message);
                Console.Clear();
                Console.WriteLine("Tizimga hush kelibsiz !");
                Console.WriteLine("Bolimni tanlang...");
                Console.WriteLine("1. Kitob buyurtma qilish");
                Console.WriteLine("2. Kitob qo`shish");
                Console.WriteLine("3. Kitoblar haqida malumot");
                Console.WriteLine("4. Kitob izlash ");
                Console.WriteLine("5. Chiqish");
                Console.WriteLine("6. Onlayn kitob o'qish");
                int bolim = int.Parse(Console.ReadLine());
                Console.Clear();
                if (bolim == 4)
                {
                    BookSearch bookSearch = new BookSearch();
                    Console.Write("Qidirayotgan kitob nomini kiriting: ");
                    string bookName = Console.ReadLine();
                    bookSearch.SearchBook(bookName);
                }
                if (bolim == 3)
                {
                    Console.WriteLine("Book1 = A Dictionary of the English Language");
                    Console.WriteLine("Book2 = Ducks, Newburyport");
                    Console.WriteLine("Book3 = 2666");
                    Console.WriteLine("Book4 = The Count of Monte Cristo");
                    Console.WriteLine("Book5 = Harry Potter and the Philosopher's Stone");
                    Console.WriteLine("Book6 = And then There Were None");
                    Console.Write("Batafsil ma'lumor olish uchun Tanlang: ");
                    string choice = Console.ReadLine();
                    Console.Clear();
                    if (choice == "Book1")
                    {
                        Console.WriteLine("              A Dictionary of the English Language");
                        Console.WriteLine("Language -> English");
                        Console.WriteLine("Author -> Samuel Johnson");
                        Console.WriteLine("Pages -> 2348");
                        Console.WriteLine("Year -> 1755");
                        Console.WriteLine("Price -> 30$");
                        Console.WriteLine();
                        Console.WriteLine("1. Ortga qaytish");
                        Console.WriteLine("2. Boshqa amal bajarmayman");
                        int amal = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (amal == 1)
                        {
                            continue;
                        }
                        else if (amal == 2)
                        {
                            Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                            break;
                        }
                    }

                    else if (choice == "Book3")
                    {
                        Console.WriteLine("              2666");
                        Console.WriteLine("Language -> English");
                        Console.WriteLine("Author -> Roberto Bolano");
                        Console.WriteLine("Pages -> 1100");
                        Console.WriteLine("Year -> 2004");
                        Console.WriteLine("Price -> 25$");
                        Console.WriteLine();
                        Console.WriteLine("1. Ortga qaytish");
                        Console.WriteLine("2. Boshqa amal bajarmayman");
                        int amal = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (amal == 1)
                        {
                            continue;
                        }
                        else if (amal == 2)
                        {
                            Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                            break;
                        }
                    }
                    else if (choice == "Book2")
                    {
                        Console.WriteLine("              Ducks, Newburyport");
                        Console.WriteLine("Language -> English");
                        Console.WriteLine("Author -> Lucy Ellmann");
                        Console.WriteLine("Pages -> 1030");
                        Console.WriteLine("Year -> 2019");
                        Console.WriteLine("Price -> 20$");
                        Console.WriteLine();
                        Console.WriteLine("1. Ortga qaytish");
                        Console.WriteLine("2. Boshqa amal bajarmayman");
                        int amal = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (amal == 1)
                        {
                            continue;
                        }
                        else if (amal == 2)
                        {
                            Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                            break;
                        }
                    }
                    else if (choice == "Book4")
                    {
                        Console.WriteLine("              The Count of Monte Cristo");
                        Console.WriteLine("Language -> English");
                        Console.WriteLine("Author -> Alexandre Dumas");
                        Console.WriteLine("Pages -> 1276");
                        Console.WriteLine("Year -> 1844");
                        Console.WriteLine("Price -> 15$");
                        Console.WriteLine();
                        Console.WriteLine("1. Ortga qaytish");
                        Console.WriteLine("2. Boshqa amal bajarmayman");
                        int amal = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (amal == 1)
                        {
                            continue;
                        }
                        else if (amal == 2)
                        {
                            Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                            break;
                        }
                    }

                    else if (choice == "Book6")
                    {
                        Console.WriteLine("              And then There Were None");
                        Console.WriteLine("Language -> English");
                        Console.WriteLine("Author -> Agatha Christie");
                        Console.WriteLine("Pages -> 272");
                        Console.WriteLine("Year -> 1939");
                        Console.WriteLine("Price -> 10$");
                        Console.WriteLine();
                        Console.WriteLine("1. Ortga qaytish");
                        Console.WriteLine("2. Boshqa amal bajarmayman");
                        int amal = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (amal == 1)
                        {
                            continue;
                        }
                        else if (amal == 2)
                        {
                            Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                            break;
                        }
                    }
                    else if (choice == "Book5")
                    {
                        Console.WriteLine("              Harry Potter and the Philosopher's Stone");
                        Console.WriteLine("Language -> English");
                        Console.WriteLine("Author -> J.K. Rowling");
                        Console.WriteLine("Pages -> 223");
                        Console.WriteLine("Year -> 1997");
                        Console.WriteLine("Price -> 10$");
                        Console.WriteLine();
                        Console.WriteLine("1. Ortga qaytish");
                        Console.WriteLine("2. Boshqa amal bajarmayman");
                        int amal = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (amal == 1)
                        {
                            continue;
                        }
                        else if (amal == 2)
                        {
                            Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                            break;
                        }
                    }
                }
                else if (bolim == 1)
                {
                    Console.Write("Qaysi kitobdan buyurtma bermoqchisiz ( Masalan -> book1 ) : ");
                    string order = Console.ReadLine();
                    if (order == "book1")
                    {
                        Console.WriteLine(book1);
                        Console.WriteLine("Kitob soni: ");
                        int numb = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Manzilingizni kiriting: ");
                        string manzil = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"Sizning {numb} ta {book1} kitobingiz 2-3 kun ichida yetkazib beriladi.");
                        Console.WriteLine();
                        Console.WriteLine("Bizning kutubxonamizdan foydalanganingiz uchun rahmat !");
                        Console.WriteLine();
                        string message1 = $" Yangi buyurtma!!!\n " +
                            $"🆕 Ushbu foydalanuvchi:   {login2}\n" +
                            $"   Kitob nomi: {book1}\n" +
                            $"   Buyurtma manzili: {manzil}\n" +
                            $"   Buyurtma soni: {numb}";
                        await telegramService.SendTelegramMessage(message1);
                        Console.WriteLine("1. Ortga qaytish");
                        Console.WriteLine("2. Boshqa amal bajarmayman");
                        int amal = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (amal == 1)
                        {
                            continue;
                        }
                        else if (amal == 2)
                        {
                            Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                            break;
                        }
                    }

                    else if (order == "book3")
                    {
                        Console.WriteLine(book3);
                        Console.WriteLine("Kitob soni: ");
                        int numb = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Manzilingizni kiriting: ");
                        string manzil = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"Sizning {numb} ta {book3} kitobingiz 2-3 kun ichida yetkazib beriladi.");
                        Console.WriteLine();
                        Console.WriteLine("Bizning kutubxonamizdan foydalanganingiz uchun rahmat !");
                        Console.WriteLine();
                        string message1 = $" Yangi buyurtma!!!\n " +
                            $"🆕 Ushbu foydalanuvchi:   {login1}\n" +
                            $"   Kitob nomi: {book3}\n" +
                            $"   Buyurtma manzili: {manzil}\n" +
                            $"   Buyurtma soni: {numb}";
                        await telegramService.SendTelegramMessage(message1);
                        Console.WriteLine("1. Ortga qaytish");
                        Console.WriteLine("2. Boshqa amal bajarmayman");
                        int amal = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (amal == 1)
                        {
                            continue;
                        }
                        else if (amal == 2)
                        {
                            Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                            break;
                        }
                    }
                    else if (order == "book2")
                    {
                        Console.WriteLine(book2);
                        Console.WriteLine("Kitob soni: ");
                        int numb = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Manzilingizni kiriting: ");
                        string manzil = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"Sizning {numb} ta {book2} kitobingiz 2-3 kun ichida yetkazib beriladi.");
                        Console.WriteLine();
                        Console.WriteLine("Bizning kutubxonamizdan foydalanganingiz uchun rahmat !");
                        Console.WriteLine();
                        string message1 = $" Yangi buyurtma!!!\n " +
                            $"🆕 Ushbu foydalanuvchi:   {login1}\n" +
                            $"   Kitob nomi: {book2}\n" +
                            $"   Buyurtma manzili: {manzil}\n" +
                            $"   Buyurtma soni: {numb}";
                        await telegramService.SendTelegramMessage(message1);
                        Console.WriteLine("1. Ortga qaytish");
                        Console.WriteLine("2. Boshqa amal bajarmayman");
                        int amal = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (amal == 1)
                        {
                            continue;
                        }
                        else if (amal == 2)
                        {
                            Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                            break;
                        }
                    }
                    else if (order == "book4")
                    {
                        Console.WriteLine(book4);
                        Console.WriteLine("Kitob soni: ");
                        int numb = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Manzilingizni kiriting: ");
                        string manzil = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"Sizning {numb} ta {book4} kitobingiz 2-3 kun ichida yetkazib beriladi.");
                        Console.WriteLine();
                        Console.WriteLine("Bizning kutubxonamizdan foydalanganingiz uchun rahmat !");
                        Console.WriteLine();
                        string message1 = $" Yangi buyurtma!!!\n " +
                            $"🆕 Ushbu foydalanuvchi:   {login1}\n" +
                            $"   Kitob nomi: {book4}\n" +
                            $"   Buyurtma manzili: {manzil}\n" +
                            $"   Buyurtma soni: {numb}";
                        await telegramService.SendTelegramMessage(message1);
                        Console.WriteLine("1. Ortga qaytish");
                        Console.WriteLine("2. Boshqa amal bajarmayman");
                        int amal = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (amal == 1)
                        {
                            continue;
                        }
                        else if (amal == 2)
                        {
                            Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                            break;
                        }
                    }
                    else if (order == "book6")
                    {
                        Console.WriteLine(book6);
                        Console.WriteLine("Kitob soni: ");
                        int numb = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Manzilingizni kiriting: ");
                        string manzil = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"Sizning {numb} ta {book6} kitobingiz 2-3 kun ichida yetkazib beriladi.");
                        Console.WriteLine();
                        Console.WriteLine("Bizning kutubxonamizdan foydalanganingiz uchun rahmat !");
                        Console.WriteLine();
                        string message1 = $" Yangi buyurtma!!!\n " +
                            $"🆕 Ushbu foydalanuvchi:   {login1}\n" +
                            $"   Kitob nomi: {book6}\n" +
                            $"   Buyurtma manzili: {manzil}\n" +
                            $"   Buyurtma soni: {numb}";
                        await telegramService.SendTelegramMessage(message1);
                        Console.WriteLine("1. Ortga qaytish");
                        Console.WriteLine("2. Boshqa amal bajarmayman");
                        int amal = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (amal == 1)
                        {
                            continue;
                        }
                        else if (amal == 2)
                        {
                            Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                            break;
                        }
                    }
                    else if (order == "book5")
                    {
                        Console.WriteLine(book5);
                        Console.WriteLine("Kitob soni: ");
                        int numb = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Manzilingizni kiriting: ");
                        string manzil = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"Sizning {numb} ta {book5} kitobingiz 2-3 kun ichida yetkazib beriladi.");
                        Console.WriteLine();
                        Console.WriteLine("Bizning kutubxonamizdan foydalanganingiz uchun rahmat !");
                        Console.WriteLine();
                        string message1 = $" Yangi buyurtma!!!\n " +
                            $"🆕 Ushbu foydalanuvchi:   {login1}\n" +
                            $"   Kitob nomi: {book5}\n" +
                            $"   Buyurtma manzili: {manzil}\n" +
                            $"   Buyurtma soni: {numb}";
                        await telegramService.SendTelegramMessage(message1);
                        Console.WriteLine("1. Ortga qaytish");
                        Console.WriteLine("2. Boshqa amal bajarmayman");
                        int amal = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (amal == 1)
                        {
                            continue;
                        }
                        else if (amal == 2)
                        {
                            Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                            break;
                        }
                    }

                }
                else if (bolim == 6)
                {
                    Console.Clear();
                    Console.WriteLine("Bizda ayni damda 5-ta online kitob mavjud");
                    Console.WriteLine("1. SAHRO ");
                    Console.WriteLine("2. SHAYTANAT ");
                    Console.WriteLine("3. JANGCHI ");
                    Console.WriteLine("4. VAQT ");
                    Console.WriteLine("5. HALQA ");
                    Console.Write("");
                    int k6 = int.Parse(Console.ReadLine());
                    if (k6 == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Sahro kitobini o'qishingiz mumkin!!!");
                    }
                    else if (k6 == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Shaytanat kitobini o'qishingiz mumkin!!!");
                    }
                    else if (k6 == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Jangchi kitobini o'qishingiz mumkin!!!");

                    }
                    else if (k6 == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("Vaqt kitobini o'qishingiz mumkin!!!");
                    }
                    else if (k6 == 5)
                    {
                        Console.Clear();
                        Console.WriteLine("Halqa kitobini o'qishingiz mumkin!!!");
                    }
                    Console.WriteLine();
                    Console.WriteLine("1. Ortga qaytish");
                    Console.WriteLine("2. Boshqa amal bajarmayman");
                    int amal = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (amal == 1)
                    {
                        continue;
                    }
                    else if (amal == 2)
                    {
                        Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                        break;
                    }
                }
                else if (bolim == 2)
                {
                    Console.Write("Kitob nomini kiriting: ");
                    string kitob2 = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Kitob muallifini kiriting: ");
                    string kitob2author = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Kitobga yangi id kiriting: ");
                    int kitob2id = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.Write("Kitob sahifasini kiriting: ");
                    int kitob2page = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.Write("Kitobga narx kiriting: ");
                    int kitob2price = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.Write("Kitob nashr yili: ");
                    int kitob2year = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine($"Nomi:  {kitob2}");
                    Console.WriteLine($"Authori:  {kitob2author}");
                    Console.WriteLine($"Id:  {kitob2id}");
                    Console.WriteLine($"Sahifalar soni:  {kitob2page}");
                    Console.WriteLine($"Narxi:  {kitob2price}");
                    Console.WriteLine($"Yili:  {kitob2year}");
                    Console.WriteLine();
                    Console.WriteLine("Yangi kitobni qo`shishni tasdiqlaysizmi? ");
                    Console.WriteLine("1. Ha     2. Yoq ");
                    int tasdiq = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (tasdiq == 1)
                    {
                        Console.WriteLine("Yangi kitob qo`shildi !");
                        Console.WriteLine();
                        string message2 = $" Kitob javonga yangi kitob qo'shildi!!!/n " +
                            $"🆕 Ushbu foydalanuvchi:   {login2}\n" +
                            $"   Kitob nomi: {kitob2}\n" +
                            $"   Kitob muallifi: {kitob2author}\n" +
                            $"   Id : {kitob2id}\n" +
                            $"   Sahifalar soni: {kitob2page}\n" +
                            $"   Narxi:  {kitob2price}\n" +
                            $"   Yili:  {kitob2year}";
                        await telegramService.SendTelegramMessage(message2);
                        Console.WriteLine("1. Ortga qaytish");
                        Console.WriteLine("2. Boshqa amal bajarmayman");
                        int amal = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (amal == 1)
                        {
                            continue;
                        }
                        else if (amal == 2)
                        {
                            Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                            break;
                        }
                    }
                }
                else if (bolim == 5)
                {
                    Console.WriteLine("Xizmatdan foydalanganingiz uchun raxmat !");
                    break;
                }
            }
            if (login != login2 || parol != parol2)
            {
                Console.WriteLine("Login yoki parol noto`g`ri !");
            }

        }

        
    }
}
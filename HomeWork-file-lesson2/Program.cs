using System;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;


namespace HomeWork_file_lesson2
{
    internal class Program
    {

        /// <summary>
        /// Данные о пользователе (имя, город, возвраст, PIN код)
        /// </summary>
        struct UserInformation
        {
            public string name;
            /// <summary>
            /// Город проживания пользователя
            /// </summary>
            public string city;
            /// <summary>
            /// Возвраст пользователя до 127
            /// </summary>
            public sbyte age;
            /// <summary>
            /// PIN код из четырёх цифр
            /// </summary>
            public string PINcode;
        }


        /// <summary>
        /// Данные о студенте (имя, фамилия, ID, день рождения, категория алкоголизма, объём випитого алкоголя)
        /// </summary>
        struct Student
        {
            public string firstName;
            public string lastName;
            /// <summary>
            /// ID состоит из 7 цифр
            /// </summary>
            public string ID;
            public DateTime birthDay;
            /// <summary>
            /// a – студент алкоголик, b – студент любитель выпить, но не алкоголик, c – студент пьет по праздникам, d – студент не пьет
            /// </summary>
            public char alcoholismCategory;
            /// <summary>
            /// Объём в литрах
            /// </summary>
            public float drunkAmount;
        }

        struct Alcohol
        {
            /// <summary>
            /// Наименование напика
            /// </summary>
            public string name;
            /// <summary>
            /// Процент спирта в напитке
            /// </summary>
            public int procent;
        }
        static void Main(string[] args)
        {
            //Выведите на экран информацию о каждом типе данных в виде:
            //Тип данных – максимальное значение – минимальное значение


            Console.WriteLine("Упражнение 1");

            Console.WriteLine
                (
                $"Тип данных\tМаксимальное значение\t\tМинимальное значение\n\n" +
                $"byte\t\t\t{byte.MaxValue}\t\t\t\t{byte.MinValue}\n" +
                $"sbyte\t\t\t{sbyte.MaxValue}\t\t\t\t{sbyte.MinValue}\n" +
                $"short\t\t\t{short.MaxValue}\t\t\t\t{short.MinValue} \n" +
                $"ushort\t\t\t{ushort.MaxValue}\t\t\t\t{ushort.MinValue}\n" +
                $"int\t\t\t{int.MaxValue}\t\t\t{int.MinValue} \n" +
                $"uint\t\t\t{uint.MaxValue}\t\t\t{uint.MinValue}\n" +
                $"long\t\t\t{long.MaxValue}\t\t{long.MinValue}\n" +
                $"ulong\t\t\t{ulong.MaxValue}\t\t{ulong.MinValue}\n" +
                $"float\t\t\t{float.MaxValue}\t\t\t{float.MinValue}\n" +
                $"double\t\t\t{double.MaxValue}\t\t{double.MinValue}\n" +
                $"char\t\t\t{char.MaxValue}\t\t\t{char.MinValue}\n" +
                $"TimeSpan\t\t{TimeSpan.MaxValue}\t{TimeSpan.MinValue}\n" +
                $"DataTime\t\t{DateTime.MaxValue}\t\t{DateTime.MinValue}\n"
                );



             //Напишите программу, в которой принимаются данные пользователя в виде имени,
             //города, возраста и PIN-кода. Далее сохраните все значение в соответствующей
             //переменной, а затем распечатайте всю информацию в правильном формате.

            Console.WriteLine("\nУпражнение 2");

            string? readResult;

            UserInformation user = new UserInformation();
            //т.к использование функций для конкретно этой домашней работы было запрещено, повторение кода для избежать неполучиться 

            do
            {
                Console.Write("Введите имя: ");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    user.name = readResult;
                }
            }
            while (user.name == "");

            do
            {
                Console.Write("Введите город: ");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    user.city = readResult;
                }
            }
            while (user.city == "");

            do
            {
                Console.Write("Введите возвраст: ");
                readResult = Console.ReadLine();

                if (int.TryParse(readResult, out int userAge))
                {
                    if (userAge > 0 && userAge < 128)
                    {
                        user.age = (sbyte)userAge;
                    }
                    else
                    {
                        Console.WriteLine("Число находится вне диапозона [1, 127]");
                    }
                }
                else
                {
                    Console.WriteLine("Некоректная строка");
                }
            }
            while (user.age == 0);

            do
            {
                Console.Write("Введите PIN код: ");
                readResult = Console.ReadLine();

                if (readResult != null && int.TryParse(readResult, out int userPIN))
                {
                    if (readResult.Length == 4)
                    {
                        user.PINcode = readResult;
                    }
                    else
                    {
                        Console.WriteLine("Число не четырехзначное");
                    }
                }
                else
                {
                    Console.WriteLine("Некоректная строка");
                }
            }
            while (user.PINcode is null);


            Console.WriteLine
                (
                    $"\nИмя:\t\t{user.name}\n" +
                    $"Город:\t\t{user.city}\n" +
                    $"Возвраст:\t{user.age}\n" +
                    $"PIN код:\t{user.PINcode}\n"
                );


            //Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на
            //строчные. 
            

            Console.WriteLine("\nУпражнение 3");

            string line = "";
            string resultLine = "";


            do
            {
                Console.Write("Введите Строку: ");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    line = readResult;
                }
            }
            while (line == "");


            //Преобразование строки
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == char.ToLower(line[i]))
                {
                    resultLine += char.ToUpper(line[i]);
                }
                else
                {
                    resultLine += char.ToLower(line[i]);
                }
            }

            Console.WriteLine(resultLine);



            //Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести
            //на экран.
            


            Console.WriteLine("\nУпражнение 4");

            string userString = "";
            string subString = "";

            do
            {
                Console.Write("Введите Строку: ");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    userString = readResult;
                }
            }
            while (userString == "");

            do
            {
                Console.Write("Введите Подстроку: ");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    subString = readResult;
                }
            }
            while (subString == "");

            Regex regex = new Regex($@"(\w*){subString}(\w*)"); 

            Console.WriteLine($"Кол-во соотвествий подстроки в строке: {regex.Matches(userString).Count}");



            //Цель этой задачи - определить, сколько бутылок виски беспошлинной торговли вам
            //нужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически
            //покрыла расходы на ваш отпуск. Вам будет предоставлена стандартная цена (normPrice),
            //скидка в Duty Free (salePrice) и стоимость отпуска (holidayPrice). Например, если бутылка
            //обычно стоит 10 фунтов стерлингов, а скидка в дьюти фри составляет 10%, вы
            //сэкономите 1 фунт стерлингов на каждой бутылке. Если ваш отпуск стоит 500 фунтов
            //стерлингов, ответ, который вы должны вернуть, будет 500. Все входные данные будут
            //целыми числами. Пожалуйста, верните целое число. Округлить в меньшую сторону.
            
            Console.WriteLine("\nУпражнение 5");

            int normPrice = 0;
            int salePrice = 0;
            int holidayPrice = 0;

            do
            {
                // обычна цена
                Console.Write("Введите обычную цену виски: ");
                readResult = Console.ReadLine();
                if (readResult != null && int.TryParse(readResult, out normPrice))
                {
                    if (normPrice <= 0)
                    {
                        Console.WriteLine("Цена должна быть больше нуля");
                    }
                }
                else
                {
                    Console.WriteLine("Некоректная цена");
                }

                //Скидка
                Console.Write("Введите скидку в процентах на виски: ");
                readResult = Console.ReadLine();
                if (readResult != null && int.TryParse(readResult, out salePrice))
                {
                    if (salePrice >= 100 || salePrice <= 0)
                    {
                        Console.WriteLine("Диапозон скидки 1-99");
                    }
                }
                else
                {
                    Console.WriteLine("Некоректная скидка");
                }

                //Цена отпуска
                Console.Write("Введите цену отпуска: ");
                readResult = Console.ReadLine();
                if (readResult != null && int.TryParse(readResult, out holidayPrice))
                {
                    if (holidayPrice <= 0)
                    {
                        Console.WriteLine("Такого не бывает ;(");
                    }
                }
                else
                {
                    Console.WriteLine("Некоректная цена");
                }

            }
            while (normPrice == 0 || salePrice == 0 || holidayPrice == 0);


            Console.WriteLine((int)Math.Floor(holidayPrice / (normPrice * ((float)salePrice / 100))));




            Console.WriteLine("\nУпражнение 6");

            //Студенты

            Student Anna = new Student()
            {
                firstName = "Анна",
                lastName = "Халова",
                ID = "0089347",
                birthDay = new DateTime(2006, 3, 7),
                alcoholismCategory = 'c',
                drunkAmount = 3,
            };

            Student Bob = new Student()
            {
                firstName = "Боб",
                lastName = "Туров",
                ID = "1032544",
                birthDay = new DateTime(2003, 7, 17),
                alcoholismCategory = 'a',
                drunkAmount = 70,
            };

            Student Kiril = new Student()
            {
                firstName = "Кирил",
                lastName = "Роков",
                ID = "4850321",
                birthDay = new DateTime(2001, 11, 25),
                alcoholismCategory = 'd',
                drunkAmount = 0,
            };

            Student Danil = new Student()
            {
                firstName = "Данил",
                lastName = "Мохов",
                ID = "9334586",
                birthDay = new DateTime(2003, 5, 16),
                alcoholismCategory = 'b',
                drunkAmount = 24.7F,
            };

            Student Anton = new Student()
            {
                firstName = "Антон",
                lastName = "Гобов",
                ID = "5586943",
                birthDay = new DateTime(2007, 6, 4),
                alcoholismCategory = 'a',
                drunkAmount = 98.45F,
            };


            //Алкоголь

            Alcohol Beer = new Alcohol()
            {
                name = "Пиво",
                procent = 5
            };

            Alcohol Wine = new Alcohol()
            {
                name = "Вино",
                procent = 10
            };

            Alcohol Vodka = new Alcohol()
            {
                name = "Водка",
                procent = 40
            };


            float studentsDrunkAmount = Anna.drunkAmount + Bob.drunkAmount + Kiril.drunkAmount + Danil.drunkAmount + Anton.drunkAmount;

            Console.WriteLine
                (
                    $"\n\nобщий объем выпитого: {studentsDrunkAmount}" +
                    $"\nобщий объем алкоголя: {Anna.drunkAmount * (Beer.procent / 100F) + Bob.drunkAmount * (Vodka.procent / 100F) + Kiril.drunkAmount * (Beer.procent / 100F) + Danil.drunkAmount * (Wine.procent / 100F) + Anton.drunkAmount * (Vodka.procent / 100F)}" +
                    $"\n\nАнна выпила: {Math.Round(Anna.drunkAmount / studentsDrunkAmount *100, 1)}%" +
                    $"\nБоб выпил: {Math.Round(Bob.drunkAmount / studentsDrunkAmount * 100, 1)}%" +
                    $"\nКирил выпил: {Math.Round(Kiril.drunkAmount / studentsDrunkAmount * 100, 1)} %" +
                    $"\nДанил выпил: {Math.Round(Danil.drunkAmount / studentsDrunkAmount * 100, 1)} %" +
                    $"\nАнтон выпил: {Math.Round(Anton.drunkAmount / studentsDrunkAmount * 100, 1)} %"
                );

            Console.ReadKey();

        }
    }
}

using System;

namespace HomeWork_lesson2
{

    //Перечисление от первого задания лабораторной
    /// <summary>
    /// Виды банковских счетов
    /// </summary>
    /// <
    enum TypeOfBankAccounts
    {
        currentAccount,
        savingAccount,
    }


    //Структура ко второму заданию лабораторной
    /// <summary>
    /// Структура для создания банковского аккаунта пользователя
    /// </summary>
    struct BankAccount
    {
        /// <summary>
        /// Номер аккаунта 20 цифр
        /// </summary>
        public string accountNumber;
        /// <summary>
        /// Тип банковского
        /// Возможные значения: currentAccount, savingAccount
        /// </summary>
        public string accountType;
        /// <summary>
        /// Баланс денег на аккаунте пользователя в формате int
        /// </summary>
        public int balance;
    }


    // Домашняя из Тумакова

    /// <summary>
    /// Вузы Казани (КГУ, КАИ, КХТИ)
    /// </summary>
    enum University
    {
        KGU,
        KAI,
        KCTI, //КХТИ
    }

    /// <summary>
    /// Информация о работнике ВУЗА
    /// Содержит имя пользоввателя и ВУЗ в котором тот работает
    /// </summary>
    struct Worker
    {
        public string name;
        /// <summary>
        /// Тип данных University
        /// </summary>
        public University university;
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            /*
             Создать перечислимый тип данных отображающий виды банковского
             счета(текущий и сберегательный).Создать переменную типа перечисления, присвоить ей
             значение и вывести это значение на печать.
            */

            Console.WriteLine("Упражнение 3.1");

            TypeOfBankAccounts userPocketMoney = TypeOfBankAccounts.savingAccount;
            Console.WriteLine($"\n{userPocketMoney}");



            /*
             Создать структуру данных, которая хранит информацию о банковском
             счете – его номер, тип и баланс. Создать переменную такого типа, заполнить структуру
             значениями и напечатать результат.
            */

            Console.WriteLine("\n\nУпражнение 3.2");

            BankAccount user = new BankAccount()
            {
                accountNumber = "40802810064580000000",
                accountType = "currentAccount",
                balance = 3400,
            };

            Console.WriteLine($"\nНомер аккаунта: {user.accountNumber}\nТип аккаунта: {user.accountType}\nБаланс: {user.balance}");


            /*
             Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать
             структуру работник с двумя полями: имя, ВУЗ. Заполнить структуру данными и
             распечатать. 
            */

            Console.WriteLine("\n\nУпражнение 3.1 из домашки");

            Worker siencist = new Worker()
            {
                 name = "Bob",
                 university = University.KGU,
            };

            Console.WriteLine($"\nИмя работника: {siencist.name}\nМесто работы: {siencist.university}");

            Console.ReadKey();

        }
    }
}

using System;

namespace PracticalWork1
{
    class Account
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public double Balance { get; set; }

        public Account(string name, int number, double balance)
        {
            Name = name;
            Number = number;
            Balance = balance;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Счет: {Name} | №{Number} | Сумма: {Balance:F2} руб.");
        }

        static void Main(string[] args)
        {
            Account myAccount = new Account("Иван Иванов", 10001, 5500.50);
            myAccount.ShowInfo();
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача
{
    internal class Bank_account<T>
    {
        private T Number { get; set; }
        private int Balance { get; set; }
        private string Name { get; set; }

        public void getInfo() //метод чтения
        {
            Console.WriteLine($"Номер счета - {Number}, баланс - {Balance}, ФИО клиента - {Name}");
        }

        public void takeInfo() //метод заполнения
        {
            Console.WriteLine("Введите номер счета");
            Number = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите баланс");
            Balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ФИО клиента");
            Name = Convert.ToString(Console.ReadLine());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank_account<string> account_1 = new Bank_account<string>();
            account_1.takeInfo();
            account_1.getInfo();

            Bank_account<int> account_2 = new Bank_account<int>();
            account_2.takeInfo();
            account_2.getInfo();
            Console.ReadKey();
        }
    }
}

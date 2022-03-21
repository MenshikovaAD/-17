using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_17
{
    internal class Class1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите номер счёта:");
            int numCheck1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ФИО владельца счёта:");
            string fullName = Console.ReadLine();
            Console.WriteLine("Введите баланс счёта:");
            int balance = Convert.ToInt32(Console.ReadLine());

            Employee <int> employee1 = new Employee <int>(numCheck1, fullName,  balance);
            Console.WriteLine(employee1.GetInfo());

            Console.WriteLine("Введите номер счёта:");
            string numCheckString = Console.ReadLine();
            Console.WriteLine("Введите ФИО владельца счёта:");
            fullName = Console.ReadLine();
            Console.WriteLine("Введите баланс счёта:");
            balance = Convert.ToInt32(Console.ReadLine());

            Employee<string> employee2 = new Employee<string>(numCheckString, fullName, balance);
            Console.WriteLine(employee1.GetInfo());
            Console.ReadKey();  


        }
    }
}

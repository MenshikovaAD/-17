using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_17
{
    internal class Employee<T>
    {
        private T NumCheck { get; set; }
        private string FullName { get; set; }
        private int Balance { get; set; }

        public Employee(T numCheck, string fullName, int balance)
        {
            NumCheck = numCheck;
            FullName = fullName;
            Balance = balance;

        }
        public string GetInfo()
        {
            return $" {NumCheck}, {FullName}, {Balance}";
        }
        

    }
}

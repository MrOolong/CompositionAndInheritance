using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public class BankAccount
        {
            protected double _balance;
            public int AccountNumber { get; set; }
            public double Balance => _balance;

            public BankAccount(int acctnumber)
            {
                AccountNumber = acctnumber;
                _balance = 25;
            }
        }

        public class StudentAccount : BankAccount
        {
            public int Fees { get; set; }

            public StudentAccount(int acctnumber)
                :base(acctnumber)
            {
                _balance = 0;
            }
        }

        public class BusinessAccount : BankAccount
        {
            public int Fees { get; set; }

            public BusinessAccount(int acctnumber)
                :base(acctnumber)
            {
                _balance = 100;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Model
{
    internal class Transaction
    {
        private int _id = 1;
        private int _balance = 0;

        protected int Balance { get; set; }

        public Transaction(int balance)
        {
            _id = _id++;
            Balance = balance + Balance;
        }
    }
}

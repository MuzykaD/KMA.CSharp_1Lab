using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Lab1
{
    class Wallet
    {
        string _name;
        double _currBalance;
        double _startBalance;
        string _currency;
        string _descr;

        public Wallet(string name, double balance, string currency)
        {
            _name = name;
            _currBalance = balance;
            _startBalance = balance;
            _currency = currency;

        }

    }
}

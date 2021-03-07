using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Lab1
{
    class User
    {
        string _name;
        string _surname;
        string _mail;
        new List<Wallet> _wallets;

        public User(string name, string surname, string mail)
        {
            _name = name;
            _surname = surname;
            _mail = mail;
            _wallets = new List<Wallet>();
        }

       void addWalletToUser(Wallet wallet)
        {
            _wallets.Add(wallet);
        }

    }
}

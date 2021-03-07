using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Lab1
{
   public class User
    {

        string _name;
        string _surname;
        string _mail;
        List<Wallet> _wallets;

        public User(string name, string surname, string mail)
        {
            _name = name;
            _surname = surname;
            _mail = mail;
            _wallets = new List<Wallet>();
        }

     public void addWalletToUser(Wallet wallet)
        {
            _wallets.Add(wallet);
            wallet.setBelonging();
        }

     public void walletInfo()
        {
            foreach (Wallet wallet in _wallets)
            {
                Console.WriteLine("Name of the wallet: " + wallet.getName() + ".");
                Console.WriteLine("Current wallet balance: " + wallet.getCurrBalance() + ".");
                Console.WriteLine("Start wallet balance: " + wallet.getStartBalance() + ".");
            }
        }

     public string getName()
        {
            return _name;
        }
        public string getSurname()
        {
            return _surname;
        }
    }
}

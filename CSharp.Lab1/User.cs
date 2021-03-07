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
        List<Wallet> _wallets;
        //constructor
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
           
        }
        public void removeWalletToUser(Wallet wallet)
        {
            _wallets.Remove(wallet);
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
        //getters
     public string getName()
        {
            return _name;
        }
        public string getSurname()
        {
            return _surname;
        }

   public string getMail()
        {
            return _mail;
        }

        public void setName(string name)
        {
            _name = name;

        }
        public void setSurame(string surname)
        {
            _surname = surname;

        }

        public void setMail(string mail)
        {
            _mail = mail;
        }
    }
}

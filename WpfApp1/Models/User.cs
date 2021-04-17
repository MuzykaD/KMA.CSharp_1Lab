using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1
{
    public class User
    {
        private List<string> categories = new List<string>();

        string _name;
        string _surname;
        string _mail;
        List<Wallet> _wallets;
        public string _login;

        //constructor
        public User(string name, string surname, string mail, string login)
        {
            _name = name;
            _surname = surname;
            _mail = mail;
            _wallets = new List<Wallet>();
            _login = login;
        }
        public void assignCategotyToWallet(string category, Wallet wallet) {
            wallet.addCategory(category);
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
        public void addCategories(string category)
        {
            if (!categories.Contains(category))
                categories.Add(category);
        }

        public void removeCategories(string category)
        {
            if (categories.Contains(category))
                categories.Remove(category);
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

        public List<Wallet> GetWallets()
        {
            return _wallets;
        }
    }
}

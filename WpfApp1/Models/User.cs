using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1
{
    [Serializable]
    public class User
    {
        private List<string> categories = new List<string>();

        string _name;
        string _surname;
        string _mail;
        string _password;
        List<Wallet> _wallets;
        public string _login;

        //constructor
        public User(string name, string surname, string mail, string password, string login)
        {
            _name = name;
            _surname = surname;
            _mail = mail;
            _wallets = new List<Wallet>();
            _login = login;
            _password = password;
        }
        public string GetLogin()
        {
            return _login;
        }
        public void assignCategotyToWallet(string category, Wallet wallet)
        {
            wallet.addCategory(category);
        }
        public Wallet addWalletToUser(Wallet wallet)
        {
            if (!containsWalletByName(wallet.getName()))
            {
                _wallets.Add(wallet);
                return wallet;
            }
            return null;

        }
        private bool containsWalletByName(string name)
        {
            foreach (Wallet w in _wallets)
            {
                if (w.getName().Equals(name))
                {
                    return true;
                }
            }
            return false;
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
        public string getPassword()
        {
            return _password;
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

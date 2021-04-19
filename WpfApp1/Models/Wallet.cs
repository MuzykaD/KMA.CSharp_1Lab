using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1
{
    [Serializable]
    public class Wallet
    {
        //not all fields used in constructor cause they are not necessary in commin work
        string _name;
        double _currBalance;
        double _startBalance;
        string _currency;
        string _descr;
        List<string> categories;

        List<Transaction> _transactions;

        public Wallet(string name, double balance, string currency, string description)
        {
            _name = name;
            _currBalance = balance;
            _startBalance = balance;
            _currency = currency;
            _descr = description;
            _transactions = new List<Transaction>();
            categories = new List<string>();
        }
        public String GetCurrency()
        {
            return _currency;
        }
        public void addCategory(string category)
        {
            if (!categories.Contains(category))
                categories.Add(category);

        }
        public void removeCategory(string category)
        {
            if (categories.Contains(category))
                categories.Remove(category);

        }

        public void addTransaction(Transaction transaction)
        {
            _transactions.Add(transaction);
            _currBalance += transaction.getSum();
        }
        public void removeTransaction(Transaction transaction)
        {
            _transactions.Remove(transaction);
            _currBalance -= transaction.getSum();
        }

        public void SetName(string name)
        {
            _name = name;
        }
        public List<Transaction> GetTransactions()
        {
            return _transactions;
        }

        public void walletInfo()
        {
            Console.WriteLine("Name of the wallet: " + _name + ".");
            Console.WriteLine("Current wallet balance: " + _currBalance + ".");
            Console.WriteLine("Start wallet balance: " + _startBalance + ".");
            if (_currBalance > _startBalance)
            {
                Console.WriteLine("Your profit is " + (_currBalance - _startBalance));
            }
            else
            {
                Console.WriteLine("You`ve lost " + (_startBalance - _currBalance));
            }
        }

        public void showTransactions(int x)
        {

            if ((x < _transactions.Count) && (x + 10) <= _transactions.Count)
            {
                for (int i = x; i < x + 10; i++)
                {
                    exactTransaction(_transactions[i]);
                }
            }
            if (_transactions.Count < 10)
            {
                foreach (Transaction tran in _transactions)
                {
                    exactTransaction(tran);
                }
            }

        }
        public void exactTransaction(Transaction transaction)
        {
            Console.WriteLine("Sum of transaction is " + transaction.getSum());
            Console.WriteLine("Currency of transaction is " + transaction.getCurrency());

        }
        public string getName()
        {
            return _name;
        }

        public double getCurrBalance()
        {
            return _currBalance;
        }

        public double getStartBalance()
        {
            return _startBalance;
        }



        public void setDescription(string descr)
        {
            _descr = descr;
        }

        override
        public string ToString()
        {
            return
                "Name: " + _name + "\n" +
                "Current balance: " + _currBalance + " " + _currency + "\n"+
                "Description: " + _descr;
        }
    }
}

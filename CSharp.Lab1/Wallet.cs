using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Lab1
{
    class Wallet
    {
        //not all fields used in constructor cause they are not necessary in commin work
        string _name;
        double _currBalance;
        double _startBalance;
        string _currency;
        string _descr;
        bool _belongsToUser;
        List<Transaction> _transactions;

        public Wallet(string name, double balance, string currency)
        {
            _name = name;
            _currBalance = balance;
            _startBalance = balance;
            _currency = currency;
            _transactions = new List<Transaction>();
            _belongsToUser = false;

        }

        public void addTransaction(Transaction transaction)
        {
            _transactions.Add(transaction);
            _currBalance += transaction.getSum();
        }
        public void removeTransaction (Transaction transaction)
        {
            _transactions.Remove(transaction);
            _currBalance -= transaction.getSum();
        }

        public void walletInfo()
        {
            if (_belongsToUser)
            {
                Console.WriteLine("Name of the wallet: " + _name + ".");
                Console.WriteLine("Current wallet balance: " + _currBalance + ".");
                Console.WriteLine("Start wallet balance: " + _startBalance + ".");

            }
            else
            {
                Console.WriteLine("Error! Wallet doen`t have master!");
            }
               
              
            
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
        
        public void setBelonging()
        {
            if(_belongsToUser)
            {
                _belongsToUser = false;
            }
            else
            {
                _belongsToUser = true;
            }
        } // check if wallet belongs to someone (govnocode)

    public void setDescription(string descr)
        {
            _descr = descr;
        }
    }
}

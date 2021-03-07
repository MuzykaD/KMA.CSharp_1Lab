using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Lab1
{
    class Transaction
    {
        //not all fields used in constructor cause they are not necessary in commin work
        double _sum;
        string _currency;
        string _descr;
        string _date;

        public Transaction(double sum, string curr)
        {
            _sum = sum;
            _currency = curr;
        }

        public double getSum()
        {
            return _sum;
        }

        public string getCurrency()
        {
            return _currency;
        }


        public void setDescription(string descr)
        {
            _descr = descr;
        }

        public void setDate(string date)
        {
            _date = date;
        }
    }
}

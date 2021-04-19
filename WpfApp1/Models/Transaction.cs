using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1
{
    [Serializable]
    public class Transaction
    {
        //not all fields used in constructor cause they are not necessary in commin work
        double _sum;

        string _currency;
        string _descr;
        string _date;
        //constructor
        public Transaction(double sum, string curr)
        {
            _sum = sum;
            _currency = curr;
        }

        public Transaction(double sum, string curr, string date, string descr)
        {
            _sum = sum;
            _currency = curr;
            _date = date;
            _descr = descr;
        }
        //getters
        public double getSum()
        {
            return _sum;
        }

        public string getCurrency()
        {
            return _currency;
        }
        //setters
        public void setSum(double sum)
        {
            _sum = sum;
        }

        public void setCurrency(string curr)
        {
            _currency = curr;
        }
        public void setDescription(string descr)
        {
            _descr = descr;
        }

        public void setDate(string date)
        {
            _date = date;
        }

        override
             public string ToString()
        {
            return
                "Sum: " + _sum + " " + _currency + "\n" +
                "Date: " + _date + "\n" +
                "Description: " + _descr;
        }
    }
}

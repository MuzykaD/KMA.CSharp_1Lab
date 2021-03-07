using System;

namespace CSharp.Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Pasha", "Pershuta", "pershuta.com");
            Wallet pashaWallet = new Wallet(user, "Pasha`s Wallet", 100.50, "Euro");
            Wallet anotherPashaWallet = new Wallet(user, "Another Pasha`s Wallet", 50, "Dollar");
           /* user.addWalletToUser(pashaWallet);
            user.addWalletToUser(anotherPashaWallet);*/
            Transaction transaction = new Transaction(1, "Euro");
            Transaction transaction2 = new Transaction(2, "Euro");
            Transaction transaction3 = new Transaction(3, "Euro");
            Transaction transaction4 = new Transaction(4, "Euro");
            Transaction transaction5 = new Transaction(5, "Euro");
            Transaction transaction6 = new Transaction(6, "Euro");
            Transaction transaction7 = new Transaction(7, "Euro");
            Transaction transaction8 = new Transaction(8, "Euro");
            Transaction transaction9 = new Transaction(9, "Euro");
            Transaction transaction10 = new Transaction(10, "Euro");
            Transaction transaction12 = new Transaction(11, "Euro");
            Transaction transaction11 = new Transaction(12, "Euro");
            Transaction transaction13 = new Transaction(13, "Euro");
            Transaction transaction14 = new Transaction(14, "Euro");
            pashaWallet.addTransaction(transaction);
            pashaWallet.addTransaction(transaction2);
            pashaWallet.addTransaction(transaction3);
            pashaWallet.addTransaction(transaction4);
            pashaWallet.addTransaction(transaction5);
            pashaWallet.addTransaction(transaction6);
            pashaWallet.addTransaction(transaction7);
            pashaWallet.addTransaction(transaction8);
            pashaWallet.addTransaction(transaction9);
            pashaWallet.addTransaction(transaction10);
            pashaWallet.addTransaction(transaction11);
            pashaWallet.addTransaction(transaction12);
            pashaWallet.addTransaction(transaction13);
            pashaWallet.addTransaction(transaction14);
            pashaWallet.walletInfo();
            pashaWallet.showTransactions(4);

           // user.walletInfo();

        }
    }
}

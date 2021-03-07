using System;

namespace CSharp.Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Pasha", "Pershuta", "pershuta.com");
            Wallet pashaWallet = new Wallet("Pasha`s Wallet", 100.50, "Euro");
            Wallet anotherPashaWallet = new Wallet("Another Pasha`s Wallet", 50, "Dollar");
            user.addWalletToUser(pashaWallet);
            user.addWalletToUser(anotherPashaWallet);
            Transaction transaction = new Transaction(100, "Euro");
            pashaWallet.addTransaction(transaction);
            user.walletInfo();

        }
    }
}

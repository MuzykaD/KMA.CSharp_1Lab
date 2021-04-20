using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharp.Lab1.Tests
{
    
   public class WalletsTests
    {
        
        [Fact]
        void shouldCreateWallet() {
            var wallet = new Wallet(null,"MyDollars", 0, "DOL");
            Assert.NotNull(wallet);
            Assert.Equal("MyDollars", wallet.getName());
            Assert.Equal(0, wallet.getStartBalance());
            Assert.Equal(0, wallet.getCurrBalance());
        }

        [Fact]
        void shouldCreateWalletWithOneTransaction()
        {
            var wallet = new Wallet(null,"MyDollars", 0, "DOL");
            var transaction = new Transaction(1000, "UAH");
            transaction.setDescription("Charity");
            wallet.addTransaction(transaction);

         //   Assert.Equal(1, wallet.getTransactions().Count())
           
        }
        [Fact]
        void shouldCreateWalletWithOneTransactionAndDeleteTransection()
        {
            var wallet = new Wallet(null,"MyDollars", 0, "DOL");
            var transaction = new Transaction(1000, "UAH");
            transaction.setDescription("Charity");
            wallet.addTransaction(transaction);

            Assert.True(1 == wallet.GetTransactions().Count);
            wallet.removeTransaction(transaction);
            Assert.True(0 == wallet.GetTransactions().Count);
        }

        [Fact]
        void shouldCreateWalletWihSeveralTransationAndDeleteOne()
        {
            var wallet = new Wallet(null, "MyDollars", 0, "DOL");
            var transaction1 = new Transaction(1000, "UAH");
            var transaction2 = new Transaction(1000, "UAH");
            var transaction3 = new Transaction(1000, "UAH");
            var transaction4 = new Transaction(1000, "UAH");
            transaction1.setDescription("Charity");
            transaction2.setDescription("Auto Repair");
            transaction2.setDescription("Shop");
            transaction2.setDescription("Alcohol");
            wallet.addTransaction(transaction1);
            wallet.addTransaction(transaction2);
            wallet.addTransaction(transaction3);
            wallet.addTransaction(transaction4);

            Assert.True(4 == wallet.GetTransactions().Count);
            wallet.removeTransaction(transaction1);
            Assert.True(3 == wallet.GetTransactions().Count);
            wallet.removeTransaction(transaction3);
            wallet.removeTransaction(transaction4);
            Assert.True(1 == wallet.GetTransactions().Count);

        }

        [Fact]
        void shouldCreateWalletCategory()
        {
            var wallet = new Wallet(null, "MyDollars", 0, "DOL");
            var transaction = new Transaction(1000, "UAH");
            transaction.setDescription("Charity");
            wallet.addTransaction(transaction);
            wallet.addCategory("Official Payment");
            Assert.Single(user.GetCategories());
        }
    }

}

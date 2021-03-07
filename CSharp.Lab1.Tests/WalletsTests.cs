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
            var wallet = new Wallet("MyDollars", 0, "DOL");
            Assert.NotNull(wallet);
            Assert.Equal("MyDollars", wallet.getName());
            Assert.Equal(0, wallet.getStartBalance());
            Assert.Equal(0, wallet.getCurrBalance());
        }

        [Fact]
        void shouldCreateWalletWithOneTransaction()
        {
            var wallet = new Wallet("MyDollars", 0, "DOL");
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

    }
}

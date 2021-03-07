using System;
using Xunit;

namespace CSharp.Lab1.Tests
{
    public class TransactionsTests
    {
        [Fact]
        public void TransactionConstructorTest()
        {
            var transaction = new Transaction(100,"UAH");
            Assert.NotNull(transaction);
            Assert.Equal(100, transaction.getSum());
            Assert.Equal("UAH", transaction.getCurrency());
        }
    }
}

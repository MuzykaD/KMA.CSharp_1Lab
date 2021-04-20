using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharp.Lab1.Tests
{
    public class UsersTests
    {
        
        [Fact]
        void shouldCreateUser() {
            var user = new User("first name","last name","mail@mail.com");
            Assert.NotNull(user);
            Assert.Equal("first name", user.getName());
            Assert.Equal("last name", user.getSurname());
            Assert.Equal("mail@mail.com", user.getMail());
        }

        [Fact]
        void shouldCreateUserWithOneWallet()
        {
            var user = new User("first name", "last name", "mail@mail.com");
            user.addWalletToUser(new Wallet(user,"Wallet", 0,"USD"));
            Assert.Equal(1, user.GetWallets().Count);
        }
        
    }
}

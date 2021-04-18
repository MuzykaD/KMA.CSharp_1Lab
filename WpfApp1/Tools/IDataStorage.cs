using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Tools
{
    internal interface IDataStorage
    {
        void AddUser(User user);

        void AddWallet(User user, Wallet wallet);

        void DeleteWallet(User user, Wallet wallet);

        void UpdateWallet(User user, Wallet walletToChange, Wallet newWallet);
    }
}

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

        List<Wallet> wallets();
        Wallet AddWallet(Wallet wallet);
       
        void DeleteWallet(Wallet wallet);

        void UpdateWallet(Wallet walletToChange, Wallet newWallet);
        User AuthenticateUser(AuthUser authUser);

    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using WpfApp1.Tools.Managers;

namespace WpfApp1.Tools
{
    internal class DataStorage : IDataStorage
    {

        private List<User> users;

        internal DataStorage()
        {
            try
            {
                users = SerializationManager.Deserialize<List<User>>(FileFolderHelper.StorageFilePath);
            }
            catch (FileNotFoundException)
            {
                users = new List<User>();
                SaveChanges();
            }
        }
        private void SaveChanges()
        {
            SerializationManager.Serizalize(users, FileFolderHelper.StorageFilePath);
        }
        public void AddUser(User user)
        {
            users.Add(user);
            SaveChanges();
        }

        public void AddWallet(User user, Wallet wallet)
        {
            users[users.IndexOf(user)].addWalletToUser(wallet);
            SaveChanges();
        }

        public void DeleteWallet(User user, Wallet wallet)
        {
            users[users.IndexOf(user)].GetWallets().Remove(wallet);
            SaveChanges();
        }

        public void UpdateWallet(User user, Wallet walletToChange, Wallet newWallet)
        {
            List<Wallet> wallets = users[users.IndexOf(user)].GetWallets();
            wallets[wallets.IndexOf(walletToChange)] = newWallet;
            SaveChanges();
        }
    }
}

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
        private User currentUser;

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
        public User GetCurrUser()
        {
            return currentUser;
        }

        public Wallet AddWallet(Wallet wallet)
        {
            Wallet w = currentUser.addWalletToUser(wallet);
            SaveChanges();
            return w;
        }

        public void DeleteWallet(string wallet)
        {
            currentUser.RemoveWallet(wallet);
            SaveChanges();
        }

        public Wallet UpdateWallet(string oldName, string newName, string description)
        {
            Wallet w = currentUser.UpdateWalletByName(oldName, newName, description);
            SaveChanges();
            return w;
        }

        public User AuthenticateUser(AuthUser authUser)
        {
            foreach (User user in users)
            {
                if (user.GetLogin().Equals(authUser._login) && user.getPassword().Equals(authUser._password))
                {
                    currentUser = user;
                    return user;
                }
            }
            return null;
        }

        public List<Wallet> wallets()
        {
            if (currentUser != null)
            {
                return currentUser.GetWallets();
            }
            return null;
        }
    }
}

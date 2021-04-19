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
        private Wallet currentWallet;
        private Transaction currentTransaction;
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
            if (userWithLoginExists(user.GetLogin()))
            {
                throw new Exception("User with login '" + user.GetLogin() + "' already exists");
            }
            users.Add(user);
            currentUser = user;
            SaveChanges();
        }
        private bool userWithLoginExists(string login)
        {
            foreach (User user in users)
            {
                if (user.GetLogin().Equals(login))
                    return true;
            }
            return false;
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

        public void DeleteWallet(Wallet wallet)
        {
            currentUser.RemoveWallet(wallet.getName());
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

        public void SetCurrentWallet(Wallet wallet)
        {
            currentWallet = wallet;
        }

        public void addTransaction(Transaction transaction)
        {
            currentWallet.addTransaction(transaction);
            SaveChanges();
        }

        public void removeTransaction(Transaction transaction)
        {
            currentWallet.removeTransaction(transaction);
            SaveChanges();
        }

        public void updateTransaction(string decsription)
        {
            currentTransaction.setDescription(decsription);
            SaveChanges();
            currentTransaction = null;
        }

        public string CurrentWallet()
        {
            return currentWallet.getName();
        }
        public Wallet GetCurrentWallet()
        {
            return currentWallet;
        }

        public string CurrentBalance()
        {
            return "Current balance: " + currentWallet.getCurrBalance() + " " + currentWallet.GetCurrency();
        }

        public void setCurrentTransaction(Transaction transaction)
        {
            currentTransaction = transaction;
        }
    }
}

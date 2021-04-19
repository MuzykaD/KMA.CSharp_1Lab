﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using WpfApp1.Tools.Managers;
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for WalletsManager.xaml
    /// </summary>
    public partial class WalletsManager : UserControl
    {
        private Wallet _currentWallet;
        
        
        public ObservableCollection<Wallet> Wallets { get; set; }

        User s = StationManager.Instance.DataStorage.GetCurrUser();
        public Wallet CurrentWallet
        {
            get
                {
                return _currentWallet;
                }
            set
                {
                _currentWallet = value;
               
            }

        }
        
        public WalletsManager()
        {
            InitializeComponent();
            this.DataContext = Wallets;
            Console.WriteLine(s.getName());
            Wallets = new ObservableCollection<Wallet>(s.GetWallets()) ;
        }

        private void Button_Click(object sender, RoutedEventArgs e) //Back to menu
        {
            Content = new Menu();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //add new Wallet
        {
            Content = new WalletAdd();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Content = new WalletEdit();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Content = new WalletDelete();
        }

        private void Transaction(object sender, RoutedEventArgs e)
        {
            Content = new TransactionManager();
        }
    }
}

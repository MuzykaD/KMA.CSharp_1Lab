using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfApp1.Tools.Managers;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for TransactionManager.xaml
    /// </summary>
    public partial class TransactionManager : UserControl
    {

        public ObservableCollection<Transaction> Transactions { get; set; }
        public TransactionManager()
        {
            InitializeComponent();
            WName.Text = StationManager.Instance.DataStorage.CurrentWallet();
            Wbal.Text = StationManager.Instance.DataStorage.CurrentBalance();
            Wallet s = StationManager.Instance.DataStorage.GetCurrentWallet();
            Transactions = new ObservableCollection<Transaction>();
            foreach (Transaction w in s.GetTransactions())
            {
                Transactions.Add(w);
            }

            TransactionsList.ItemsSource = Transactions;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Content = new WalletsManager();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (TransactionsList.SelectedItem == null) {
                MessageBox.Show("No transaction selected");
                return;
            }
            StationManager.Instance.DataStorage.setCurrentTransaction((Transaction)TransactionsList.SelectedItem);
            Content = new TransactionEdit();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Content = new TransactionAdd();
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                StationManager.Instance.DataStorage.removeTransaction((Transaction)TransactionsList.SelectedItem);
                Content = new TransactionManager();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void listBox_SelectionChanged(object sender, MouseButtonEventArgs e)
        {
            StationManager.Instance.DataStorage.setCurrentTransaction((Transaction)TransactionsList.SelectedItem);
            Content = new TransactionEdit();
        }
    }
}

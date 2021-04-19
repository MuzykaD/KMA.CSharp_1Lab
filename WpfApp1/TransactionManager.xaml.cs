using System;
using System.Collections.Generic;
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

        private int _page = 0;
        public TransactionManager()
        {
            InitializeComponent();
            WName.Text = StationManager.Instance.DataStorage.CurrentWallet();
            Wbal.Text = StationManager.Instance.DataStorage.CurrentBalance();
            Transactions = new ObservableCollection<Transaction>();
            paginated(0, 10);

        }

        public TransactionManager(int page)
        {
            _page = page;
            InitializeComponent();
            WName.Text = StationManager.Instance.DataStorage.CurrentWallet();
            Wbal.Text = StationManager.Instance.DataStorage.CurrentBalance();
            Transactions = new ObservableCollection<Transaction>();
            paginated(page, 10);

        }


        private void paginated(int page, int pageSize)
        {
            List<Transaction> all = StationManager.Instance.DataStorage.GetCurrentWallet().GetTransactions();
            for (int i = 0; i < pageSize && page * pageSize + i < all.Count; i++)
            {
                Transactions.Add(all[page * pageSize + i]);
            }
            if ((_page+1) * pageSize >= all.Count)
            {
                Next.IsEnabled = false;
            }
            else
                Next.IsEnabled = true;

            if (_page == 0)
            {
                Prev.IsEnabled = false;
            }
            else
                Prev.IsEnabled = true;
            TransactionsList.ItemsSource = Transactions;

        }
        private void NextPage(object sender, RoutedEventArgs e)
        {
            Content = new TransactionManager(++_page);
        }
        private void PreviousPage(object sender, RoutedEventArgs e)
        {
            Content = new TransactionManager(--_page);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Content = new WalletsManager();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (TransactionsList.SelectedItem == null)
            {
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

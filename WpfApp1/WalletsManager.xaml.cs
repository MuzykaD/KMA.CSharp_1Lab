using System;
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
            Wallets = new ObservableCollection<Wallet>();
            foreach (Wallet w in StationManager.Instance.DataStorage.GetCurrUser().GetWallets())
            {
                Wallets.Add(w);
            }

            WalletsList.ItemsSource = Wallets;
        }

        private void listBox_SelectionChanged(object sender, MouseButtonEventArgs e)
        {

            StationManager.Instance.DataStorage.SetCurrentWallet((Wallet)WalletsList.SelectedItem);
            Content = new TransactionManager();
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
            if (WalletsList.SelectedItem == null) {
                MessageBox.Show("No wallet selected");
                return;
            }
            StationManager.Instance.DataStorage.SetCurrentWallet((Wallet)WalletsList.SelectedItem);
            Content = new WalletEdit();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                StationManager.Instance.DataStorage.DeleteWallet((Wallet)WalletsList.SelectedItem);
                Content = new WalletsManager();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

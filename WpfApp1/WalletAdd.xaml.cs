using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using WpfApp1.Tools.Managers;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for WalletAdd.xaml
    /// </summary>
    public partial class WalletAdd : UserControl
    {
        public WalletAdd()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) //Back to menu button
        {
            Content = new WalletsManager();
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]{1,5}[.,]?[^0-9]{0,2}");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void Button_Click_1(object sender, RoutedEventArgs e) //Save Wallet
        {
            string name = Name.Text;
            double balance = Double.Parse(Balance.Text);
            string currency = Currency.SelectedItem.ToString();
            string description = Description.Text;
            Wallet w = StationManager.Instance.DataStorage.AddWallet(new Wallet(name, balance,currency,description));
            if (w == null) {
                MessageBox.Show("Error! Wallet with such name already exists");
                return;
            }
            Content = new Menu();

        }
    }
}

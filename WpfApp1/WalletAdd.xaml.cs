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

        private void Button_Click_1(object sender, RoutedEventArgs e) //Save Wallet
        {
            Content = new Menu();
        }
    }
}

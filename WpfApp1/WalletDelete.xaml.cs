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
using WpfApp1.Tools.Managers;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для WalletDelete.xaml
    /// </summary>
    public partial class WalletDelete : UserControl
    {
        public WalletDelete()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e) //Back to menu button
        {
            Content = new WalletsManager();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //Back to menu button
        {
            try
            {
                StationManager.Instance.DataStorage.DeleteWallet(Name.Text);
                Content = new WalletsManager();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } 
        }
    }
}

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
    /// Interaction logic for TransactionAdd.xaml
    /// </summary>
    public partial class TransactionAdd : UserControl
    {
        public TransactionAdd()
        {
            InitializeComponent();
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[-]?[^0-9]{1,5}[.,]?[^0-9]{0,2}");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Content = new TransactionManager();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string curr = StationManager.Instance.DataStorage.GetCurrentWallet().GetCurrency();
            StationManager.Instance.DataStorage.addTransaction(new Transaction(
                double.Parse(Sum.Text),
                curr,
                DateTime.Now.ToString(),
                Descr.Text
                ));
            Content = new TransactionManager();
        }
    }
}

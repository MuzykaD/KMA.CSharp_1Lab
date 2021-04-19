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
    /// Interaction logic for TransactionEdit.xaml
    /// </summary>
    public partial class TransactionEdit : UserControl
    {
        public TransactionEdit()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Content = new TransactionManager();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                StationManager.Instance.DataStorage.updateTransaction(Descr.Text);
                Content = new TransactionManager();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

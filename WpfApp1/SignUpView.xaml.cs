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
    /// Interaction logic for SignUpView.xaml
    /// </summary>
    public partial class SignUpView : UserControl
    {
        public SignUpView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) //sign up button
        {
            Content = new SignInControl();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //back button
        {
            string name = Name.Text;
            string surname = Surname.Text;
            string email = Email.Text;
            string login = Login.Text;
            string password = Password.Password;
            try
            {
                StationManager.Instance.DataStorage.AddUser(new User(name, surname, email, login, password));
                Content = new Menu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

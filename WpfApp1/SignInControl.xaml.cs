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
    /// Interaction logic for SignInControl.xaml
    /// </summary>
    public partial class SignInControl : UserControl
    {

        private SignInViewModel _viewModel;
        public SignInControl()
        {
            _viewModel = new SignInViewModel();
            this.DataContext = _viewModel;
            InitializeComponent();
            BSignIn.IsEnabled = false;
        }


        private void BClose_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void BSignIn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(UserLogin.Text) || String.IsNullOrWhiteSpace(UserPas.Text))
            {
                MessageBox.Show("Error! Login or Password is invalid");
            }
            else
            {

                var authUser = new AuthUser()
                {
                    _login = UserLogin.Text,
                    _password = UserPas.Text
                };
                var service = new AuthService();
                User user = null;
                try
                {
                    user = service.Authenticate(authUser);


                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error!" + ex);

                    return;
                }
                MessageBox.Show($" Success {user.getName()}, {user.getSurname()}");

            }
            
        }

        private void Input_Changed(object sender, TextChangedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(UserLogin.Text) || String.IsNullOrWhiteSpace(UserPas.Text))
                BSignIn.IsEnabled = false;
            else
                BSignIn.IsEnabled = true;
        }


    }
}

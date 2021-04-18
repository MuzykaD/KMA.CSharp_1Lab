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
using WpfApp1.Tools;
using WpfApp1.Tools.Managers;

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
            InitializeComponent();
            StationManager.Instance.Initialize(new DataStorage());
            _viewModel = new SignInViewModel();
            this.DataContext = _viewModel;
            BSignIn.IsEnabled = false;
        }


        private void BSignUp_Click(object sender, RoutedEventArgs e)
        {
            Content = new SignUpView();
        }

        private void BSignIn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(UserLogin.Text) || String.IsNullOrWhiteSpace(UserPas.Password))
            {
                MessageBox.Show("Error! Login or Password is invalid");
            }
            else
            {

                var authUser = new AuthUser()
                {
                    _login = UserLogin.Text,
                    _password = UserPas.Password
                };
                var service = new AuthService();
                User user = null;

                user = service.Authenticate(authUser);
                if (user == null)
                {
                    MessageBox.Show("Error! No such user registrered");
                    return;
                }
                MessageBox.Show($" Success {user.getName()}, {user.getSurname()}");
                Content = new Menu();
            }

        }

        private void Input_Changed(object sender, TextChangedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(UserLogin.Text))
                BSignIn.IsEnabled = false;
            else
                BSignIn.IsEnabled = true;
        }
        private void Input_Changed(object sender, RoutedEventHandler e)
        {
           /* if (String.IsNullOrWhiteSpace(UserLogin.Text) || String.IsNullOrWhiteSpace(UserPas.Password))
                BSignIn.IsEnabled = false;
            else
                BSignIn.IsEnabled = true;*/
        }

        private void BMenu_Click(object sender, RoutedEventArgs e)
        {
            Content = new Menu();



        }
    }
}

﻿using System;
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
    /// Interaction logic for WalletEdit.xaml
    /// </summary>
    public partial class WalletEdit : UserControl
    {
        public WalletEdit()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) //to menu
        {
            Content = new WalletsManager();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //save editted
        {
            string oldName = OldName.Text;
            string newName = NewName.Text;
            string description = Description.Text;
            try
            {
                StationManager.Instance.DataStorage.UpdateWallet(oldName, newName, description);
                Content = new Menu();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

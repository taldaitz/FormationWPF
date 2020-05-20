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
using System.Windows.Shapes;

namespace Exo02
{
    /// <summary>
    /// Logique d'interaction pour Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AfficherNewContact(object sender, RoutedEventArgs e)
        {
            ContactNewWindow newContact = ContactNewWindow.getInstance();
            newContact.Show();
        }

        private void AfficherVoirContact(object sender, RoutedEventArgs e)
        {
            MainWindow voirContact = new MainWindow();
            voirContact.ShowDialog();
        }
    }
}

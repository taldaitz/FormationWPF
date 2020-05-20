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

namespace Exo02
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Contact> contacts;


        public MainWindow()
        {
            InitializeComponent();

            contacts = ContactManager.chargerContacts();

            this.DataContext = contacts.First();
        }

        private void afficherContact(object sender, RoutedEventArgs args)
        {
            contacts.Remove((Contact) this.DataContext);

            this.DataContext = contacts.FirstOrDefault();
        }

        private void ButtonNewContact_Click(object sender, RoutedEventArgs e)
        {
            ContactNewWindow window = ContactNewWindow.getInstance();
            window.Show();
        }
    }
}

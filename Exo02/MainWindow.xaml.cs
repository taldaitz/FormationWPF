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
        private Contact nextContact;


        public MainWindow()
        {
            InitializeComponent();

            contacts = ContactManager.chargerContacts();
            nextContact = contacts.First();
        }

        private void afficherContact(object sender, RoutedEventArgs args)
        {
            NomValue.Content = nextContact.Nom;
            PrenomValue.Content = nextContact.prenom;
            DateNaissanceValue.Content = nextContact.dateNaissance.ToString();

            Roles.Items.Clear();
            foreach(String role in nextContact.roles)
            {
                Roles.Items.Add(role);
            }

            contacts.Remove(nextContact);

            nextContact = contacts.Count == 0 ? null : contacts.First();
        }
    }
}

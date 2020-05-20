using System;
using System.Collections.Generic;
using System.IO;
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
    /// Logique d'interaction pour ContactNewWindow.xaml
    /// </summary>
    public partial class ContactNewWindow : Window
    {

        private static ContactNewWindow instance;


        private ContactNewWindow()
        {
            InitializeComponent();
        }

        private void CreerContact(object sender, RoutedEventArgs e)
        {

            String prenom = tbPrenom.Text;
            String nom = tbNom.Text;
            DateTime? dateNaissance = dpDateNaissance.SelectedDate;
            bool? actif = cbActif.IsChecked;

            List<string> roles = new List<string>();

            foreach(ListBoxItem item in lbRole.SelectedItems)
            {
                roles.Add((string)item.Content);
            }


            ContactManager.creerContact(prenom, nom, dateNaissance, actif, roles);


            tbNom.Clear();
            tbPrenom.Clear();
            lbRole.UnselectAll();
            cbActif.IsChecked = null;
        }

        public static ContactNewWindow getInstance()
        {
            if(instance == null)
            {
                instance = new ContactNewWindow();
            }
            return instance;
        }

        public static void deleteInstance()
        {
            instance = null;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            ContactNewWindow.deleteInstance();

        }
    }
}

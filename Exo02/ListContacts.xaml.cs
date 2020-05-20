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
using System.Windows.Shapes;

namespace Exo02
{
    /// <summary>
    /// Logique d'interaction pour ListContacts.xaml
    /// </summary>
    public partial class ListContacts : Window
    {
        public ListContacts()
        {
            InitializeComponent();

            listContactGrid.ItemsSource = ContactManager.chargerContacts();
        }
    }
}

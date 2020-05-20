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

namespace Exo06
{
    /// <summary>
    /// Logique d'interaction pour Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        private void GoToNewProductPage(object sender, RoutedEventArgs e)
        {
            NewProduct page = new NewProduct();
            this.NavigationService.Navigate(page);
        }

        private void GoToListPage(object sender, RoutedEventArgs e)
        {
            ListProduct page = new ListProduct( ((MainWindow)this.Parent).products ); // Pas de parent

            this.NavigationService.Navigate(page); //Injection du parent
        }
    }
}

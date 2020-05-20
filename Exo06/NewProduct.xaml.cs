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
    /// Logique d'interaction pour NewProduct.xaml
    /// </summary>
    public partial class NewProduct : Page
    {
        public NewProduct()
        {
            InitializeComponent();

            this.DataContext = new Product();
        }

        private void SaveProduct(object sender, RoutedEventArgs e)
        {
            Product product = (Product)this.DataContext;

            ((MainWindow)this.Parent).products.Add(product);

            Home page = new Home();
            this.NavigationService.Navigate(page);
        }
    }
}

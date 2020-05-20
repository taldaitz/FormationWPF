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

namespace Exo04
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int nbCoup = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void JouerCoup(object sender, RoutedEventArgs e)
        {
            Button bouton = (Button)sender;

            Grid grid = (Grid)bouton.Parent;

            int index = grid.Children.IndexOf(bouton);

            grid.Children.RemoveAt(index);

            var uriImage = new Uri(nbCoup % 2 == 0 ? @"img/croix.png" : @"img/rond.png", UriKind.Relative);

            Image img = new Image() { Source = new BitmapImage(uriImage) };

            grid.Children.Insert(index, img);
            Grid.SetRow(img, Grid.GetRow(bouton));
            Grid.SetColumn(img, Grid.GetColumn(bouton));

            nbCoup ++;
        }
    }
}

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

namespace Revision
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void envoyerInformations(object sender, RoutedEventArgs e)
        {
            String nom = (String)((ComboBoxItem)noms.SelectedItem).Content;
            DateTime selectedDate = date.SelectedDate == null ? DateTime.Now : (DateTime)date.SelectedDate;
            String selectedMotif = motif.Text;

            result.Text = String.Format("{0} a choisi la date du {1} pour la raison de {2}.", 
                                                nom, selectedDate, selectedMotif);


            switch(nom)
            {
                case "toto":
                    result.Background = Brushes.Blue;
                    break;

                case "titi":
                    result.Background = Brushes.Yellow;
                    break;

                case "tata":
                    result.Background = Brushes.Red;
                    break;
            }
        }
    }
}

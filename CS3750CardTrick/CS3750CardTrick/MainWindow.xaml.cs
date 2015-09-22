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

namespace CS3750CardTrick
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Dealer dealer = new Dealer();

        public MainWindow()
        {       
            InitializeComponent();
        }

        private void btnColumn1_Click(object sender, RoutedEventArgs e)
        {
            
            lblTest.Content = "test";
            
            // this will work
            //BitmapImage image = new BitmapImage(new Uri("C:\\Users\\Erzee\\Source\\Repos\\CS3750CardTrick\\CS3750CardTrick\\CS3750CardTrick\\Deck\\10_of_clubs.png", UriKind.Absolute));
            // imgTest.Source = image;

            // this doesn't work. tried lots of combinations
            BitmapImage image2 = new BitmapImage(new Uri("\\CS3750CardTrick\\CS3750CardTrick\\Deck\\10_of_hearts.png", UriKind.Relative));
            imgTest.Source = image2;

        }

    }
}

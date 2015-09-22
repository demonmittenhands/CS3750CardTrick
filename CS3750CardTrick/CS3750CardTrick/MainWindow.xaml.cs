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
            //imgTest.Source = image;

            // this doesn't work. tried lots of combinations
            BitmapImage image2 = new BitmapImage(new Uri("\\CS3750CardTrick\\CS3750CardTrick\\Deck\\10_of_hearts.png", UriKind.Relative));
            imgTest.Source = image2;

        }

        private void btnStartGame_Click(object sender, RoutedEventArgs e)
        {

            // shows the 3 column buttons
            btnColumn1.Visibility = Visibility.Visible;
            btnColumn2.Visibility = Visibility.Visible;
            btnColumn3.Visibility = Visibility.Visible;
            //shows lblGameInfo
            lblGameInfo.Visibility = Visibility.Visible;

            // hides start game button.
            btnStartGame.Visibility = Visibility.Hidden;

            //fill the card images.
            

        }

    //    private void imgTest_Loaded(object sender, RoutedEventArgs e)
    //    {

    //        //BitmapImage theImg = new BitmapImage();
    //        //theImg.BeginInit();
    //        ////theImg.UriSource = new Uri("Images/2_of_clubs.png");
    //        //theImg.EndInit();

    //        //var image = sender as Image;
    //        //imgTest.Source = theImg;
    //    }

    //}
}

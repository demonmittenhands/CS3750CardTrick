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

            btnColumn1.Visibility = Visibility.Hidden;
            btnColumn2.Visibility = Visibility.Hidden;
            btnColumn3.Visibility = Visibility.Hidden;

            lblGameInfo.Visibility = Visibility.Hidden;


        }

        

        private void btnColumn1_Click(object sender, RoutedEventArgs e)
        {
            dealer.PickupCards(0);
            dealer.ShowCards();
            checkForCard();
            
            

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
            //Dealer dealer = new Dealer();

            //dealer.test();
            dealer.Deal();
            dealer.ShowCards();
            

        }

        private void btnColumn2_Click(object sender, RoutedEventArgs e)
        {
            dealer.PickupCards(1);
            dealer.ShowCards();
            checkForCard();
        }

        private void btnColumn3_Click(object sender, RoutedEventArgs e)
        {
            dealer.PickupCards(2);
            dealer.ShowCards();
            checkForCard();
        }

        private void checkForCard()
        {
            if (Dealer.dealNumber == 3)
            {
                dealer.RevealCard();
            }
        }


    }
}

﻿using System;
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
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is just a testing button  delete it later.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTestButton_Click(object sender, RoutedEventArgs e)
        {
            Player thePlayer = new Player();
            thePlayer.hasPickCard = true;
            btnTestButton.Content = thePlayer.hasPickCard;
            
        }
    }
}

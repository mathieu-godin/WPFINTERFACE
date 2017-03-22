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
using System.IO;

namespace Launching_Interface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      public MainWindow()
      {
         
         InitializeComponent();
         List<string> ListeReçu = new List<string>();
         
         StreamReader lecteurDonnées = new StreamReader("../../Saves/save.txt");
         while (!lecteurDonnées.EndOfStream)
         {
            ListeReçu.Add( lecteurDonnées.ReadLine());           
         }
         lecteurDonnées.Close();

         //if (ListeReçu[1] == "true")
         //{
            MainFrame.Navigate(new MenuDansJeu());
         //}
         //else
         //{
         //   MainFrame.Navigate(new MainPage());
         //}         
      }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            MainFrame.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;
         
        }
    }
}
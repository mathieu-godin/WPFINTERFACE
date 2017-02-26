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
using System.IO;


namespace Launching_Interface
{
   /// <summary>
   /// Interaction logic for MainPage.xaml
   /// </summary>
   public partial class MainPage : Page
   {
      List<string> LangueOficielleMain { get; set; }
      public MainPage()
      {
         LangueOficielleMain = new List<string>();
         InitializeComponent();
         if (GererDonnees.Langue == 0) { LangueOficielleMain = GererDonnees.ListeFrancais; }
         if (GererDonnees.Langue == 1) { LangueOficielleMain = GererDonnees.ListeAnglais; }
         if (GererDonnees.Langue == 2) { LangueOficielleMain = GererDonnees.ListeEspagnol; }
         if (GererDonnees.Langue == 3) { LangueOficielleMain = GererDonnees.ListeJaponais; }

         ng.Text = LangueOficielleMain[1];
         lg.Text = LangueOficielleMain[32];
         se.Text = LangueOficielleMain[11];
         cr.Text = LangueOficielleMain[24];
         hi.Text = LangueOficielleMain[28];



      }
      private void LoadGameButton_Click(object sender, RoutedEventArgs e)
      {
         NavigationService.Navigate(new Uri("LoadGamePage.xaml", UriKind.Relative));
        
      }
      private void SettingsButton_Click(object sender, RoutedEventArgs e)
      {
         NavigationService.Navigate(new Uri("SettingsPage.xaml", UriKind.Relative));
      }
      private void NewGameButton_Click(object sender, RoutedEventArgs e)
      {
         NavigationService.Navigate(new Uri("NewGamePage.xaml", UriKind.Relative));
      }

      private void CreditsButton_Click(object sender, RoutedEventArgs e)
      {
         NavigationService.Navigate(new Uri("CreditsPage.xaml", UriKind.Relative));
      }

      private void Highscores_Click(object sender, RoutedEventArgs e)
      {
         NavigationService.Navigate(new Uri("HighscoresPage.xaml", UriKind.Relative));
      }


   }
}

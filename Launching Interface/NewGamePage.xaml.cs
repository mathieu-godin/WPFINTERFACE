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

namespace Launching_Interface
{
   /// <summary>
   /// Interaction logic for NewGamePage.xaml
   /// </summary>
   public partial class NewGamePage : Page
   {
      List<string> LangueOficielleNewPage { get; set; }
      public NewGamePage()
      {
         LangueOficielleNewPage = new List<string>();
         InitializeComponent();
         if (GererDonnees.Langue == 0) { LangueOficielleNewPage = GererDonnees.ListeFrancais; }
         if (GererDonnees.Langue == 1) { LangueOficielleNewPage = GererDonnees.ListeAnglais; }
         if (GererDonnees.Langue == 2) { LangueOficielleNewPage = GererDonnees.ListeEspagnol; }
         if (GererDonnees.Langue == 3) { LangueOficielleNewPage = GererDonnees.ListeJaponais; }

         tbtitre.Text = LangueOficielleNewPage[1];
         BackButton.Text = LangueOficielleNewPage[0];

         saveA.Text = LangueOficielleNewPage[2];
         timeA.Text = LangueOficielleNewPage[3];
         doneA.Text = LangueOficielleNewPage[4];

         saveB.Text = LangueOficielleNewPage[5];
         timeB.Text = LangueOficielleNewPage[6];
         doneB.Text = LangueOficielleNewPage[7];

         saveC.Text = LangueOficielleNewPage[8];
         timeC.Text = LangueOficielleNewPage[9];
         doneC.Text = LangueOficielleNewPage[10];
      }

      private void BackButton_Click(object sender, RoutedEventArgs e)
      {
         this.NavigationService.Navigate(new MainPage());
      }

      private void Save1Button_Click(object sender, RoutedEventArgs e)
      {
         this.NavigationService.Navigate(new GamePage());
      }
   }
}

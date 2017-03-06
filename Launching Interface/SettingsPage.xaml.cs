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
   /// Interaction logic for SettingsPage.xaml
   /// </summary>
   /// 

   public partial class SettingsPage : Page
   {
      List<string> ListeLangueOficielle { get; set; }
      List<int> ListeInfosÀEnvoyer { get; set; }
      


      int LangueOficielle { get; set; }
      int Fps { get; set; }
      int RenderDistance { get; set; }
      double VolumeMusique { get; set; }
      double VolumeEffets { get; set; }

      WindowStyle WindowStyle { get; set; }
      ResizeMode ResizeMode { get; set; }
      

      public SettingsPage()
      {
         ListeLangueOficielle = new List<string>();
         ListeInfosÀEnvoyer = new List<int>();

         if(GererDonnees.PremierFichier == true)
         {
            ListeInfosÀEnvoyer.Add(GererDonnees.Langue);
            ListeInfosÀEnvoyer.Add(GererDonnees.Fps);
            ListeInfosÀEnvoyer.Add(GererDonnees.RenderDistance);
            ListeInfosÀEnvoyer.Add(GererDonnees.VolMusique);
            ListeInfosÀEnvoyer.Add(GererDonnees.VolEffets);
            ListeInfosÀEnvoyer.Add(GererDonnees.FullscreenMode);
            ListeInfosÀEnvoyer.Add(GererDonnees.KeyboardMode);
         }
         else
         {
            ListeInfosÀEnvoyer    = GererDonnees.ListeInfosRecus;

            ListeInfosÀEnvoyer[0] = GererDonnees.Langue;
            ListeInfosÀEnvoyer[1] = GererDonnees.Fps;
            ListeInfosÀEnvoyer[2] = GererDonnees.RenderDistance;
            ListeInfosÀEnvoyer[3] = GererDonnees.VolMusique;
            ListeInfosÀEnvoyer[4] = GererDonnees.VolEffets;
            ListeInfosÀEnvoyer[5] = GererDonnees.FullscreenMode;
            ListeInfosÀEnvoyer[6] = GererDonnees.KeyboardMode;
         }
         InitializeComponent();

         ChangerRéglages();
      }
      private void BackButton_Click(object sender, RoutedEventArgs e)
      {
         this.NavigationService.Navigate(new MainPage());

         ListeInfosÀEnvoyer[0] = GererDonnees.Langue;
         ListeInfosÀEnvoyer[1] = GererDonnees.Fps;
         ListeInfosÀEnvoyer[2] = GererDonnees.RenderDistance;
         ListeInfosÀEnvoyer[3] = GererDonnees.VolMusique;
         ListeInfosÀEnvoyer[4] = GererDonnees.VolEffets;
         ListeInfosÀEnvoyer[5] = GererDonnees.FullscreenMode;
         ListeInfosÀEnvoyer[6] = GererDonnees.KeyboardMode;

         GererDonnees.ÉcrireFichier(ListeInfosÀEnvoyer);
      }

      private void MusicVolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
      {

      }

      private void SoundVolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
      {

      }

      private void RenderDistanceSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
      {

      }

      private void ControllerComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
      {

      }

      private void RDistanceSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) // Render Distance
      {
         var sliderA = sender as Slider;
         double value = sliderA.Value;

         if (value >= 0 && value <= 0.1)
         {
            RenderDistance = 10;
         }
         if (value > 1.2 && value < 1.3)
         {
            RenderDistance = 50;
         }
         if (value > 2.4 && value < 2.6)
         {
            RenderDistance = 100;
         }
         if (value > 3.7 && value < 3.8)
         {
            RenderDistance = 500;
         }
         if (value > 4.9 && value < 5.1)
         {
            RenderDistance = 1000;
         }
         if (value > 6.2 && value < 6.3)
         {
            RenderDistance = 5000;
         }
         if (value > 7.4 && value < 7.6)
         {
            RenderDistance = 10000;
         }
         if (value > 8.7 && value < 8.8)
         {
            RenderDistance = 50000;
         }
         if (value > 9.9 && value <= 10)
         {
            RenderDistance = 100000;
         }
         rdvalue.Text = RenderDistance.ToString();
         GererDonnees.RenderDistance = RenderDistance;
        
      }

      private void PerfSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)   // FPS
      {

         
      }

      private void RadioButton_Checked(object sender, RoutedEventArgs e)
      {

      }


      private void ButFull_Unchecked(object sender, RoutedEventArgs e)
      {
         GererDonnees.FullscreenMode = 0;
         if (GererDonnees.FullscreenMode == 0)
         {
            ButFull.Content = ListeLangueOficielle[30];
         }
         else if (GererDonnees.FullscreenMode == 1)
         {
            ButFull.Content = ListeLangueOficielle[29];
         }

         Application.Current.MainWindow.WindowState = WindowState.Normal;
         Application.Current.MainWindow.WindowStyle = WindowStyle.SingleBorderWindow;
         Application.Current.MainWindow.ResizeMode  = ResizeMode.CanResize;
      }
      private void ButFull_Checked(object sender, RoutedEventArgs e)
      {
         
         GererDonnees.FullscreenMode = 1;
         GererDonnees.PremierFichier = false;

         if (GererDonnees.FullscreenMode == 0)
         {
            ButFull.Content = ListeLangueOficielle[30];
         }
         else if (GererDonnees.FullscreenMode == 1)
         {
            ButFull.Content = ListeLangueOficielle[29];
         }


         Application.Current.MainWindow.WindowState = WindowState.Maximized;
         Application.Current.MainWindow.WindowStyle = WindowStyle.None;
         Application.Current.MainWindow.ResizeMode = ResizeMode.NoResize;
         


      }
      private void ButCont_Unchecked(object sender, RoutedEventArgs e)
      {
         
         GererDonnees.KeyboardMode = 0;
         ChangerRéglages();

      }
      private void ButCont_Checked(object sender, RoutedEventArgs e)
      {
         
         GererDonnees.KeyboardMode = 1;
         GererDonnees.PremierFichier = false;
         ChangerRéglages();

      }

      // Langues
      #region 

      private void RBes_Checked(object sender, RoutedEventArgs e)
      {
         GererDonnees.Langue = 2;
         ListeLangueOficielle = GererDonnees.ListeEspagnol;
         GererDonnees.PremierFichier = false;
         ChangerRéglages();
      }
      private void RBjp_Checked(object sender, RoutedEventArgs e)
      {
         GererDonnees.Langue = 3;
         ListeLangueOficielle = GererDonnees.ListeJaponais;
         GererDonnees.PremierFichier = false;
         ChangerRéglages();
      }
      private void RBfr_Checked(object sender, RoutedEventArgs e)
      {
         GererDonnees.Langue = 0;
         ListeLangueOficielle = GererDonnees.ListeFrancais;
         ChangerRéglages();
      }
      private void RBan_Checked(object sender, RoutedEventArgs e)
      {
         GererDonnees.Langue = 1;
         ListeLangueOficielle = GererDonnees.ListeAnglais;
         GererDonnees.PremierFichier = false;
         ChangerRéglages();
      }

      void ChangerRéglages()
      {
         GérerLangues();
         GérerFPS();
         GérerRenderDistance();

         Lang.Text = ListeLangueOficielle[31];

         RBan.Content = ListeLangueOficielle[15];
         RBfr.Content = ListeLangueOficielle[14];
         RBes.Content = ListeLangueOficielle[16];
         RBjp.Content = ListeLangueOficielle[17];

         SEff.Text = ListeLangueOficielle[13];
         GMus.Text = ListeLangueOficielle[12];

         TitreSett.Text = ListeLangueOficielle[11];
         Backtext.Text = ListeLangueOficielle[0];
         Resettext2.Text = ListeLangueOficielle[33];

         RenD.Text = ListeLangueOficielle[18];
         Perfo.Text = ListeLangueOficielle[19];
         Inp.Text = ListeLangueOficielle[21];
         Full.Text = ListeLangueOficielle[20];

         if (GererDonnees.FullscreenMode == 1)
         {
            ButFull.Content = ListeLangueOficielle[29];
            ButFull.IsChecked = true;
         }
         else if (GererDonnees.FullscreenMode == 0)
         {
            ButFull.Content = ListeLangueOficielle[30];
            ButFull.IsChecked = false;
         }

         if (GererDonnees.KeyboardMode == 1)
         {
            ButCont.Content = ListeLangueOficielle[22];
            ButCont.IsChecked = true;
         }
         else if (GererDonnees.KeyboardMode == 0)
         {
            ButCont.Content = ListeLangueOficielle[23];
            ButCont.IsChecked = false;
         }

         

      }

      void GérerLangues()
      {
         if (GererDonnees.Langue == 0)
         {
            ListeLangueOficielle = GererDonnees.ListeFrancais;
            RBfr.IsChecked = true;
            RBan.IsChecked = false;
            RBes.IsChecked = false;
            RBjp.IsChecked = false;
         }
         if (GererDonnees.Langue == 1)
         {
            ListeLangueOficielle = GererDonnees.ListeAnglais;
            RBfr.IsChecked = false;
            RBan.IsChecked = true;
            RBes.IsChecked = false;
            RBjp.IsChecked = false;
         }
         if (GererDonnees.Langue == 2)
         {
            ListeLangueOficielle = GererDonnees.ListeEspagnol;
            RBfr.IsChecked = false;
            RBan.IsChecked = false;
            RBes.IsChecked = true;
            RBjp.IsChecked = false;
         }
         if (GererDonnees.Langue == 3)
         {
            ListeLangueOficielle = GererDonnees.ListeJaponais;
            RBfr.IsChecked = false;
            RBan.IsChecked = false;
            RBes.IsChecked = false;
            RBjp.IsChecked = true;
         }
      }

      #endregion

      void GérerFPS()
      {
         if (GererDonnees.Fps == 30) { Fps = 30; }
         if (GererDonnees.Fps == 60) { Fps = 60; }
         if (GererDonnees.Fps == 90) { Fps = 90; }
         if (GererDonnees.Fps == 120) { Fps = 120; }
      }
      void GérerRenderDistance()
      {
         if (GererDonnees.RenderDistance == 10)  { RenderDistance = 10; }
         if (GererDonnees.RenderDistance == 50)  { RenderDistance = 50; }
         if (GererDonnees.RenderDistance == 100) { RenderDistance = 100; }
         if (GererDonnees.RenderDistance == 500) { RenderDistance = 500; }
         if (GererDonnees.RenderDistance == 1000)  { RenderDistance = 1000; }
         if (GererDonnees.RenderDistance == 5000)  { RenderDistance = 5000; }
         if (GererDonnees.RenderDistance == 10000) { RenderDistance = 10000; }
         if (GererDonnees.RenderDistance == 50000) { RenderDistance = 50000; }
         if (GererDonnees.RenderDistance == 100000) { RenderDistance = 100000; }
      }

      private void musicvalue_TextChanged(object sender, TextChangedEventArgs e)
      {

      }

      private void TitreSett_TextChanged(object sender, TextChangedEventArgs e)
      {

      }

      private void perfovalue_TextChanged(object sender, TextChangedEventArgs e)
      {

      }

      private void PerformanceSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
      {
         var slider = sender as Slider;
         double value = slider.Value;

         if (value >= 0 && value <= 0.5)
         {
            Fps = 30;
         }
         if (value > 3.2 && value < 3.4)
         {
            Fps = 60;
         }
         if (value > 6.5 && value < 6.7)
         {
            Fps = 90;
         }
         if (value < 10 && value > 9.9)
         {
            Fps = 120;
         }
         valeurPerfo.Text = Fps.ToString() + " FPS";
      }

      private void GameMusicSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
      {
         var slider = sender as Slider;
         double value = slider.Value;
         VolumeMusique = value;
              musicvalue.Text = Math.Round(VolumeMusique,0).ToString();
      }

      private void SoundEffectsSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
      {
         var slider = sender as Slider;
         double value = slider.Value;
         VolumeEffets = value;
         soundvalue.Text = Math.Round(VolumeEffets, 0).ToString();
      }

      private void ResetButton_Click(object sender, RoutedEventArgs e)
      {
         GererDonnees.PremierFichier = true;
         GererDonnees.RéglagesBase();
         ChangerRéglages();

      }

      

   }
}

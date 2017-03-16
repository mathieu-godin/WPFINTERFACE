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
using System.Diagnostics;
using System.IO;

namespace Launching_Interface
{
    /// <summary>
    /// Interaction logic for NewGamePage.xaml
    /// </summary>
    public partial class NewGamePage : Page
    {
        List<string> LangueOficielleLoadPage { get; set; }
        public NewGamePage()
        {
            LangueOficielleLoadPage = new List<string>();
            InitializeComponent();
            if (GererDonnees.Langue == 0) { LangueOficielleLoadPage = GererDonnees.ListeFrancais; }
            if (GererDonnees.Langue == 1) { LangueOficielleLoadPage = GererDonnees.ListeAnglais; }
            if (GererDonnees.Langue == 2) { LangueOficielleLoadPage = GererDonnees.ListeEspagnol; }
            if (GererDonnees.Langue == 3) { LangueOficielleLoadPage = GererDonnees.ListeJaponais; }
            tbtitre.Text = LangueOficielleLoadPage[1];
            BackButton.Text = LangueOficielleLoadPage[0];
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainPage());
        }

        private void Save0Button_Click(object sender, RoutedEventArgs e)
        {
            CreateSave("0");
            //string path = "F:/programmation clg/quatrième session/HyperV/HyperV/HyperV/bin/x86/Debug/HyperV.exe";
            string path = "C:/Users/Mathieu/Source/Repos/HyperV/HyperV/HyperV/bin/x86/Debug/HyperV.exe";
            ProcessStartInfo p = new ProcessStartInfo();
            p.FileName = path;
            p.WorkingDirectory = System.IO.Path.GetDirectoryName(path);
            Process.Start(p);
            Application.Current.Shutdown();
        }

        void CreateSave(string saveNumber)
        {
            StreamWriter writer = new StreamWriter("../../Saves/save" + saveNumber + ".txt");

            writer.WriteLine("Level: 0");
            writer.WriteLine("Position: {X:5 Y:5 Z:5}");
            writer.WriteLine("Language: " + GererDonnees.Langue);
            writer.WriteLine("World: Lobby");
            writer.WriteLine("Percentage: 0%");
            writer.WriteLine("Time Played: " + (new TimeSpan(0, 0, 0)).ToString());
            writer.Close();
            writer = new StreamWriter("../../Saves/save.txt");
            writer.WriteLine(saveNumber);
            writer.Close();
        }

        private void Save1Button_Click(object sender, RoutedEventArgs e)
        {
            CreateSave("1");
            //string path = "F:/programmation clg/quatrième session/HyperV/HyperV/HyperV/bin/x86/Debug/HyperV.exe";
            string path = "C:/Users/Mathieu/Source/Repos/HyperV/HyperV/HyperV/bin/x86/Debug/HyperV.exe";
            ProcessStartInfo p = new ProcessStartInfo();
            p.FileName = path;
            p.WorkingDirectory = System.IO.Path.GetDirectoryName(path);
            Process.Start(p);
            Application.Current.Shutdown();
        }

        private void Save2Button_Click(object sender, RoutedEventArgs e)
        {
            CreateSave("2");
            //string path = "F:/programmation clg/quatrième session/HyperV/HyperV/HyperV/bin/x86/Debug/HyperV.exe";
            string path = "C:/Users/Mathieu/Source/Repos/HyperV/HyperV/HyperV/bin/x86/Debug/HyperV.exe";
            ProcessStartInfo p = new ProcessStartInfo();
            p.FileName = path;
            p.WorkingDirectory = System.IO.Path.GetDirectoryName(path);
            Process.Start(p);
            Application.Current.Shutdown();
        }

        private void Create0_Loaded(object sender, RoutedEventArgs e)
        {
            if (GererDonnees.Langue == 0)
            {
                Create0.Source = new BitmapImage(new Uri(@"/Pictures/CreateFR.png", UriKind.Relative));
            }
            else if (GererDonnees.Langue == 1)
            {
                Create0.Source = new BitmapImage(new Uri(@"/Pictures/Create.png", UriKind.Relative));
            }
            else if (GererDonnees.Langue == 2)
            {
                Create0.Source = new BitmapImage(new Uri(@"/Pictures/CreateES.png", UriKind.Relative));
            }
            else if (GererDonnees.Langue == 3)
            {
                Create0.Source = new BitmapImage(new Uri(@"/Pictures/CreateJA.png", UriKind.Relative));
            }
        }

        private void Create1_Loaded(object sender, RoutedEventArgs e)
        {
            if (GererDonnees.Langue == 0)
            {
                Create1.Source = new BitmapImage(new Uri(@"/Pictures/CreateFR.png", UriKind.Relative));
            }
            else if (GererDonnees.Langue == 1)
            {
                Create1.Source = new BitmapImage(new Uri(@"/Pictures/Create.png", UriKind.Relative));
            }
            else if (GererDonnees.Langue == 2)
            {
                Create1.Source = new BitmapImage(new Uri(@"/Pictures/CreateES.png", UriKind.Relative));
            }
            else if (GererDonnees.Langue == 3)
            {
                Create1.Source = new BitmapImage(new Uri(@"/Pictures/CreateJA.png", UriKind.Relative));
            }
        }

        private void Create2_Loaded(object sender, RoutedEventArgs e)
        {
            if (GererDonnees.Langue == 0)
            {
                Create2.Source = new BitmapImage(new Uri(@"/Pictures/CreateFR.png", UriKind.Relative));
            }
            else if (GererDonnees.Langue == 1)
            {
                Create2.Source = new BitmapImage(new Uri(@"/Pictures/Create.png", UriKind.Relative));
            }
            else if (GererDonnees.Langue == 2)
            {
                Create2.Source = new BitmapImage(new Uri(@"/Pictures/CreateES.png", UriKind.Relative));
            }
            else if (GererDonnees.Langue == 3)
            {
                Create2.Source = new BitmapImage(new Uri(@"/Pictures/CreateJA.png", UriKind.Relative));
            }
        }
    }
}

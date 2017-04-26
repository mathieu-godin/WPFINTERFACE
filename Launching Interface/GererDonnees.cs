using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Launching_Interface
{
   public static class GererDonnees
   {
      const string CHEMIN_LECTURE = "../../";
      const string CHEMIN_ÉCRITURE = "../../FichiersModifies/";
      const string NOM_FICHIER_ENVOI = "versXna.txt";

      public static bool RD = true;
      public static int NBRE_NIVEAUX = 5;
      const int LANGUE_BASE = 0;
      const int FPS_BASE = 60;
      const int RENDER_D_BASE = 500;
      const int VOL_MUS_BASE = 50;
      const int VOL_EFF_BASE = 50;
      const int NB_NIVEAUX_BASE = 0;
      static TimeSpan TEMPS_BASE = new TimeSpan(0,0,0);  //pour nous, constante

      enum Langues { Francais, Anglais, Espagnol, japonais }
      enum Fullscreen { oui,non }
      enum Controller { Manette, Clavier}
      enum NbreNiveauxFinis { Auncun,Un,Deux,Trois,Quatres,Cinq,Six,Sept,Huit}

      static int langue;
      static int fullscreen;
      static int controller;
      static int nbreNiveauxFinis;

      public static int Langue
      {
         get { return langue; }
         set
         {
            if (value >= (int)Langues.Francais && value <= (int)Langues.japonais)
            {
               langue = value;
            }
            else
            {
               //throw new ArgumentException("Langue invalide");
               langue = (int)Langues.Francais;
            }
         }
      }
      public static int Fps;    // 30,60,90,120
      public static int RenderDistance; // 10,50,100,500,1000,5000,10000,50000,100000
      public static int VolMusique;     // de 0 à 100
      public static int VolEffets;     // de 0 à 100
      public static int FullscreenMode // 0 = false || 1 = true
      {
         get { return fullscreen; }
         set
         {
            if (value == (int)Fullscreen.non || value == (int)Fullscreen.oui)
            {
               fullscreen = value;
            }
            else
            {
               fullscreen = (int)Fullscreen.oui;
            }
         }
      } 
      public static int KeyboardMode// 0 = false || 1 = true
      {
         get { return controller; }
         set
         {
            if (value == (int)Controller.Manette || value == (int)Controller.Clavier)
            {
               controller = value;
            }
            else
            {
               controller = (int)Controller.Clavier;
            }
         }
      }
      public static int NbNiveauxComplétés// 1,2,3,4,5,6,7,8
      {
         get { return nbreNiveauxFinis; }
         set
         {
            if (value >= (int)NbreNiveauxFinis.Auncun && value <= (int)NbreNiveauxFinis.Huit)
            {
               nbreNiveauxFinis = value;
            }
            else
            {
               nbreNiveauxFinis = (int)Langues.Francais;
            }
         }
      }     
      public static bool PremierFichier;
      public static TimeSpan Temps;

      public static List<string> ListeFrancais { get; private set; }
      public static List<string> ListeAnglais { get; private set; }
      public static List<string> ListeEspagnol { get; private set; }
      public static List<string> ListeJaponais { get; private set; }

      public static bool[] GameExists;

      public static void InitGererDonnees(StreamReader reader)
      {
         string line = reader.ReadLine();
         string[] parts = line.Split(new string[] { ": " }, StringSplitOptions.None);
         VolMusique = int.Parse(parts[1]);
         line = reader.ReadLine();
         parts = line.Split(new string[] { ": " }, StringSplitOptions.None);
         VolEffets = int.Parse(parts[1]);
         line = reader.ReadLine();
         parts = line.Split(new string[] { ": " }, StringSplitOptions.None);
         Langue = int.Parse(parts[1]);
         line = reader.ReadLine();
         parts = line.Split(new string[] { ": " }, StringSplitOptions.None);
         RenderDistance = int.Parse(parts[1]);
         line = reader.ReadLine();
         parts = line.Split(new string[] { ": " }, StringSplitOptions.None);
         Fps = int.Parse(parts[1]);
         line = reader.ReadLine();
         parts = line.Split(new string[] { ": " }, StringSplitOptions.None);
         FullscreenMode = int.Parse(parts[1]);
         line = reader.ReadLine();
         parts = line.Split(new string[] { ": " }, StringSplitOptions.None);
         KeyboardMode = int.Parse(parts[1]);
         reader.Close();
      }

      static GererDonnees()
      {
         ListeFrancais = new List<string>();
         ListeAnglais = new List<string>();
         ListeEspagnol = new List<string>();
         ListeJaponais = new List<string>();

         LireFichier("Langues/En.txt");
         LireFichier("Langues/Es.txt");
         LireFichier("Langues/Jp.txt");
         LireFichier("Langues/Fr.txt");
      }

      static void LireFichier(string nomFichier)
      {
         StreamReader lecteurDonnées = new StreamReader(CHEMIN_LECTURE + nomFichier);
         while (!lecteurDonnées.EndOfStream)
         {
            switch (nomFichier)
            {
               case "Langues/Fr.txt":
                  ListeFrancais.Add(lecteurDonnées.ReadLine() + '\n');
                  break;
               case "Langues/En.txt":
                  ListeAnglais.Add(lecteurDonnées.ReadLine() + '\n');
                  break;
               case "Langues/Es.txt":
                  ListeEspagnol.Add(lecteurDonnées.ReadLine() + '\n');
                  break;
               case "Langues/Jp.txt":
                  ListeJaponais.Add(lecteurDonnées.ReadLine() + '\n');
                  break;
            }
         }
         lecteurDonnées.Close();
      }

      public static void ÉcrireFichier(List<int> listeInfo)
      {
         StreamWriter écrivainDonnées = new StreamWriter(CHEMIN_ÉCRITURE + NOM_FICHIER_ENVOI);

         foreach (int info in listeInfo)
         {
            écrivainDonnées.WriteLine(info.ToString());
         }
         écrivainDonnées.Close();
      }

      public static void RéglagesBase()
      {
         Langue = LANGUE_BASE;
         RenderDistance = RENDER_D_BASE;
         Fps = FPS_BASE;
         VolMusique = VOL_MUS_BASE;
         VolEffets = VOL_EFF_BASE;
         FullscreenMode = 1;
         KeyboardMode = 1;
         NbNiveauxComplétés = NB_NIVEAUX_BASE;
         Temps = TEMPS_BASE;
      }

      //static void RéglagesModifiés()
      //{
      //   Langue = ListeInfosRecus[0];
      //   RenderDistance = ListeInfosRecus[2];
      //   Fps = ListeInfosRecus[1];
      //   VolMusique = ListeInfosRecus[3];
      //   VolEffets = ListeInfosRecus[4];
      //   FullscreenMode = ListeInfosRecus[5];
      //   KeyboardMode = ListeInfosRecus[6];
      //   NbNiveauxComplétés = ListeInfosRecus[7];
      //   Temps = new TimeSpan(ListeInfosRecus[8], ListeInfosRecus[9], 0);
      //}

      //static void ChoisirRéglages()
      //{
      //   if (PremierFichier == true)
      //   {
      //      RéglagesBase();
      //   }
      //   else
      //   {
      //      RéglagesModifiés();
      //   }
      //}
   }
}


//using AtelierXNA;
//using Microsoft.Xna.Framework;
//using Microsoft.Xna.Framework.Input;
//using System.Collections.Generic;
//using System.Linq;

//namespace HyperV
//{
//    public class Camera2 : Cam�ra
//    {
//        //const float INTERVALLE_MAJ_STANDARD = 1f / 60f;
//        //const float ACC�L�RATION = 0.001f;
//        //const float VITESSE_INITIALE_ROTATION = 5f;
//        //const float VITESSE_INITIALE_ROTATION_SOURIS = 0.1f;
//        //const float VITESSE_INITIALE_TRANSLATION = 0.5f;
//        //const float DELTA_LACET = MathHelper.Pi / 180; // 1 degr� � la fois
//        //const float DELTA_TANGAGE = MathHelper.Pi / 180; // 1 degr� � la fois
//        //const float DELTA_ROULIS = MathHelper.Pi / 180; // 1 degr� � la fois
//        //const float RAYON_COLLISION = 1f;
//        //const int HAUTEUR_PERSONNAGE = -6;

//        //Vector3 Direction { get; set; }
//        //Vector3 Lat�ral { get; set; }
//        //Maze Maze { get; set; }
//        //Walls Walls { get; set; }
//        //float VitesseTranslation { get; set; }
//        //float VitesseRotation { get; set; }
//        //Point AnciennePositionSouris { get; set; }
//        //Point NouvellePositionSouris { get; set; }
//        //Vector2 D�placementSouris { get; set; }

//        //float IntervalleMAJ { get; set; }
//        //float Temps�coul�DepuisMAJ { get; set; }
//        //InputManager GestionInput { get; set; }
//        //float Height { get; set; }
//        //List<Character> Characters { get; set; }

//        //public Camera2(Game jeu, Vector3 positionCam�ra, Vector3 cible, Vector3 orientation, float intervalleMAJ) : base(jeu)
//        //{
//        //    IntervalleMAJ = intervalleMAJ;
//        //    Cr�erVolumeDeVisualisation(OUVERTURE_OBJECTIF, DISTANCE_PLAN_RAPPROCH�, DISTANCE_PLAN_�LOIGN�);
//        //    Cr�erPointDeVue(positionCam�ra, cible, orientation);
//        //    Height = positionCam�ra.Y;
//        //}

//        //public override void Initialize()
//        //{
//        //    VitesseRotation = VITESSE_INITIALE_ROTATION;
//        //    VitesseTranslation = VITESSE_INITIALE_TRANSLATION;
//        //    Temps�coul�DepuisMAJ = 0;
//        //    base.Initialize();
//        //    GestionInput = Game.Services.GetService(typeof(InputManager)) as InputManager;
//        //    Maze = Game.Services.GetService(typeof(Maze)) as Maze;
//        //    Characters = Game.Services.GetService(typeof(List<Character>)) as List<Character>;
//        //    NouvellePositionSouris = new Point(Game.Window.ClientBounds.Width / 2, Game.Window.ClientBounds.Height / 2);
//        //    AnciennePositionSouris = new Point(NouvellePositionSouris.X, NouvellePositionSouris.Y);
//        //    Mouse.SetPosition(NouvellePositionSouris.X, NouvellePositionSouris.Y);
//        //}

//        //protected override void Cr�erPointDeVue()
//        //{
//        //    Vector3.Normalize(Direction);
//        //    Vector3.Normalize(OrientationVerticale);
//        //    Vector3.Normalize(Lat�ral);

//        //    Vue = Matrix.CreateLookAt(Position, Position + Direction, OrientationVerticale);
//        //}

//        //protected override void Cr�erPointDeVue(Vector3 position, Vector3 cible, Vector3 orientation)
//        //{
//        //    Position = position;
//        //    Cible = cible;
//        //    OrientationVerticale = orientation;

//        //    Direction = cible - Position;
//        //    //Direction = cible;

//        //    Vector3.Normalize(Cible);

//        //    Cr�erPointDeVue();
//        //}

//        //public override void Update(GameTime gameTime)
//        //{
//        //    float Temps�coul� = (float)gameTime.ElapsedGameTime.TotalSeconds;
//        //    Temps�coul�DepuisMAJ += Temps�coul�;
//        //    if (Temps�coul�DepuisMAJ >= IntervalleMAJ)
//        //    {
//        //        FonctionsSouris();
//        //        FonctionsClavier();

//        //        G�rerHauteur();
//        //        Cr�erPointDeVue();




//        //        Game.Window.Title = Position.ToString();
//        //        Position = new Vector3(Position.X, Height, Position.Z);
//        //        Temps�coul�DepuisMAJ = 0;
//        //    }
//        //    base.Update(gameTime);
//        //}

//        ////Souris
//        //#region
//        //private void FonctionsSouris()
//        //{
//        //    AnciennePositionSouris = NouvellePositionSouris;
//        //    NouvellePositionSouris = GestionInput.GetPositionSouris();
//        //    D�placementSouris = new Vector2(NouvellePositionSouris.X - AnciennePositionSouris.X,
//        //                                    NouvellePositionSouris.Y - AnciennePositionSouris.Y);

//        //    G�rerRotationSouris();

//        //    NouvellePositionSouris = new Point(Game.Window.ClientBounds.Width / 2, Game.Window.ClientBounds.Height / 2);
//        //    Mouse.SetPosition(NouvellePositionSouris.X, NouvellePositionSouris.Y);

//        //}

//        //private void G�rerRotationSouris()
//        //{
//        //    G�rerLacetSouris();
//        //    G�rerTangageSouris();
//        //}

//        //private void G�rerLacetSouris()
//        //{
//        //    Matrix matriceLacet = Matrix.Identity;

//        //    matriceLacet = Matrix.CreateFromAxisAngle(OrientationVerticale, DELTA_LACET * VITESSE_INITIALE_ROTATION_SOURIS * -D�placementSouris.X);

//        //    Direction = Vector3.Transform(Direction, matriceLacet);
//        //}

//        //private void G�rerTangageSouris()
//        //{
//        //    Matrix matriceTangage = Matrix.Identity;

//        //    matriceTangage = Matrix.CreateFromAxisAngle(Lat�ral, DELTA_TANGAGE * VITESSE_INITIALE_ROTATION_SOURIS * -D�placementSouris.Y);

//        //    Direction = Vector3.Transform(Direction, matriceTangage);
//        //}
//        //#endregion

//        ////Clavier
//        //#region
//        //private void FonctionsClavier()
//        //{
//        //    G�rerD�placement();
//        //    G�rerRotationClavier();
//        //}

//        //private void G�rerD�placement()
//        //{
//        //    float d�placementDirection = (G�rerTouche(Keys.W) - G�rerTouche(Keys.S)) * VitesseTranslation;
//        //    float d�placementLat�ral = (G�rerTouche(Keys.A) - G�rerTouche(Keys.D)) * VitesseTranslation;

//        //    Direction = Vector3.Normalize(Direction);
//        //    Lat�ral = Vector3.Cross(Direction, OrientationVerticale);
//        //    Position += d�placementDirection * Direction;
//        //    Position -= d�placementLat�ral * Lat�ral;
//        //    if (Maze.CheckForCollisions(Position))
//        //    {
//        //        Position -= d�placementDirection * Direction;
//        //        Position += d�placementLat�ral * Lat�ral;
//        //    }
//        //}

//        //const float MAX_DISTANCE = 4.5f;

//        //bool CheckForCharacterCollision()
//        //{
//        //    bool result = false;
//        //    int i;

//        //    for (i = 0; i < Characters.Count && !result; ++i)
//        //    {
//        //        result = Vector3.Distance(Characters[i].GetPosition(), Position) < MAX_DISTANCE;
//        //    }

//        //    return result;
//        //}

//        //private void G�rerRotationClavier()
//        //{
//        //    G�rerLacetClavier();
//        //    G�rerTangageClavier();
//        //}

//        //private void G�rerLacetClavier()
//        //{
//        //    Matrix matriceLacet = Matrix.Identity;

//        //    if (GestionInput.EstEnfonc�e(Keys.Left))
//        //    {
//        //        matriceLacet = Matrix.CreateFromAxisAngle(OrientationVerticale, DELTA_LACET * VITESSE_INITIALE_ROTATION);
//        //    }
//        //    if (GestionInput.EstEnfonc�e(Keys.Right))
//        //    {
//        //        matriceLacet = Matrix.CreateFromAxisAngle(OrientationVerticale, -DELTA_LACET * VITESSE_INITIALE_ROTATION);
//        //    }

//        //    Direction = Vector3.Transform(Direction, matriceLacet);
//        //}

//        //private void G�rerTangageClavier()
//        //{
//        //    Matrix matriceTangage = Matrix.Identity;

//        //    if (GestionInput.EstEnfonc�e(Keys.Down))
//        //    {
//        //        matriceTangage = Matrix.CreateFromAxisAngle(Lat�ral, -DELTA_TANGAGE * VITESSE_INITIALE_ROTATION);
//        //    }
//        //    if (GestionInput.EstEnfonc�e(Keys.Up))
//        //    {
//        //        matriceTangage = Matrix.CreateFromAxisAngle(Lat�ral, DELTA_TANGAGE * VITESSE_INITIALE_ROTATION);
//        //    }

//        //    Direction = Vector3.Transform(Direction, matriceTangage);
//        //}
//        //#endregion

//        //private void G�rerHauteur()
//        //{
//        //    Position = Maze.GetPositionWithHeight(Position, HAUTEUR_PERSONNAGE);
//        //}

//        //private int G�rerTouche(Keys touche)
//        //{
//        //    return GestionInput.EstEnfonc�e(touche) ? 1 : 0;
//        //}

//        const float INTERVALLE_MAJ_STANDARD = 1f / 60f;
//        const float ACC�L�RATION = 0.001f;
//        const float VITESSE_INITIALE_ROTATION = 5f;
//        const float VITESSE_INITIALE_ROTATION_SOURIS = 0.1f;
//        const float VITESSE_INITIALE_TRANSLATION = 0.5f;
//        const float DELTA_LACET = MathHelper.Pi / 180; // 1 degr� � la fois
//        const float DELTA_TANGAGE = MathHelper.Pi / 180; // 1 degr� � la fois
//        const float DELTA_ROULIS = MathHelper.Pi / 180; // 1 degr� � la fois
//        const float RAYON_COLLISION = 1f;
//        const int HAUTEUR_PERSONNAGE = 10;
//        const int FACTEUR_COURSE = 4;
//        const int DISTANCE_MINIMALE_POUR_RAMASSAGE = 45;

//        public Vector3 Direction { get; private set; }//
//        public Vector3 Lat�ral { get; private set; }//
//        Gazon Gazon { get; set; }
//        float VitesseTranslation { get; set; }
//        float VitesseRotation { get; set; }
//        Point AnciennePositionSouris { get; set; }
//        Point NouvellePositionSouris { get; set; }
//        Vector2 D�placementSouris { get; set; }

//        float IntervalleMAJ { get; set; }
//        float Temps�coul�DepuisMAJ { get; set; }
//        InputManager GestionInput { get; set; }
//        GamePadManager GestionGamePad { get; set; }


//        bool Sauter { get; set; }
//        bool Courrir { get; set; }
//        bool Ramasser { get; set; }

//        Ray Viseur { get; set; }

//        //Added from first Camera1
//        float Height { get; set; }
//        Maze Maze { get; set; }
//        List<Character> Characters { get; set; }

//        public Camera2(Game jeu, Vector3 positionCam�ra, Vector3 cible, Vector3 orientation, float intervalleMAJ) : base(jeu)
//        {
//            IntervalleMAJ = intervalleMAJ;
//            Cr�erVolumeDeVisualisation(OUVERTURE_OBJECTIF, DISTANCE_PLAN_RAPPROCH�, DISTANCE_PLAN_�LOIGN�);
//            Cr�erPointDeVue(positionCam�ra, cible, orientation);
//            //Added from first Camera1
//            Height = positionCam�ra.Y;
//        }

//        public override void Initialize()
//        {
//            VitesseRotation = VITESSE_INITIALE_ROTATION;
//            VitesseTranslation = VITESSE_INITIALE_TRANSLATION;
//            Temps�coul�DepuisMAJ = 0;

//            Courrir = false;
//            Sauter = false;
//            Ramasser = false;
//            Viseur = new Ray();

//            NouvellePositionSouris = new Point(Game.Window.ClientBounds.Width / 2, Game.Window.ClientBounds.Height / 2);
//            AnciennePositionSouris = new Point(NouvellePositionSouris.X, NouvellePositionSouris.Y);
//            Mouse.SetPosition(NouvellePositionSouris.X, NouvellePositionSouris.Y);
//            //NEW*****************************************
//            InGame = true;

//            base.Initialize();
//            ChargerContenu();

//            InitialiserObjetsComplexesSaut();
//            Hauteur = Height;//HAUTEUR_PERSONNAGE;
//        }

//        Boss Boss { get; set; }

//        private void ChargerContenu()
//        {
//            GestionInput = Game.Services.GetService(typeof(InputManager)) as InputManager;
//            GestionGamePad = Game.Services.GetService(typeof(GamePadManager)) as GamePadManager;
//            //Gazon = Game.Services.GetService(typeof(Gazon)) as Gazon;
//            Maze = Game.Services.GetService(typeof(Maze)) as Maze;
//            Characters = Game.Services.GetService(typeof(List<Character>)) as List<Character>;
//            Boss = Game.Services.GetService(typeof(Boss)) as Boss;
//        }


//        protected override void Cr�erPointDeVue()
//        {
//            Vector3.Normalize(Direction);
//            Vector3.Normalize(OrientationVerticale);
//            Vector3.Normalize(Lat�ral);

//            Vue = Matrix.CreateLookAt(Position, Position + Direction, OrientationVerticale);
//        }

//        protected override void Cr�erPointDeVue(Vector3 position, Vector3 cible, Vector3 orientation)
//        {
//            Position = position;
//            Cible = cible;
//            OrientationVerticale = orientation;

//            Direction = cible - Position;

//            Vector3.Normalize(Cible);

//            Cr�erPointDeVue();
//        }

//        public override void Update(GameTime gameTime)
//        {
//            float Temps�coul� = (float)gameTime.ElapsedGameTime.TotalSeconds;
//            Temps�coul�DepuisMAJ += Temps�coul�;
//            if (Temps�coul�DepuisMAJ >= IntervalleMAJ)
//            {
//                FonctionsSouris();
//                FonctionsClavier();
//                FonctionsGamePad();

//                G�rerHauteur();
//                Cr�erPointDeVue();

//                AffecterCommandes();

//                G�rerRamassage();
//                G�rerCourse();
//                G�rerSaut();

//                //Game.Window.Title = Position.ToString();
//                //Position = new Vector3(Position.X, Height, Position.Z);
//                Temps�coul�DepuisMAJ = 0;
//            }
//            base.Update(gameTime);

//        }

//        //Souris
//        #region

//        //NEW*****************************
//        bool InGame { get; set; }

//        public void SetInGame(bool inGame)
//        {
//            InGame = inGame;
//        }

//        private void FonctionsSouris()
//        {
//            AnciennePositionSouris = NouvellePositionSouris;
//            NouvellePositionSouris = GestionInput.GetPositionSouris();
//            D�placementSouris = new Vector2(NouvellePositionSouris.X - AnciennePositionSouris.X,
//                                            NouvellePositionSouris.Y - AnciennePositionSouris.Y);

//            G�rerRotationSouris();

//            //NEW**********************
//            if (InGame)
//            {
//                NouvellePositionSouris = new Point(Game.Window.ClientBounds.Width / 2, Game.Window.ClientBounds.Height / 2);
//                Mouse.SetPosition(NouvellePositionSouris.X, NouvellePositionSouris.Y);
//            }
//        }

//        private void G�rerRotationSouris()
//        {
//            G�rerLacetSouris();
//            G�rerTangageSouris();
//        }

//        private void G�rerLacetSouris()
//        {
//            Matrix matriceLacet = Matrix.CreateFromAxisAngle(OrientationVerticale, DELTA_LACET * VITESSE_INITIALE_ROTATION_SOURIS * -D�placementSouris.X);

//            Direction = Vector3.Transform(Direction, matriceLacet);
//        }

//        private void G�rerTangageSouris()
//        {
//            Matrix matriceTangage = Matrix.CreateFromAxisAngle(Lat�ral, DELTA_TANGAGE * VITESSE_INITIALE_ROTATION_SOURIS * -D�placementSouris.Y);

//            Direction = Vector3.Transform(Direction, matriceTangage);
//        }
//        #endregion

//        //Clavier
//        #region
//        private void FonctionsClavier()
//        {
//            G�rerD�placement((G�rerTouche(Keys.W) - G�rerTouche(Keys.S)),
//                             (G�rerTouche(Keys.A) - G�rerTouche(Keys.D)));
//            G�rerRotationClavier();
//        }

//        private void G�rerD�placement(float direction, float lat�ral)
//        {
//            float d�placementDirection = direction * VitesseTranslation;
//            float d�placementLat�ral = lat�ral * VitesseTranslation;

//            Direction = Vector3.Normalize(Direction);
//            Position += d�placementDirection * Direction;

//            Lat�ral = Vector3.Cross(Direction, OrientationVerticale);
//            Position -= d�placementLat�ral * Lat�ral;

//            //Added from first Camera2
//            if (Maze.CheckForCollisions(Position) || CheckForBossCollision())
//            {
//                Position -= d�placementDirection * Direction;
//                Position += d�placementLat�ral * Lat�ral;
//            }
//        }

//        //Added from first Camera
//        const float MAX_DISTANCE = 4.5f, MAX_DISTANCE_BOSS = 80f;

//        bool CheckForBossCollision()
//        {
//            return Vector3.Distance(Boss.GetPosition(), Position) < MAX_DISTANCE_BOSS;
//        }

//        bool CheckForCharacterCollision()
//        {
//            bool result = false;
//            int i;

//            for (i = 0; i < Characters.Count && !result; ++i)
//            {
//                result = Vector3.Distance(Characters[i].GetPosition(), Position) < MAX_DISTANCE;
//            }

//            return result;
//        }

//        private void G�rerRotationClavier()
//        {
//            G�rerLacetClavier();
//            G�rerTangageClavier();
//        }

//        private void G�rerLacetClavier()
//        {
//            Matrix matriceLacet = Matrix.Identity;

//            if (GestionInput.EstEnfonc�e(Keys.Left))
//            {
//                matriceLacet = Matrix.CreateFromAxisAngle(OrientationVerticale, DELTA_LACET * VITESSE_INITIALE_ROTATION);
//            }
//            if (GestionInput.EstEnfonc�e(Keys.Right))
//            {
//                matriceLacet = Matrix.CreateFromAxisAngle(OrientationVerticale, -DELTA_LACET * VITESSE_INITIALE_ROTATION);
//            }

//            Direction = Vector3.Transform(Direction, matriceLacet);
//        }

//        private void G�rerTangageClavier()
//        {
//            Matrix matriceTangage = Matrix.Identity;

//            if (GestionInput.EstEnfonc�e(Keys.Down))
//            {
//                matriceTangage = Matrix.CreateFromAxisAngle(Lat�ral, -DELTA_TANGAGE * VITESSE_INITIALE_ROTATION);
//            }
//            if (GestionInput.EstEnfonc�e(Keys.Up))
//            {
//                matriceTangage = Matrix.CreateFromAxisAngle(Lat�ral, DELTA_TANGAGE * VITESSE_INITIALE_ROTATION);
//            }

//            Direction = Vector3.Transform(Direction, matriceTangage);
//        }
//        #endregion

//        //GamePad
//        #region
//        private void FonctionsGamePad()
//        {
//            if (GestionGamePad.EstGamepadActiv�)
//            {
//                G�rerD�placement(GestionGamePad.PositionThumbStickGauche.Y,
//                                 -GestionGamePad.PositionThumbStickGauche.X);

//                D�placementSouris = new Vector2(35, -35) * GestionGamePad.PositionThumbStickDroit;
//                G�rerRotationSouris();
//            }
//        }
//        #endregion

//        private void AffecterCommandes()
//        {
//            Courrir = GestionInput.EstEnfonc�e(Keys.RightShift) ||
//                      GestionInput.EstEnfonc�e(Keys.LeftShift) ||
//                      GestionGamePad.EstEnfonc�(Buttons.LeftStick);

//            Sauter = GestionInput.EstEnfonc�e(Keys.R/*Keys.Space*/) ||
//                     GestionGamePad.EstEnfonc�(Buttons.A);

//            Ramasser = GestionInput.EstNouveauClicGauche() ||
//                       GestionInput.EstAncienClicGauche() ||
//                       GestionGamePad.EstNouveauBouton(Buttons.RightStick);
//        }

//        private void G�rerHauteur()
//        {
//            //Position = Gazon.GetPositionAvecHauteur(Position, (int)Hauteur);
//            Position = new Vector3(Position.X, Hauteur, Position.Z);
//        }

//        private int G�rerTouche(Keys touche)
//        {
//            return GestionInput.EstEnfonc�e(touche) ? 1 : 0;
//        }

//        private void G�rerRamassage()
//        {
//            Viseur = new Ray(Position, Direction);

//            foreach (Sph�reRamassable sphereRamassable in Game.Components.Where(composant => composant is Sph�reRamassable))
//            {
//                Ramasser = sphereRamassable.EstEnCollision(Viseur) <= DISTANCE_MINIMALE_POUR_RAMASSAGE &&
//                           sphereRamassable.EstEnCollision(Viseur) != null &&
//                           Ramasser;

//                //Game.Window.Title = sphereRamassable.EstEnCollision(Viseur).ToString();
//                if (Ramasser)
//                {
//                    sphereRamassable.EstRamass�e = true;
//                }
//            }
//        }

//        //Saut
//        #region
//        private void G�rerSaut()
//        {
//            if (Sauter)
//            {
//                ContinuerSaut = true;
//            }

//            if (ContinuerSaut)
//            {
//                if (t > 60)
//                {
//                    InitialiserObjetsComplexesSaut();
//                    ContinuerSaut = false;
//                    t = 0;
//                }
//                Hauteur = CalculerBesier(t * (1f / 60f), PtsDeControle).Y;
//                ++t;
//            }
//        }

//        bool ContinuerSaut { get; set; }
//        float t { get; set; }
//        float Hauteur { get; set; }

//        Vector3 PositionPtsDeControle { get; set; }
//        Vector3 PositionPtsDeControlePlusUn { get; set; }
//        Vector3[] PtsDeControle { get; set; }

//        void InitialiserObjetsComplexesSaut()
//        {
//            Position = new Vector3(Position.X, Height/*HAUTEUR_PERSONNAGE*/, Position.Z);
//            PositionPtsDeControle = new Vector3(Position.X, Position.Y, Position.Z);
//            PositionPtsDeControlePlusUn = Position + Vector3.Normalize(new Vector3(Direction.X, 0, Direction.Z)) * 25;
//            //Position = new Vector3(PositionPtsDeControle.X, PositionPtsDeControle.Y, PositionPtsDeControle.Z);//******
//            //Direction = PositionPtsDeControlePlusUn - PositionPtsDeControle;//******
//            PtsDeControle = CalculerPointsControle();
//        }

//        private Vector3[] CalculerPointsControle()
//        {
//            Vector3[] pts = new Vector3[4];
//            pts[0] = PositionPtsDeControle;
//            pts[3] = PositionPtsDeControlePlusUn;
//            pts[1] = new Vector3(pts[0].X, pts[0].Y + 20, pts[0].Z);
//            pts[2] = new Vector3(pts[3].X, pts[3].Y + 20, pts[3].Z);
//            return pts;
//        }

//        private Vector3 CalculerBesier(float t, Vector3[] PtsDeControle)
//        {
//            float x = (1 - t);
//            return PtsDeControle[0] * (x * x * x) +
//                   3 * PtsDeControle[1] * t * (x * x) +
//                   3 * PtsDeControle[2] * t * t * x +
//                   PtsDeControle[3] * t * t * t;

//        }
//        #endregion

//        private void G�rerCourse()
//        {
//            VitesseTranslation = Courrir ? FACTEUR_COURSE * VITESSE_INITIALE_TRANSLATION : VITESSE_INITIALE_TRANSLATION;
//        }
//    }
//}



using AtelierXNA;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Linq;

namespace HyperV
{
    public class Camera2 : Cam�raJoueur
    {
        //Added from first Camera1
        float Height { get; set; }

        Maze Maze { get; set; }
        List<Character> Characters { get; set; }
        Boss Boss { get; set; }

        public Camera2(Game jeu, Vector3 positionCam�ra, Vector3 cible, Vector3 orientation, float intervalleMAJ, float renderDistance)
            : base(jeu, positionCam�ra, cible, orientation, intervalleMAJ, renderDistance)
        { }

        protected override void ChargerContenu()
        {
            base.ChargerContenu();
            Maze = Game.Services.GetService(typeof(Maze)) as Maze;
            Characters = Game.Services.GetService(typeof(List<Character>)) as List<Character>;
            Boss = Game.Services.GetService(typeof(Boss)) as Boss;
        }

        protected override void G�rerD�placement(float direction, float lat�ral)
        {
            base.G�rerD�placement(direction, lat�ral);

            if (Maze.CheckForCollisions(Position) || CheckForBossCollision())
            {
                Position -= direction * VitesseTranslation * Direction;
                Position += lat�ral * VitesseTranslation * Lat�ral;
            }
        }

        const float MAX_DISTANCE = 4.5f, MAX_DISTANCE_BOSS = 80f;

        bool CheckForBossCollision()
        {
            return Vector3.Distance(Boss.GetPosition(), Position) < MAX_DISTANCE_BOSS;
        }
    }
}


﻿//using AtelierXNA;
//using Microsoft.Xna.Framework;
//using Microsoft.Xna.Framework.Input;
//using System.Collections.Generic;

//namespace HyperV
//{
//    public class CaméraJoueur : Caméra
//    {
//        //const float INTERVALLE_MAJ_STANDARD = 1f / 60f;
//        //const float ACCÉLÉRATION = 0.001f;
//        //const float VITESSE_INITIALE_ROTATION = 5f;
//        //const float VITESSE_INITIALE_TRANSLATION = 0.5f;
//        //const float DELTA_LACET = MathHelper.Pi / 180; // 1 degré à la fois
//        //const float DELTA_TANGAGE = MathHelper.Pi / 180; // 1 degré à la fois
//        //const float DELTA_ROULIS = MathHelper.Pi / 180; // 1 degré à la fois
//        //const float RAYON_COLLISION = 1f;
//        //const int HAUTEUR_PERSONNAGE = 10;

//        //Vector3 Direction { get; set; }
//        //Vector3 Latéral { get; set; }
//        //Grass Gazon { get; set; }
//        //float VitesseTranslation { get; set; }
//        //float VitesseRotation { get; set; }

//        //float IntervalleMAJ { get; set; }
//        //float TempsÉcouléDepuisMAJ { get; set; }
//        //InputManager GestionInput { get; set; }

//        //bool estEnZoom;
//        //bool EstEnZoom
//        //{
//        //    get { return estEnZoom; }
//        //    set
//        //    {
//        //        float ratioAffichage = Game.GraphicsDevice.Viewport.AspectRatio;
//        //        estEnZoom = value;
//        //        if (estEnZoom)
//        //        {
//        //            CréerVolumeDeVisualisation(OUVERTURE_OBJECTIF / 2, ratioAffichage, DISTANCE_PLAN_RAPPROCHÉ, DISTANCE_PLAN_ÉLOIGNÉ);
//        //        }
//        //        else
//        //        {
//        //            CréerVolumeDeVisualisation(OUVERTURE_OBJECTIF, ratioAffichage, DISTANCE_PLAN_RAPPROCHÉ, DISTANCE_PLAN_ÉLOIGNÉ);
//        //        }
//        //    }
//        //}

//        //public CaméraJoueur(Game jeu, Vector3 positionCaméra, Vector3 cible, Vector3 orientation, float intervalleMAJ)
//        //   : base(jeu)
//        //{
//        //    IntervalleMAJ = intervalleMAJ;
//        //    CréerVolumeDeVisualisation(OUVERTURE_OBJECTIF, DISTANCE_PLAN_RAPPROCHÉ, DISTANCE_PLAN_ÉLOIGNÉ);
//        //    CréerPointDeVue(positionCaméra, cible, orientation);
//        //    EstEnZoom = false;
//        //}

//        //public override void Initialize()
//        //{
//        //    VitesseRotation = VITESSE_INITIALE_ROTATION;
//        //    VitesseTranslation = VITESSE_INITIALE_TRANSLATION;
//        //    TempsÉcouléDepuisMAJ = 0;
//        //    base.Initialize();
//        //    GestionInput = Game.Services.GetService(typeof(InputManager)) as InputManager;
//        //    Gazon = Game.Services.GetService(typeof(Grass)) as Grass;
//        //}

//        //protected override void CréerPointDeVue()
//        //{
//        //    Vector3.Normalize(Direction);
//        //    Vector3.Normalize(OrientationVerticale);
//        //    Vector3.Normalize(Latéral);

//        //    Vue = Matrix.CreateLookAt(Position, Position + Direction, OrientationVerticale);

//        //}

//        //protected override void CréerPointDeVue(Vector3 position, Vector3 cible, Vector3 orientation)
//        //{
//        //    Position = position;
//        //    Cible = cible;
//        //    OrientationVerticale = orientation;

//        //    Direction = cible - Position;

//        //    Vector3.Normalize(Cible);

//        //    CréerPointDeVue();
//        //}

//        //public override void Update(GameTime gameTime)
//        //{
//        //    float TempsÉcoulé = (float)gameTime.ElapsedGameTime.TotalSeconds;
//        //    TempsÉcouléDepuisMAJ += TempsÉcoulé;
//        //    GestionClavier();
//        //    if (TempsÉcouléDepuisMAJ >= IntervalleMAJ)
//        //    {
//        //        if (GestionInput.EstEnfoncée(Keys.LeftShift) || GestionInput.EstEnfoncée(Keys.RightShift))
//        //        {
//        //            GérerAccélération();
//        //            GérerDéplacement();
//        //            GérerRotation();
//        //            CréerPointDeVue();
//        //            GérerHauteur();
//        //            Game.Window.Title = Position.ToString();
//        //        }
//        //        TempsÉcouléDepuisMAJ = 0;
//        //    }
//        //    base.Update(gameTime);
//        //}

//        //private void GérerHauteur()
//        //{
//        //    Position = Gazon.GetPositionAvecHauteur(Position, HAUTEUR_PERSONNAGE);
//        //}

//        //#region
//        //private int GérerTouche(Keys touche)
//        //{
//        //    return GestionInput.EstEnfoncée(touche) ? 1 : 0;
//        //}

//        //private void GérerAccélération()
//        //{
//        //    int valAccélération = (GérerTouche(Keys.Subtract) + GérerTouche(Keys.OemMinus)) - (GérerTouche(Keys.Add) + GérerTouche(Keys.OemPlus));
//        //    if (valAccélération != 0)
//        //    {
//        //        IntervalleMAJ += ACCÉLÉRATION * valAccélération;
//        //        IntervalleMAJ = MathHelper.Max(INTERVALLE_MAJ_STANDARD, IntervalleMAJ);
//        //    }
//        //}

//        //private void GérerDéplacement()
//        //{
//        //    float déplacementDirection = (GérerTouche(Keys.W) - GérerTouche(Keys.S)) * VitesseTranslation;
//        //    float déplacementLatéral = (GérerTouche(Keys.A) - GérerTouche(Keys.D)) * VitesseTranslation;

//        //    Direction = Vector3.Normalize(Direction);
//        //    Position += déplacementDirection * Direction;

//        //    Latéral = Vector3.Cross(Direction, OrientationVerticale);
//        //    Position -= déplacementLatéral * Latéral;
//        //}

//        //private void GérerRotation()
//        //{
//        //    GérerLacet();
//        //    GérerTangage();
//        //    GérerRoulis();
//        //}

//        //private void GérerLacet()
//        //{
//        //    Matrix matriceLacet = Matrix.Identity;

//        //    if (GestionInput.EstEnfoncée(Keys.Left))
//        //    {
//        //        matriceLacet = Matrix.CreateFromAxisAngle(OrientationVerticale, DELTA_LACET*VITESSE_INITIALE_ROTATION);
//        //    }
//        //    if(GestionInput.EstEnfoncée(Keys.Right))
//        //    {
//        //        matriceLacet = Matrix.CreateFromAxisAngle(OrientationVerticale, -DELTA_LACET* VITESSE_INITIALE_ROTATION);
//        //    }

//        //    Direction = Vector3.Transform(Direction, matriceLacet);
//        //}

//        //private void GérerTangage()
//        //{
//        //    Matrix matriceTangage = Matrix.Identity;

//        //    if (GestionInput.EstEnfoncée(Keys.Down))
//        //    {
//        //        matriceTangage = Matrix.CreateFromAxisAngle(Latéral, -DELTA_TANGAGE* VITESSE_INITIALE_ROTATION);
//        //    }
//        //    if(GestionInput.EstEnfoncée(Keys.Up))
//        //    {
//        //        matriceTangage = Matrix.CreateFromAxisAngle(Latéral, DELTA_TANGAGE* VITESSE_INITIALE_ROTATION);
//        //    }

//        //    Direction = Vector3.Transform(Direction, matriceTangage);
//        //    //OrientationVerticale = Vector3.Transform(OrientationVerticale, matriceTangage);
//        //}

//        //private void GérerRoulis()
//        //{
//        //    Matrix matriceRoulis = Matrix.Identity;

//        //    if (GestionInput.EstEnfoncée(Keys.PageUp))
//        //    {
//        //        matriceRoulis = Matrix.CreateFromAxisAngle(Direction, DELTA_ROULIS* VITESSE_INITIALE_ROTATION);
//        //    }
//        //    if(GestionInput.EstEnfoncée(Keys.PageDown))
//        //    {
//        //        matriceRoulis = Matrix.CreateFromAxisAngle(Direction, -DELTA_ROULIS* VITESSE_INITIALE_ROTATION);
//        //    }

//        //    OrientationVerticale = Vector3.Transform(OrientationVerticale, matriceRoulis);
//        //}

//        //private void GestionClavier()
//        //{
//        //    if (GestionInput.EstNouvelleTouche(Keys.Z))
//        //    {
//        //        EstEnZoom = !EstEnZoom;
//        //    }
//        //}
//        //#endregion


//        const float INTERVALLE_MAJ_STANDARD = 1f / 60f;
//        const float ACCÉLÉRATION = 0.001f;
//        const float VITESSE_INITIALE_ROTATION = 5f;
//        const float VITESSE_INITIALE_ROTATION_SOURIS = 0.1f;
//        const float VITESSE_INITIALE_TRANSLATION = 0.5f;
//        const float DELTA_LACET = MathHelper.Pi / 180; // 1 degré à la fois
//        const float DELTA_TANGAGE = MathHelper.Pi / 180; // 1 degré à la fois
//        const float DELTA_ROULIS = MathHelper.Pi / 180; // 1 degré à la fois
//        const float RAYON_COLLISION = 1f;
//        const int HAUTEUR_PERSONNAGE = -6;

//        Vector3 Direction { get; set; }
//        Vector3 Latéral { get; set; }
//        Maze Maze { get; set; }
//        //Grass Grass { get; set; }
//        Walls Walls { get; set; }
//        float VitesseTranslation { get; set; }
//        float VitesseRotation { get; set; }
//        Point AnciennePositionSouris { get; set; }
//        Point NouvellePositionSouris { get; set; }
//        Vector2 DéplacementSouris { get; set; }

//        float IntervalleMAJ { get; set; }
//        float TempsÉcouléDepuisMAJ { get; set; }
//        InputManager GestionInput { get; set; }
//        float Height { get; set; }
//        List<Character> Characters { get; set; }

//        public CaméraJoueur(Game jeu, Vector3 positionCaméra, Vector3 cible, Vector3 orientation, float intervalleMAJ)
//           : base(jeu)
//        {
//            IntervalleMAJ = intervalleMAJ;
//            CréerVolumeDeVisualisation(OUVERTURE_OBJECTIF, DISTANCE_PLAN_RAPPROCHÉ, 100); // 500 DISTANCE_PLAN_ÉLOIGNÉ
//            CréerPointDeVue(positionCaméra, cible, orientation);
//            Height = positionCaméra.Y;
//        }

//        public override void Initialize()
//        {
//            VitesseRotation = VITESSE_INITIALE_ROTATION;
//            VitesseTranslation = VITESSE_INITIALE_TRANSLATION;
//            TempsÉcouléDepuisMAJ = 0;
//            base.Initialize();
//            GestionInput = Game.Services.GetService(typeof(InputManager)) as InputManager;
//            Maze = Game.Services.GetService(typeof(Maze)) as Maze;
//            //Grass = Game.Services.GetService(typeof(Grass)) as Grass;
//            //Walls = Game.Services.GetService(typeof(Walls)) as Walls;
//            Characters = Game.Services.GetService(typeof(List<Character>)) as List<Character>;
//            NouvellePositionSouris = new Point(Game.Window.ClientBounds.Width / 2, Game.Window.ClientBounds.Height / 2);
//            AnciennePositionSouris = new Point(NouvellePositionSouris.X, NouvellePositionSouris.Y);
//            Mouse.SetPosition(NouvellePositionSouris.X, NouvellePositionSouris.Y);
//        }

//        protected override void CréerPointDeVue()
//        {
//            Vector3.Normalize(Direction);
//            Vector3.Normalize(OrientationVerticale);
//            Vector3.Normalize(Latéral);

//            Vue = Matrix.CreateLookAt(Position, Position + Direction, OrientationVerticale);
//        }

//        protected override void CréerPointDeVue(Vector3 position, Vector3 cible, Vector3 orientation)
//        {
//            Position = position;
//            Cible = cible;
//            OrientationVerticale = orientation;

//            Direction = cible - Position;
//            //Direction = cible;

//            Vector3.Normalize(Cible);

//            CréerPointDeVue();
//        }

//        public override void Update(GameTime gameTime)
//        {
//            float TempsÉcoulé = (float)gameTime.ElapsedGameTime.TotalSeconds;
//            TempsÉcouléDepuisMAJ += TempsÉcoulé;
//            if (TempsÉcouléDepuisMAJ >= IntervalleMAJ)
//            {
//                FonctionsSouris();
//                FonctionsClavier();

//                GérerHauteur();
//                CréerPointDeVue();




//                Game.Window.Title = Position.ToString();
//                Position = new Vector3(Position.X, Height, Position.Z);
//                TempsÉcouléDepuisMAJ = 0;
//            }
//            base.Update(gameTime);
//        }

//        //Souris
//        #region
//        private void FonctionsSouris()
//        {
//            AnciennePositionSouris = NouvellePositionSouris;
//            NouvellePositionSouris = GestionInput.GetPositionSouris();
//            DéplacementSouris = new Vector2(NouvellePositionSouris.X - AnciennePositionSouris.X,
//                                            NouvellePositionSouris.Y - AnciennePositionSouris.Y);

//            GérerRotationSouris();

//            NouvellePositionSouris = new Point(Game.Window.ClientBounds.Width / 2, Game.Window.ClientBounds.Height / 2);
//            Mouse.SetPosition(NouvellePositionSouris.X, NouvellePositionSouris.Y);

//        }

//        private void GérerRotationSouris()
//        {
//            GérerLacetSouris();
//            GérerTangageSouris();
//        }

//        private void GérerLacetSouris()
//        {
//            Matrix matriceLacet = Matrix.Identity;

//            matriceLacet = Matrix.CreateFromAxisAngle(OrientationVerticale, DELTA_LACET * VITESSE_INITIALE_ROTATION_SOURIS * -DéplacementSouris.X);

//            Direction = Vector3.Transform(Direction, matriceLacet);
//        }

//        private void GérerTangageSouris()
//        {
//            Matrix matriceTangage = Matrix.Identity;

//            matriceTangage = Matrix.CreateFromAxisAngle(Latéral, DELTA_TANGAGE * VITESSE_INITIALE_ROTATION_SOURIS * -DéplacementSouris.Y);

//            Direction = Vector3.Transform(Direction, matriceTangage);
//        }
//        #endregion

//        //Clavier
//        #region
//        private void FonctionsClavier()
//        {
//            GérerDéplacement();
//            GérerRotationClavier();
//        }

//        private void GérerDéplacement()
//        {
//            float déplacementDirection = (GérerTouche(Keys.W) - GérerTouche(Keys.S)) * VitesseTranslation;
//            float déplacementLatéral = (GérerTouche(Keys.A) - GérerTouche(Keys.D)) * VitesseTranslation;

//            Direction = Vector3.Normalize(Direction);
//            Latéral = Vector3.Cross(Direction, OrientationVerticale);
//            Position += déplacementDirection * Direction;
//            Position -= déplacementLatéral * Latéral;
//            if (Maze.CheckForCollisions(Position))
//            {
//                Position -= déplacementDirection * Direction;
//                Position += déplacementLatéral * Latéral;
//            }
//            //Vector3 newDirection = new Vector3(0, 0, 0);
//            //if (Walls.CheckForCollisions(Position, ref newDirection, Direction) || CheckForCharacterCollision())
//            //{
//            //    Position -= déplacementDirection * Direction;
//            //    //Position += déplacementDirection * newDirection;
//            //    Position += déplacementLatéral * Latéral;
//            //}
//        }

//        const float MAX_DISTANCE = 4.5f;

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

//        private void GérerRotationClavier()
//        {
//            GérerLacetClavier();
//            GérerTangageClavier();
//        }

//        private void GérerLacetClavier()
//        {
//            Matrix matriceLacet = Matrix.Identity;

//            if (GestionInput.EstEnfoncée(Keys.Left))
//            {
//                matriceLacet = Matrix.CreateFromAxisAngle(OrientationVerticale, DELTA_LACET * VITESSE_INITIALE_ROTATION);
//            }
//            if (GestionInput.EstEnfoncée(Keys.Right))
//            {
//                matriceLacet = Matrix.CreateFromAxisAngle(OrientationVerticale, -DELTA_LACET * VITESSE_INITIALE_ROTATION);
//            }

//            Direction = Vector3.Transform(Direction, matriceLacet);
//        }

//        private void GérerTangageClavier()
//        {
//            Matrix matriceTangage = Matrix.Identity;

//            if (GestionInput.EstEnfoncée(Keys.Down))
//            {
//                matriceTangage = Matrix.CreateFromAxisAngle(Latéral, -DELTA_TANGAGE * VITESSE_INITIALE_ROTATION);
//            }
//            if (GestionInput.EstEnfoncée(Keys.Up))
//            {
//                matriceTangage = Matrix.CreateFromAxisAngle(Latéral, DELTA_TANGAGE * VITESSE_INITIALE_ROTATION);
//            }

//            Direction = Vector3.Transform(Direction, matriceTangage);
//        }
//        #endregion

//        private void GérerHauteur()
//        {
//            Position = Maze.GetPositionWithHeight(Position, HAUTEUR_PERSONNAGE);//Grass.GetPositionWithHeight(Position, HAUTEUR_PERSONNAGE);
//        }

//        private int GérerTouche(Keys touche)
//        {
//            return GestionInput.EstEnfoncée(touche) ? 1 : 0;
//        }
//        //const float INTERVALLE_MAJ_STANDARD = 1f / 60f;
//        //const float ACCÉLÉRATION = 0.001f;
//        //const float VITESSE_INITIALE_ROTATION = 5f;
//        //const float VITESSE_INITIALE_ROTATION_SOURIS = 0.1f;
//        //const float VITESSE_INITIALE_TRANSLATION = 0.5f;
//        //const float DELTA_LACET = MathHelper.Pi / 180; // 1 degré à la fois
//        //const float DELTA_TANGAGE = MathHelper.Pi / 180; // 1 degré à la fois
//        //const float DELTA_ROULIS = MathHelper.Pi / 180; // 1 degré à la fois
//        //const float RAYON_COLLISION = 1f;
//        //const int HAUTEUR_PERSONNAGE = 10;

//        //Vector3 Direction { get; set; }
//        //Vector3 Latéral { get; set; }
//        //Gazon Gazon { get; set; }
//        //float VitesseTranslation { get; set; }
//        //float VitesseRotation { get; set; }
//        //Point AnciennePositionSouris { get; set; }
//        //Point NouvellePositionSouris { get; set; }
//        //Vector2 DéplacementSouris { get; set; }

//        //float IntervalleMAJ { get; set; }
//        //float TempsÉcouléDepuisMAJ { get; set; }
//        //InputManager GestionInput { get; set; }

//        //public CaméraJoueur(Game jeu, Vector3 positionCaméra, Vector3 cible, Vector3 orientation, float intervalleMAJ)
//        //   : base(jeu)
//        //{
//        //    IntervalleMAJ = intervalleMAJ;
//        //    CréerVolumeDeVisualisation(OUVERTURE_OBJECTIF, DISTANCE_PLAN_RAPPROCHÉ, DISTANCE_PLAN_ÉLOIGNÉ);
//        //    CréerPointDeVue(positionCaméra, cible, orientation);
//        //}

//        //public override void Initialize()
//        //{
//        //    VitesseRotation = VITESSE_INITIALE_ROTATION;
//        //    VitesseTranslation = VITESSE_INITIALE_TRANSLATION;
//        //    TempsÉcouléDepuisMAJ = 0;
//        //    base.Initialize();
//        //    GestionInput = Game.Services.GetService(typeof(InputManager)) as InputManager;
//        //    Gazon = Game.Services.GetService(typeof(Gazon)) as Gazon;
//        //    NouvellePositionSouris = new Point(Game.Window.ClientBounds.Width / 2, Game.Window.ClientBounds.Height / 2);
//        //    AnciennePositionSouris = new Point(NouvellePositionSouris.X, NouvellePositionSouris.Y);
//        //    Mouse.SetPosition(NouvellePositionSouris.X, NouvellePositionSouris.Y);
//        //}

//        //protected override void CréerPointDeVue()
//        //{
//        //    Vector3.Normalize(Direction);
//        //    Vector3.Normalize(OrientationVerticale);
//        //    Vector3.Normalize(Latéral);

//        //    Vue = Matrix.CreateLookAt(Position, Position + Direction, OrientationVerticale);
//        //}

//        //protected override void CréerPointDeVue(Vector3 position, Vector3 cible, Vector3 orientation)
//        //{
//        //    Position = position;
//        //    Cible = cible;
//        //    OrientationVerticale = orientation;

//        //    Direction = cible - Position;

//        //    Vector3.Normalize(Cible);

//        //    CréerPointDeVue();
//        //}

//        //public override void Update(GameTime gameTime)
//        //{
//        //    float TempsÉcoulé = (float)gameTime.ElapsedGameTime.TotalSeconds;
//        //    TempsÉcouléDepuisMAJ += TempsÉcoulé;
//        //    if (TempsÉcouléDepuisMAJ >= IntervalleMAJ)
//        //    {
//        //        FonctionsSouris();
//        //        FonctionsClavier();

//        //        GérerHauteur();
//        //        CréerPointDeVue();


//        //        GérerRamassage();

//        //        //Game.Window.Title = Position.ToString();

//        //        TempsÉcouléDepuisMAJ = 0;
//        //    }
//        //    base.Update(gameTime);
//        //}

//        ////Souris
//        //#region
//        //private void FonctionsSouris()
//        //{
//        //    AnciennePositionSouris = NouvellePositionSouris;
//        //    NouvellePositionSouris = GestionInput.GetPositionSouris();
//        //    DéplacementSouris = new Vector2(NouvellePositionSouris.X - AnciennePositionSouris.X,
//        //                                    NouvellePositionSouris.Y - AnciennePositionSouris.Y);

//        //    GérerRotationSouris();

//        //    NouvellePositionSouris = new Point(Game.Window.ClientBounds.Width / 2, Game.Window.ClientBounds.Height / 2);
//        //    Mouse.SetPosition(NouvellePositionSouris.X, NouvellePositionSouris.Y);

//        //}

//        //private void GérerRotationSouris()
//        //{
//        //    GérerLacetSouris();
//        //    GérerTangageSouris();
//        //}

//        //private void GérerLacetSouris()
//        //{
//        //    Matrix matriceLacet = Matrix.Identity;

//        //    matriceLacet = Matrix.CreateFromAxisAngle(OrientationVerticale, DELTA_LACET * VITESSE_INITIALE_ROTATION_SOURIS * -DéplacementSouris.X);

//        //    Direction = Vector3.Transform(Direction, matriceLacet);
//        //}

//        //private void GérerTangageSouris()
//        //{
//        //    Matrix matriceTangage = Matrix.Identity;

//        //    matriceTangage = Matrix.CreateFromAxisAngle(Latéral, DELTA_TANGAGE * VITESSE_INITIALE_ROTATION_SOURIS * -DéplacementSouris.Y);

//        //    Direction = Vector3.Transform(Direction, matriceTangage);
//        //}
//        //#endregion

//        ////Clavier
//        //#region
//        //private void FonctionsClavier()
//        //{
//        //    GérerDéplacement();
//        //    GérerRotationClavier();
//        //}

//        //private void GérerDéplacement()
//        //{
//        //    float déplacementDirection = (GérerTouche(Keys.W) - GérerTouche(Keys.S)) * VitesseTranslation;
//        //    float déplacementLatéral = (GérerTouche(Keys.A) - GérerTouche(Keys.D)) * VitesseTranslation;

//        //    Direction = Vector3.Normalize(Direction);
//        //    Position += déplacementDirection * Direction;

//        //    Latéral = Vector3.Cross(Direction, OrientationVerticale);
//        //    Position -= déplacementLatéral * Latéral;
//        //}

//        //private void GérerRotationClavier()
//        //{
//        //    GérerLacetClavier();
//        //    GérerTangageClavier();
//        //}

//        //private void GérerLacetClavier()
//        //{
//        //    Matrix matriceLacet = Matrix.Identity;

//        //    if (GestionInput.EstEnfoncée(Keys.Left))
//        //    {
//        //        matriceLacet = Matrix.CreateFromAxisAngle(OrientationVerticale, DELTA_LACET * VITESSE_INITIALE_ROTATION);
//        //    }
//        //    if (GestionInput.EstEnfoncée(Keys.Right))
//        //    {
//        //        matriceLacet = Matrix.CreateFromAxisAngle(OrientationVerticale, -DELTA_LACET * VITESSE_INITIALE_ROTATION);
//        //    }

//        //    Direction = Vector3.Transform(Direction, matriceLacet);
//        //}

//        //private void GérerTangageClavier()
//        //{
//        //    Matrix matriceTangage = Matrix.Identity;

//        //    if (GestionInput.EstEnfoncée(Keys.Down))
//        //    {
//        //        matriceTangage = Matrix.CreateFromAxisAngle(Latéral, -DELTA_TANGAGE * VITESSE_INITIALE_ROTATION);
//        //    }
//        //    if (GestionInput.EstEnfoncée(Keys.Up))
//        //    {
//        //        matriceTangage = Matrix.CreateFromAxisAngle(Latéral, DELTA_TANGAGE * VITESSE_INITIALE_ROTATION);
//        //    }

//        //    Direction = Vector3.Transform(Direction, matriceTangage);
//        //}
//        //#endregion

//        //private void GérerHauteur()
//        //{
//        //    Position = Gazon.GetPositionAvecHauteur(Position, HAUTEUR_PERSONNAGE);
//        //}

//        //private int GérerTouche(Keys touche)
//        //{
//        //    return GestionInput.EstEnfoncée(touche) ? 1 : 0;
//        //}

//        //private void GérerRamassage()
//        //{
//        //    //Ray viseur = new Ray(Position, Direction);

//        //    //foreach (SphereRamassable sphereRamassable in Game.Components.Where(composant => composant is SphèreRamassable))
//        //    //{
//        //    //    Game.Window.Title = sphereRamassable.EstEnCollision(viseur).ToString();
//        //    //    //if (sphereRamassable.EstEnCollision(viseur) != null)
//        //    //    //{
//        //    //    //    Game.Window.Title = "true";
//        //    //    //}
//        //    //    //else
//        //    //    //{
//        //    //    //    Game.Window.Title = "false";
//        //    //    //}
//        //    //}
//        //}
//    }
//}


































using AtelierXNA;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Linq;

namespace HyperV
{
    public class CaméraJoueur : Caméra
    {
        const float INTERVALLE_MAJ_STANDARD = 1f / 60f;
        const float ACCÉLÉRATION = 0.001f;
        const float VITESSE_INITIALE_ROTATION = 5f;
        const float VITESSE_INITIALE_ROTATION_SOURIS = 0.1f;
        const float VITESSE_INITIALE_TRANSLATION = 0.5f;
        const float DELTA_LACET = MathHelper.Pi / 180; // 1 degré à la fois
        const float DELTA_TANGAGE = MathHelper.Pi / 180; // 1 degré à la fois
        const float DELTA_ROULIS = MathHelper.Pi / 180; // 1 degré à la fois
        const float RAYON_COLLISION = 1f;
        const int HAUTEUR_PERSONNAGE = 10;
        const int FACTEUR_COURSE_MAXIMAL = 4;
        const int DISTANCE_MINIMALE_POUR_RAMASSAGE = 45;

        public Vector3 Direction { get; private set; }//
        public Vector3 Latéral { get; private set; }//
        Gazon Gazon { get; set; }
        protected float VitesseTranslation { get; set; }
        float VitesseRotation { get; set; }
        Point AnciennePositionSouris { get; set; }
        Point NouvellePositionSouris { get; set; }
        Vector2 DéplacementSouris { get; set; }

        float IntervalleMAJ { get; set; }
        float TempsÉcouléDepuisMAJ { get; set; }
        InputManager GestionInput { get; set; }
        GamePadManager GestionGamePad { get; set; }

        bool Sauter { get; set; }
        bool Courrir { get; set; }
        bool Ramasser { get; set; }

        public bool EstCaméraSourisActivée { get; set; }
        bool EstDéplacementEtAutresClavierActivé { get; set; }
        bool EstCaméraClavierActivée { get; set; }

        Ray Viseur { get; set; }

        float Height { get; set; }

        public CaméraJoueur(Game jeu, Vector3 positionCaméra, Vector3 cible, Vector3 orientation, float intervalleMAJ, float renderDistance) : base(jeu)
        {
            DistancePlanÉloigné = renderDistance;
            IntervalleMAJ = intervalleMAJ;
            CréerVolumeDeVisualisation(OUVERTURE_OBJECTIF, DISTANCE_PLAN_RAPPROCHÉ, /*DISTANCE_PLAN_ÉLOIGNÉ*/DistancePlanÉloigné);
            CréerPointDeVue(positionCaméra, cible, orientation);
            Height = positionCaméra.Y;
        }

        public float GetRenderDistance()
        {
            return DistancePlanÉloigné;
        }

        public void SetRenderDistance(float renderDistance)
        {
            DistancePlanÉloigné = renderDistance;
            CréerVolumeDeVisualisation(OUVERTURE_OBJECTIF, DISTANCE_PLAN_RAPPROCHÉ, /*DISTANCE_PLAN_ÉLOIGNÉ*/DistancePlanÉloigné);
            //CréerPointDeVue(Position, Cible, Orientation);
        }

        public void InitializeDirection(Vector3 direction)
        {
            Direction = direction;
        }

        public override void Initialize()
        {
            VitesseRotation = VITESSE_INITIALE_ROTATION;
            VitesseTranslation = VITESSE_INITIALE_TRANSLATION;
            TempsÉcouléDepuisMAJ = 0;

            EstDéplacementEtAutresClavierActivé = true;
            EstCaméraClavierActivée = true;

            Courrir = false;
            Sauter = false;
            Ramasser = false;

            EstCaméraSourisActivée = true;


            Viseur = new Ray();

            NouvellePositionSouris = new Point(Game.Window.ClientBounds.Width / 2, Game.Window.ClientBounds.Height / 2);
            AnciennePositionSouris = new Point(NouvellePositionSouris.X, NouvellePositionSouris.Y);
            Mouse.SetPosition(NouvellePositionSouris.X, NouvellePositionSouris.Y);

            base.Initialize();
            ChargerContenu();

            InitialiserObjetsComplexesSaut();
            Hauteur = Height;//HAUTEUR_PERSONNAGE;
        }

        protected virtual void ChargerContenu()
        {
            GestionInput = Game.Services.GetService(typeof(InputManager)) as InputManager;
            GestionGamePad = Game.Services.GetService(typeof(GamePadManager)) as GamePadManager;
        }

        protected override void CréerPointDeVue()
        {
            Vector3.Normalize(Direction);
            Vector3.Normalize(OrientationVerticale);
            Vector3.Normalize(Latéral);

            Vue = Matrix.CreateLookAt(Position, Position + Direction, OrientationVerticale);
        }

        protected override void CréerPointDeVue(Vector3 position, Vector3 cible, Vector3 orientation)
        {
            Position = position;
            Cible = cible;
            OrientationVerticale = orientation;

            Direction = cible - Position;

            Vector3.Normalize(Cible);

            CréerPointDeVue();
        }

        public override void Update(GameTime gameTime)
        {

            float TempsÉcoulé = (float)gameTime.ElapsedGameTime.TotalSeconds;
            TempsÉcouléDepuisMAJ += TempsÉcoulé;
            if (TempsÉcouléDepuisMAJ >= IntervalleMAJ)
            {
                FonctionsSouris();
                FonctionsClavier();
                FonctionsGamePad();

                GérerHauteur();
                CréerPointDeVue();

                AffecterCommandes();

                GérerRamassage();
                GérerCourse();
                GérerSaut();

                //Game.Window.Title = GestionGamePad.PositionsGâchettes.X.ToString();
                TempsÉcouléDepuisMAJ = 0;
            }
            base.Update(gameTime);

        }

        //Souris
        #region
        private void FonctionsSouris()
        {
            if (EstCaméraSourisActivée)
            {
                AnciennePositionSouris = NouvellePositionSouris;
                NouvellePositionSouris = GestionInput.GetPositionSouris();
                DéplacementSouris = new Vector2(NouvellePositionSouris.X - AnciennePositionSouris.X,
                                                NouvellePositionSouris.Y - AnciennePositionSouris.Y);

                GérerRotationSouris();

                NouvellePositionSouris = new Point(Game.Window.ClientBounds.Width / 2, Game.Window.ClientBounds.Height / 2);
                Mouse.SetPosition(NouvellePositionSouris.X, NouvellePositionSouris.Y);
            }
            else
            {
                Game.IsMouseVisible = true;
            }
        }

        private void GérerRotationSouris()
        {
            GérerLacetSouris();
            GérerTangageSouris();
        }

        private void GérerLacetSouris()
        {
            Matrix matriceLacet = Matrix.CreateFromAxisAngle(OrientationVerticale, DELTA_LACET * VITESSE_INITIALE_ROTATION_SOURIS * -DéplacementSouris.X);

            Direction = Vector3.Transform(Direction, matriceLacet);
        }

        private void GérerTangageSouris()
        {
            Matrix matriceTangage = Matrix.CreateFromAxisAngle(Latéral, DELTA_TANGAGE * VITESSE_INITIALE_ROTATION_SOURIS * -DéplacementSouris.Y);

            Direction = Vector3.Transform(Direction, matriceTangage);
        }
        #endregion

        //Clavier
        #region
        private void FonctionsClavier()
        {
            if (EstDéplacementEtAutresClavierActivé)
            {
                GérerDéplacement((GérerTouche(Keys.W) - GérerTouche(Keys.S)),
                             (GérerTouche(Keys.A) - GérerTouche(Keys.D)));
            }
            if (EstCaméraClavierActivée)
            {
                GérerRotationClavier();
            }
        }

        protected virtual void GérerDéplacement(float direction, float latéral)
        {
            float déplacementDirection = direction * VitesseTranslation;
            float déplacementLatéral = latéral * VitesseTranslation;

            Direction = Vector3.Normalize(Direction);
            Position += déplacementDirection * Direction;

            Latéral = Vector3.Cross(Direction, OrientationVerticale);
            Position -= déplacementLatéral * Latéral;
        }

        private void GérerRotationClavier()
        {
            GérerLacetClavier();
            GérerTangageClavier();
        }

        private void GérerLacetClavier()
        {
            Matrix matriceLacet = Matrix.Identity;

            if (GestionInput.EstEnfoncée(Keys.Left))
            {
                matriceLacet = Matrix.CreateFromAxisAngle(OrientationVerticale, DELTA_LACET * VITESSE_INITIALE_ROTATION);
            }
            if (GestionInput.EstEnfoncée(Keys.Right))
            {
                matriceLacet = Matrix.CreateFromAxisAngle(OrientationVerticale, -DELTA_LACET * VITESSE_INITIALE_ROTATION);
            }

            Direction = Vector3.Transform(Direction, matriceLacet);
        }

        private void GérerTangageClavier()
        {
            Matrix matriceTangage = Matrix.Identity;

            if (GestionInput.EstEnfoncée(Keys.Down))
            {
                matriceTangage = Matrix.CreateFromAxisAngle(Latéral, -DELTA_TANGAGE * VITESSE_INITIALE_ROTATION);
            }
            if (GestionInput.EstEnfoncée(Keys.Up))
            {
                matriceTangage = Matrix.CreateFromAxisAngle(Latéral, DELTA_TANGAGE * VITESSE_INITIALE_ROTATION);
            }

            Direction = Vector3.Transform(Direction, matriceTangage);
        }
        #endregion

        //GamePad
        #region
        private void FonctionsGamePad()
        {
            if (GestionGamePad.EstGamepadActivé)
            {
                GérerDéplacement(GestionGamePad.PositionThumbStickGauche.Y,
                                 -GestionGamePad.PositionThumbStickGauche.X);

                DéplacementSouris = new Vector2(35, -35) * GestionGamePad.PositionThumbStickDroit;
                GérerRotationSouris();
            }
        }
        #endregion

        private void AffecterCommandes()
        {
            Courrir = (GestionInput.EstEnfoncée(Keys.RightShift) && EstDéplacementEtAutresClavierActivé) ||
                      (GestionInput.EstEnfoncée(Keys.LeftShift) && EstDéplacementEtAutresClavierActivé) ||
                      GestionGamePad.PositionsGâchettes.X > 0;

            Sauter = (GestionInput.EstEnfoncée(Keys.R/*Keys.Space*/) && EstDéplacementEtAutresClavierActivé) ||
                     GestionGamePad.EstEnfoncé(Buttons.A);

            Ramasser = GestionInput.EstNouveauClicGauche() ||
                       GestionInput.EstAncienClicGauche() ||
                       GestionInput.EstEnfoncée(Keys.E) && EstDéplacementEtAutresClavierActivé ||
                       GestionGamePad.EstNouveauBouton(Buttons.RightStick);
        }

        private void GérerHauteur()
        {
            //Position = Gazon.GetPositionAvecHauteur(Position, (int)Hauteur);
            Position = new Vector3(Position.X, Hauteur, Position.Z);
        }

        private int GérerTouche(Keys touche)
        {
            return GestionInput.EstEnfoncée(touche) ? 1 : 0;
        }

        private void GérerRamassage()
        {
            Viseur = new Ray(Position, Direction);

            foreach (SphèreRamassable sphereRamassable in Game.Components.Where(composant => composant is SphèreRamassable))
            {
                Ramasser = sphereRamassable.EstEnCollision(Viseur) <= DISTANCE_MINIMALE_POUR_RAMASSAGE &&
                           sphereRamassable.EstEnCollision(Viseur) != null &&
                           Ramasser;

                //Game.Window.Title = sphereRamassable.EstEnCollision(Viseur).ToString();
                if (Ramasser)
                {
                    sphereRamassable.EstRamassée = true;
                }
            }
        }

        //Saut
        #region
        private void GérerSaut()
        {
            if (Sauter)
            {
                ContinuerSaut = true;
            }

            if (ContinuerSaut)
            {
                if (t > 60)
                {
                    InitialiserObjetsComplexesSaut();
                    ContinuerSaut = false;
                    t = 0;
                }
                Hauteur = CalculerBesier(t * (1f / 60f), PtsDeControle).Y;
                ++t;
            }
        }

        bool ContinuerSaut { get; set; }
        float t { get; set; }
        float Hauteur { get; set; }

        Vector3 PositionPtsDeControle { get; set; }
        Vector3 PositionPtsDeControlePlusUn { get; set; }
        Vector3[] PtsDeControle { get; set; }

        void InitialiserObjetsComplexesSaut()
        {
            Position = new Vector3(Position.X, Height/*HAUTEUR_PERSONNAGE*/, Position.Z);
            PositionPtsDeControle = new Vector3(Position.X, Position.Y, Position.Z);
            PositionPtsDeControlePlusUn = Position + Vector3.Normalize(new Vector3(Direction.X, 0, Direction.Z)) * 25;
            //Position = new Vector3(PositionPtsDeControle.X, PositionPtsDeControle.Y, PositionPtsDeControle.Z);//******
            //Direction = PositionPtsDeControlePlusUn - PositionPtsDeControle;//******
            PtsDeControle = CalculerPointsControle();
        }

        private Vector3[] CalculerPointsControle()
        {
            Vector3[] pts = new Vector3[4];
            pts[0] = PositionPtsDeControle;
            pts[3] = PositionPtsDeControlePlusUn;
            pts[1] = new Vector3(pts[0].X, pts[0].Y + 20, pts[0].Z);
            pts[2] = new Vector3(pts[3].X, pts[3].Y + 20, pts[3].Z);
            return pts;
        }

        private Vector3 CalculerBesier(float t, Vector3[] PtsDeControle)
        {
            float x = (1 - t);
            return PtsDeControle[0] * (x * x * x) +
                   3 * PtsDeControle[1] * t * (x * x) +
                   3 * PtsDeControle[2] * t * t * x +
                   PtsDeControle[3] * t * t * t;

        }
        #endregion

        private void GérerCourse()
        {
            VitesseTranslation = Courrir ? (GestionGamePad.PositionsGâchettes.X > 0 ? GestionGamePad.PositionsGâchettes.X : 1) * FACTEUR_COURSE_MAXIMAL * VITESSE_INITIALE_TRANSLATION : VITESSE_INITIALE_TRANSLATION;
        }
    }
}

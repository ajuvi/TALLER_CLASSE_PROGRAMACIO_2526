using System;
using System.Collections.Generic;
using System.Text;

namespace Grafics
{
    public class Cercle
    {
        #region atributs
        private double radi;
        private Punt2D centre;
        //private double x;
        //private double y;
        #endregion

        #region constructors

        /// <summary>
        /// Crea un punt amb paràmetres
        /// </summary>
        /// <param name="centre">El centre del cercle</param>
        /// <param name="radi">El radi del cercle</param>
        public Cercle(Punt2D centre, double radi)
        {
            this.centre = centre;
            //this.radi = radi;
            Radi = radi;
        }

        /// <summary>
        /// Crea un cercle amb el radi indicat, a la posició (0,0)
        /// </summary>
        /// <param name="radi"></param>
        public Cercle(double radi) : this(new Punt2D(0, 0), radi) { }

        /// <summary>
        /// Crea un cercle de radi 1, a la posició (0,0)
        /// </summary>
        public Cercle() : this(new Punt2D(0, 0), 1)
        {
            //res
        }

        /// <summary>
        /// Crea un cercle a la posició (cx,cy) amb el radi indicat.
        /// </summary>
        /// <param name="cx">Posició x del centre</param>
        /// <param name="cy">Posició y del centre</param>
        /// <param name="radi">EL radi del cercle</param>
        public Cercle(double cx, double cy, double radi)
        {
            Punt2D punt = new Punt2D(cx, cy);
            this.centre = punt;
            Radi = radi;
        }

        /// <summary>
        /// Crea un cercle a la posició (cx,cy) amb radi 1.
        /// </summary>
        /// <param name="cx"></param>
        /// <param name="cy"></param>
        public Cercle(double cx, double cy):this(cx,cy,1)
        {
            
        }

        #endregion

        #region propietats

        /// <summary>
        /// Accedeix a l'atribut radi
        /// </summary>
        public double Radi
        {
            get
            {
                return radi;
            }
            set 
            {
                if (value < 0)
                    throw new Exception("EL RADI NO POT SER MENOR A CERO.");
                radi=value; 
            }
        }

        /// <summary>
        /// Accedeix a l'atribut centre
        /// </summary>
        public Punt2D Centre
        {
            get { return centre; }
            set { centre = value; }
        }

        /// <summary>
        /// Calcula l'àrea del cercle
        /// </summary>
        public double Area
        {
            get { return Math.PI * radi * radi; }
        }


        /// <summary>
        /// Accedeix a la posició X del centre
        /// </summary>
        public double X
        {
            get { return centre.X; }
            set { centre.X = value; }
        }

        /// <summary>
        /// Accedeix a la posició Y del centre
        /// </summary>
        public double Y
        {
            get { return centre.Y; }
            set { centre.Y = value; }
        }

        #endregion

        #region metodes

        public override bool Equals(object? obj)
        {
            bool iguals;
            
            if(obj==null) iguals = false;
            else if(obj is not Cercle) iguals = false;
            else
            {
                Cercle other = (Cercle)obj;
                //iguals = this.radi==other.radi && this.X == other.X && this.Y == other.Y;
                iguals = this.radi == other.radi && this.Centre.Equals(other.Centre);
            }

            return iguals;
        }

        /// <summary>
        /// Converteix un cercle en un string
        /// </summary>
        /// <returns>El cercle en format text</returns>
        public override string ToString()
        {
            return $"RADI: {Radi} CENTRE: {centre}";
        }

        ///// <summary>
        ///// Aquest mètode no pot existir, doncs ja hi ha la propietat Area
        ///// </summary>
        ///// <returns>Retorna l'area del cercle</returns>
        //public double Area()
        //{
        //    return Math.PI * radi * radi;
        //}

        #endregion

    }
}

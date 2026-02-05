using System;
using System.Collections.Generic;
using System.Text;

namespace Grafics
{
    public class Punt2D
    {
        private static char separador = ',';

        #region Atributs
        private double x;
        private double y;
        #endregion

        #region Constructors
        //public Punt2D(double x, double y)
        //{
        //    this.x = x;
        //    this.y = y;
        //}

        //public Punt2D() : this(0, 0) { }

        /// <summary>
        /// Constructor amb valors en els paràmetres.
        /// </summary>
        /// <param name="x">Valor de x</param>
        /// <param name="y">Valor de y</param>
        public Punt2D(double x = 0, double y = 0)
        {
            this.X = x;
            this.Y = y;
        }

        #endregion

        #region Propietats

        /// <summary>
        /// Propietat associada a l'atribut x
        /// </summary>
        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        /// <summary>
        /// Propietat associada a l'atribut y
        /// </summary>
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        /// <summary>
        /// Indica si el punt està a l'origen de coordenades.
        /// </summary>
        public bool EsOrigen
        {
            get { return x == 0 && y == 0; }
        }

        public static char Separador
        {
            get { return Punt2D.separador; }
            set { Punt2D.separador = value; }
        }

        #endregion

        #region Mètodes

        /// <summary>
        /// Mou el punt a la posició indicada pels paràmetres.
        /// </summary>
        /// <param name="x">Posició de l'eix de les x/param>
        /// <param name="y">Posició de l'eix de les y</param>
        public void MoureA(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Suma a les coordenades del punt, els valors passats per paràmetre.
        /// </summary>
        /// <param name="incX">Increment de X</param>
        /// <param name="incY">Increment de Y</param>
        public void Desplaça(double incX, double incY)
        {
            this.x += incX;
            this.y += incY;
        }

        /// <summary>
        /// Converteix un Punt2D a un String.
        /// </summary>
        /// <returns>La informació del punt en format text</returns>
        public override string ToString()
        {
            return $"[{this.x}{Punt2D.Separador}{this.y}]";
        }

        /// <summary>
        /// Avalua si dos punts són iguals
        /// </summary>
        /// <param name="obj">Objecte a comparar</param>
        /// <returns>Retorna cert si els dos punts són iguals, altrament retorna fals.</returns>
        public override bool Equals(object obj)
        {
            bool iguals;

            if (obj == null) iguals = false;
            else if (obj is not Punt2D) iguals = false;
            else
            {
                Punt2D other = (Punt2D)obj;
                iguals = this.X == other.X && this.Y == other.Y;
            }

            return iguals;
        }

        /// <summary>
        /// Calcula la distància que hi ha entre el punt (this) i el pun passat per paràmetre.
        /// </summary>
        /// <param name="p">Punt per a calcular la distància</param>
        /// <returns>La distància entre el punt (this) i el punt passat per paràmetre.</returns>
        public double Distancia(Punt2D p)
        {
            return Punt2D.Distancia(this, p);
        }

        #endregion

        #region Mètodes estàtics

        /// <summary>
        /// Calcula la distància que hi ha entre dos punts.
        /// </summary>
        /// <param name="a">Primer punt</param>
        /// <param name="b">Segon punt</param>
        /// <returns>La distància entre els dos punts.</returns>
        public static double Distancia(Punt2D a, Punt2D b)
        {
            double dx = a.X - b.X;
            double dy = a.Y - b.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        /// <summary>
        /// Crea un nou punt, resultat de sumar les coordenades dels dos punts passats per paràmetre.
        /// </summary>
        /// <param name="a">Primer punt</param>
        /// <param name="b">Segon punt</param>
        /// <returns>Un nou punt suma de les coordenades dels dos punts.</returns>
        /// <exception cref="ArgumentNullException">Els punts no poden ser null.</exception>
        private static Punt2D Suma(Punt2D a, Punt2D b)
        {
            if (a == null || b == null)
                throw new ArgumentNullException("No s'admeten valors null");

            Punt2D nouPunt;
            nouPunt = new Punt2D(a.X + b.X, a.Y + b.Y);
            return nouPunt;
        }

        #endregion

        #region Operadors

        /// <summary>
        /// Operació equivalent a: "Suma(a,b)"
        /// </summary>
        public static Punt2D operator +(Punt2D a, Punt2D b)
        {
            return Punt2D.Suma(a, b);
        }

        /// <summary>
        /// Operació equivalent a: "a + 1"
        /// </summary>
        public static Punt2D operator ++(Punt2D a)
        {
            return a + new Punt2D(1, 1);
        }

        /// <summary>
        /// Sum el valor de increment a la "x" i a la "y".
        /// </summary>
        /// <param name="a">Punt a incrementar</param>
        /// <param name="increment">Valor a incrementar</param>
        /// <returns>Nou punt amb les coordenades incrementades.</returns>
        public static Punt2D operator +(Punt2D a, double increment)
        {
            Punt2D nouPunt;
            nouPunt = new Punt2D(a.X + increment, a.Y + increment);
            return nouPunt;
        }

        /// <summary>
        /// Preració equivalent a: "a + increment"
        /// </summary>
        public static Punt2D operator +(double increment, Punt2D a)
        {
            return a + increment;
        }

        #endregion

        #region conversions

        /// <summary>
        /// Converteix de manera implicita un double a punt.
        /// Punt2D p1 = 2.0;
        /// </summary>
        /// <param name="valor">Valor a convertir</param>
        public static implicit operator Punt2D(double valor)
        {
            return new Punt2D(valor, valor);
        }

        ///// <summary>
        ///// Converteix de manera explicita un double a punt.
        ///// Punt2D p1 = (Punt2D)2.0;
        ///// </summary>
        ///// <param name="valor">Valor a convertir</param>
        //public static explicit operator Punt2D(double valor)
        //{
        //    return new Punt2D(valor, valor);
        //}

        /// <summary>
        /// Converteix de manera explicita un punt a la seva distancia a l'origen de coordenades.
        /// Punt2D p1 = new Punt2D(3,3);
        /// double dist = (double)p1;
        /// </summary>
        /// <param name="p">Punt a convertir</param>
        public static explicit operator double(Punt2D p)
        {
            return Math.Sqrt(p.X * p.X + p.Y * p.Y);
        }

        /// <summary>
        /// Converteix de manera explicita un double[] a un punt.
        /// <code>
        ///     Punt2D p1 = (Punt2D)[1,1];
        /// </code>
        /// </summary>
        /// <param name="p">Punt a convertir</param>
        public static explicit operator Punt2D(double[] taula)
        {
            if (taula.Length != 2)
                throw new Exception("Format no vàlid");

            Punt2D nouPunt = new Punt2D(taula[0], taula[1]);
            return nouPunt;
        }

        /// <summary>
        /// Converteix de manera explicita un text a un punt.
        /// <code>
        ///     Punt2D p1 = (Punt2D)"[1,1]";
        /// </code>
        /// </summary>
        /// <param name="p">Punt a convertir</param>
        public static explicit operator Punt2D(string text)
        {
            string[] parts = text.Trim('[').Trim(']').Split(Punt2D.Separador);
            if (parts.Length != 2)
                throw new Exception("Format no vàlid");

            Punt2D nouPunt = new Punt2D(Convert.ToDouble(parts[0]), Convert.ToDouble(parts[1]));
            return nouPunt;
        }

        #endregion

    }
}

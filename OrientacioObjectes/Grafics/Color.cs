using System;
using System.Collections.Generic;
using System.Text;

namespace Grafics
{
    public class Color
    {

        #region atributs
        private const int NUM_CANALS = 4;
        private int[] canals;
        private bool esTransparent;
        private int profunditatColor = 256;
        #endregion

        #region constructor
        /// <summary>
        /// Assigna els valors dels colors i de la transparència.
        /// Si valors és null, llavors assigna el color negre (tot zeros).
        /// Si el nombre de canals és 3 o 4, s'assignen els valors al color.
        /// S'ha de validar que tots els canals tenen la profunditat correcte.
        /// Utilitzar el mètode privat ValidaValor per a comprovar que tots els
        /// canals tenen un valor entre 0 i la profunditat-1.
        /// El valor de la transparència (primera posició de l'array), s'assigna 
        /// en mode opac, que és el valor màxim del canal (255 en profunditat de 256). 
        /// </summary>
        /// <param name="valors">Taula amb els valoes del color</param>
        /// <param name="teTransparencia">Indica si el color ha de ser transparent o no</param>
        /// <exception cref="Exception">Si els nombre de canals o els valors no són correctes.</exception>
        public Color(int[] valors, bool teTransparencia)
        {
            throw new NotImplementedException();    
        }

        /// <summary>
        /// Constructor que crida al constructor amb paràmetres.
        /// Assigna el valor de la transparència a false.
        /// </summary>
        /// <param name="valors"></param>
        public Color(int[] valors) {
            throw new NotImplementedException();
        }

        /// Constructor que crea un color negre amb opció de transparència.
        /// Assigna transparència al color en funció del paràmetre.
        /// Inicialitza tots els canals a zero (negre). 
        /// <param name="teTransparencia"></param>
        public Color(bool teTransparencia)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Crea un color negre (tots els canals a zero) i sense transparència.
        /// </summary>
        public Color()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Constructor que crea un color a partir de valors de cada canal.
        /// El constructor utilitza valors opcionals i valida que totes les
        /// dades tenen la profunditat correcte., 
        /// S'ha de validar que tots els canals tenen la profunditat correcte.
        /// Utilitzar el mètode privat ValidaValor per a comprovar que tots els
        /// canals tenen un valor entre 0 i la profunditat-1.
        /// El valor de la transparència (primera posició de l'array), s'assigna 
        /// en mode opac, que és el valor màxim del canal (255 en profunditat de 256).
        /// </summary>
        /// <param name="a">Valor del canal transparència (Alpha)</param>
        /// <param name="r">Valor del canal vermell (Red)</param>
        /// <param name="g">Valor del canal verd (Green)</param>
        /// <param name="b">Valor del canal blau (Blue)</param>
        /// <param name="teTransparencia">Indica si el color té activada la transparència</param>
        public Color(int a = 255, int r = 0, int g = 0, int b = 0, bool teTransparencia = false) {
            throw new NotImplementedException();
        }

        #endregion

        #region propietats

        /// <summary>
        /// get => Indica si un color és transparent.
        /// set => Assigna el valor a la transparència. Si el color
        /// no era transparent, assignar al canal alpha el valor opac.
        /// </summary>
        public bool TeTransparencia
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// get => Retorna el valor de la profunditat del color.
        /// set => Assigna el valor de la profunditat.
        /// S'ha de validar que el valor de la profunditat sigui superior a 0, altrament
        /// s'ha de generar una excepció.
        /// Si es modifica la profunditat, els valors dels canals s'han d'ajustar
        /// proporcionalment a la nova profunditat.
        /// </summary>
        public int ProfunditatDeColor
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Si el valor de l'index no és correcte, es genera una excepció.
        /// El valor de l'index ha de ser un valor entre [0,NCANALS]
        /// 
        /// set => s'implementa en visibilitat private
        /// get => Retorna el valor del canal.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Retorna/assignar el valor del canal</returns>
        public int this[int index]
        {
            get {
                //ValidarIndex();
                //return canals[index];
                throw new NotImplementedException();
            }
        }

        #endregion

        #region mètodes de classe (objecte)

        /// <summary>
        /// Genera una excepció si l'index passat per paràmetre no és vàlid.
        /// Si hi ha transparència, els index vàlids seràn [0,NCANALS]
        /// Si hi ha transparència, els index vàlids seràn [1,NCANALS]
        /// </summary>
        /// <param name="index">Valor de l'index a validar</param>
        /// <exception cref="IndexOutOfRangeException">Genera error en cas que l'index no sigui vàlid</exception>
        private void ValidaIndex(int index)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Valida que el valor està en el rang [0,ProfunditatDeColor-1]
        /// </summary>
        /// <param name="valor">Valor d'un canal a validar</param>
        /// <exception cref="NotImplementedException">Si el valor no és correcte</exception>
        private void ValidaValor(int valor)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Obtenir el valor del canal utilitzant la propietat this.
        /// S'ha de validar que l'index sigui correcte utilitzant 
        /// el mètode private ValidaIndex.
        /// </summary>
        /// <param name="index">Número de canal</param>
        /// <returns>Valor del canal</returns>
        public int ObtenirCanal(int index)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Inverteix els colors (Negatiu fotogràfic).
        /// El canal alpha (transparències) no s'inverteix.
        /// El valor dels altres canals s'inverteixen en funció de la 
        /// profunditat màxima (ProfunditatDeColor). 
        /// Per exemple, si el canal té el valor de 0, llavors el valor
        /// del canal ha de passar a 255, per una profunditat maxima de 256.
        /// </summary>
        public void Inverteix()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Crea un nou color a escala de grisos, basat en el color.
        /// El nou color obtindrà el valor mig enter dels canals principals, sense
        /// tenir en compte el valor alpha.
        /// El nou color ha de mantenir el mateix valor de transparència i el
        /// mateix estat de transparència.
        /// </summary>
        /// <returns>Un nou color a escala de grisos</returns>
        public Color A_EscalaDeGrisos()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Transforma el punt en un text.
        /// * Si el color no té transparència, retornaria: rgb(0, 0, 100)
        /// * Si el color té transparència, retornaria: argb(255, 0, 0, 100)
        /// </summary>
        /// <returns>El color tranformat a text</returns>
        public override string ToString()
        {
            return base.ToString();
        }

        /// <summary>
        /// Compara si el color és igual a un altre color.
        /// </summary>
        /// <param name="obj">Un altre objecte</param>
        /// <returns>Retorna cert si els dos colors són iguals, 
        /// altrament retorna fals.</returns>
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        #endregion

    }
}

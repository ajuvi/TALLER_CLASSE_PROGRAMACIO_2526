using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DemoCadenaDeCaracters
{
    public class CadenaDeCaracters
    {
        //const char caraterMotDePas = '*';

        #region atributs
        private char[] lletres;
        private bool esMotDePas;
        private static char caraterMotDePas = '*';
        #endregion

        #region propietats
        public bool EsMotDePas
        {
            get { return this.esMotDePas; }
            set { this.esMotDePas = value; }
        }

        public int Mida
        {
            get
            {
                return lletres.Length;
            }
        }

        public static char CaraterMotDePas
        {
            get
            {
                //return CadenaCaracters.caraterMotDePas;
                return caraterMotDePas;
            }
        }

        public char this[int index]
        {
            get
            {
                ValidarIndex(index);
                return lletres[index];
            }
            private set
            {
                ValidarIndex(index);
                lletres[index] = value;
            }
        }
        #endregion

        #region constructors

        public CadenaDeCaracters(char[] caracters, bool esMotDePas)
        {
            //if (caracters == null)
            if (caracters is null)
                throw new Exception("La cadena no pot ser null.");

            this.lletres = new char[caracters.Length];
            for (int pos = 0; pos < caracters.Length; pos++)
                lletres[pos] = caracters[pos];

            //this.esMotDePas =esMotDePas;
            //this.EsMotDePas = esMotDePas;
            EsMotDePas = esMotDePas;
        }

        public CadenaDeCaracters(char[] caracters) : this(caracters, false) { }

        public CadenaDeCaracters() : this(new char[0], false) { }

        public CadenaDeCaracters(string caracters = "", bool esMotDePas = false)
        {
            lletres = new char[caracters.Length];
            for (int pos = 0; pos < caracters.Length; pos++)
                lletres[pos] = caracters[pos];

            EsMotDePas = esMotDePas;
        }

        #endregion

        #region metodes
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            //OPCIO 2
            for (int i = 0; i < lletres.Length; i++)
            {
                if (esMotDePas)
                    sb.Append(caraterMotDePas);
                else
                    sb.Append(lletres[i]);
            }

            ////OPCIO 3
            //for(int i=0;i<lletres.Length; i++)
            //    sb.Append(esMotDePas?caraterMotDePas:lletres[i]);

            ////OPCIO 1
            //if (esMotDePas)
            //{
            //    for (int i = 0; i < lletres.Length; i++)
            //        sb.Append(caraterMotDePas);
            //}
            //else
            //{
            //    for (int i = 0; i < lletres.Length; i++)
            //        sb.Append(lletres[i]);
            //}

            return sb.ToString();

        }

        public override bool Equals(object? obj)
        {
            //return base.Equals(obj);

            ////comparar referències
            //return ReferenceEquals(this, obj);

            bool iguals;
            if (obj is null)
                iguals = false;
            else if (obj is not CadenaDeCaracters)
                iguals = false;
            else
            {
                CadenaDeCaracters other = (CadenaDeCaracters)obj;
                //if(this.Mida != other.Mida) 
                if (this.lletres.Length != other.lletres.Length)
                    iguals = false;
                else
                {
                    int index = 0;
                    iguals = true;
                    while (iguals && index < this.Mida)
                    {
                        //iguals = this.lletres[index] == other.lletres[index];
                        iguals = this[index] == other[index];
                        index++;
                    }

                }
            }

            return iguals;
        }

        private void ValidarIndex(int index)
        {
            if (index < 0 || index >= lletres.Length)
                throw new Exception("La posició de l'index no és correcte");
        }

        #endregion

        #region operadors

        public static CadenaDeCaracters operator +(CadenaDeCaracters c1, CadenaDeCaracters c2)
        {
            //char[] nou = new char[c1.Mida+c2.Mida];
            char[] nou = new char[c1.lletres.Length + c2.lletres.Length];

            //int index = 0;
            //for (int pos1 = 0; pos1 < c1.Mida; pos1++)
            //{
            //    nou[index] = c1.lletres[index];
            //    index++;
            //}

            //for (int pos2 = 0; pos2 < c2.Mida; pos2++)
            //{
            //    nou[index] = c2.lletres[index];
            //    index++;
            //}


            for (int pos1 = 0; pos1 < c1.Mida; pos1++)
                nou[pos1] = c1.lletres[pos1];

            for (int pos2 = 0; pos2 < c2.Mida; pos2++)
                nou[pos2 + c1.Mida] = c2.lletres[pos2];

            return new CadenaDeCaracters(nou);

        }

        public static CadenaDeCaracters operator +(CadenaDeCaracters c1, char car)
        {
            char[] nou = new char[c1.Mida + 1];

            for (int pos1 = 0; pos1 < c1.Mida; pos1++)
                nou[pos1] = c1.lletres[pos1];

            nou[nou.Length - 1] = car;

            return new CadenaDeCaracters(nou);
        }

        public static CadenaDeCaracters operator +(char car, CadenaDeCaracters c1)
        {
            char[] nou = new char[c1.Mida + 1];

            nou[0] = car;

            //for (int pos1 = 0; pos1 < c1.Mida; pos1++)
            //    nou[pos1+1] = c1.lletres[pos1];

            for (int pos1 = 1; pos1 <= c1.Mida; pos1++)
                nou[pos1] = c1.lletres[pos1 - 1];

            return new CadenaDeCaracters(nou);
        }

        #endregion

        #region conversors

        public static implicit operator CadenaDeCaracters(string text)
        {
            return new CadenaDeCaracters(text);
        }

        public static implicit operator CadenaDeCaracters(int s)
        {
            return new CadenaDeCaracters(s.ToString());
        }

        public static explicit operator int(CadenaDeCaracters c)
        {
            return c.Mida;
        }

        public static explicit operator char(CadenaDeCaracters cad)
        {
            if (cad.Mida == 0)
                throw new Exception("La cadena no pot ser buida");

            return cad.lletres[0];
            //return cad[0];
        }

        #endregion

    }
}

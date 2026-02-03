using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DemoCadenaDeCaracters
{
    public class CadenaCaracters
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
            get { 
                return lletres.Length; 
            }
        }

        public static char CaraterMotDePas
        {
            get {
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

        public CadenaCaracters(char[] caracters, bool esMotDePas)
        {
            //if (caracters == null)
            if (caracters is null)
                throw new Exception("La cadena no pot ser null.");

            this.lletres = new char[caracters.Length];
            for(int pos=0;pos<caracters.Length;pos++)
                lletres[pos] = caracters[pos];  

            //this.esMotDePas =esMotDePas;
            //this.EsMotDePas = esMotDePas;
            EsMotDePas = esMotDePas;
        }

        public CadenaCaracters(char[] caracters) : this(caracters,false) { }

        public CadenaCaracters() : this(new char[0], false) { }

        public CadenaCaracters(string caracters = "", bool esMotDePas = false)
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
            if(obj is null)
                iguals = false;
            else if(obj is not CadenaCaracters)
                iguals = false;
            else
            {
                CadenaCaracters other = (CadenaCaracters)obj;
                //if(this.Mida != other.Mida) 
                if (this.lletres.Length!=other.lletres.Length) 
                    iguals = false;
                else
                {
                    int index = 0;
                    iguals = true;
                    while(iguals && index < this.Mida)
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


    }
}

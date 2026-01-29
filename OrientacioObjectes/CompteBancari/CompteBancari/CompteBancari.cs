using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCompteBancari
{
    public class CompteBancari
    {
        #region CAMPS
        private string iban;
        private string titular;
        private double saldo;
        private bool bloquejat;
        private static double tipusInteresAnual = 0.03;
        #endregion

        #region CONSTRUCTORS
        public CompteBancari(string iban, string titular, double saldoInicial, bool bloquejat)
        {
            this.iban = iban;
            this.titular = titular;
            saldo = saldoInicial;
            this.bloquejat = bloquejat;
        }

        public CompteBancari(string iban, string titular, double saldoInicial)
            : this(iban, titular, saldoInicial, false) { }

        public CompteBancari(string iban, string titular)
            : this(iban, titular, 0, false) { }

        #endregion

        #region PROPIETATS
        public static double TipusInteresAnual
        {
            get { return CompteBancari.tipusInteresAnual; }
            //get { return tipusInteresAnual; }
        }

        public string Iban
        {
            get { return iban; }
        }

        public string Titular
        {
            get { return titular; }
            private set { titular = value; }
        }

        public double Saldo
        {
            get { return this.saldo; }
        }
        #endregion

        #region MÈTODES D'INSTÀNCIA (D'OBJECTE)

        public override bool Equals(object? obj)
        {
            bool iguals;
            if (obj == null)
                iguals = false;
            else if (obj is not CompteBancari)
                iguals = false;
            else
            {
                CompteBancari other = (CompteBancari)obj;
                iguals = this.iban == other.iban && this.titular == other.titular;  
            }

            return iguals;
        }

        public override string ToString()
        {
            string str = $"IBAN:{iban} TITULAR:{titular} SALDO:{Saldo}";

            if (bloquejat) str += " (BLOQUEJAT)";
            else str += " (ACTIU)";

            return str;    
        }

        public void Ingressar(double quantitat)
        {
            if (bloquejat)
                throw new Exception("Compte bloquejat");
            if (quantitat < 0)
                throw new Exception("La quantitat no pot ser negativa");

            saldo += quantitat;
        }

        public bool Retirar(double quantitat)
        {
            if (bloquejat)
                throw new Exception("Compte bloquejat");
            if (!this.TeSaldoSuficient(quantitat))
                throw new Exception("Operació no permesa: Insuficient saldo.");

            saldo -= quantitat;
            return true;
        }

        private bool TeSaldoSuficient(double quantitat)
        {
            return saldo >= quantitat;
        }

        #endregion

        #region MÈTODES ESTATICS (DE CLASSE)
        public static void Transaccio(
            CompteBancari origen, 
            CompteBancari desti, 
            double quantitat)
        {

            if (origen.bloquejat)
                throw new Exception("Compte origen bloquejat");

            if (!origen.TeSaldoSuficient(quantitat))
                throw new Exception("Operació no permesa: Insuficient saldo.");

            if (desti.bloquejat)
                throw new Exception("Compte destí bloquejat");

            origen.saldo -= quantitat;
            desti.saldo += quantitat;
        }
        #endregion
    }
}



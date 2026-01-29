using System;
using System.Collections.Generic;
using System.Text;

namespace DemoErrorsOO
{
    internal class CompteBancari
    {
        // CAMPS
        public string titular;
        private double saldo;
        private bool bloquejat;
        private static double tipusInteresAnual = 0.03;

        // CONSTRUCTORS
        public CompteBancari(string titular, double saldoInicial)
        {
            this.titular = titular;
            saldo = saldoInicial;
            bloquejat = false;
        }

        // PROPIETATS
        public static double TipusInteresAnual
        {
            get { return tipusInteresAnual; }
        }

        public static void Titular
        {
            get { return titular; }
            private set { titular = value; }
        }

        public static double Saldo
        {
            private get { return Saldo; }
        }

        // MÈTODES D'INSTÀNCIA
        public void Ingressar(double quantitat)
        {
            saldo += quantitat;
        }

        public bool Retirar(double quantitat)
        {
            if (CompteBancari.TeSaldoSuficient(quantitat))
                throw new Exception("Operació no permesa: Insuficient saldo.");

            saldo -= quantitat;
            return true;
        }

        private bool TeSaldoSuficient(double quantitat)
        {
            return saldo >= quantitat;
        }

        // MÈTODES ESTATICS
        private static bool Transaccio(CompteBancari origen, CompteBancari desti, double quantitat)
        {
            if (CompteBancari.TeSaldoSuficient(quantitat))
                throw new Exception("Operació no permesa: Insuficient saldo.");

            origen.saldo -= quantitat;
            desti.saldo += quantitat;
            return true;
        }
    }
}

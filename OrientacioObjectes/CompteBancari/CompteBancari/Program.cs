namespace DemoCompteBancari
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            /*
             * Demo inicial
             */
            CompteBancari c1 = new CompteBancari("C100-83492483", "Anna", 1000);
            CompteBancari c2 = new CompteBancari("C101-83492909","Marc", 500);

            // Mostrar els comptes bancaria amb el mètode ToString
            Console.WriteLine("COMPTES CREATS\n---");
            Console.WriteLine(c1);
            Console.WriteLine(c2);

            // Ingressar diner al primer compte (c1)
            c1.Ingressar(200);

            // Retirar diners al segon compte (c2)
            c2.Retirar(100);

            // Mostrar el saldo de cada compte
            Console.WriteLine("\nSALDO DE CADA COMPTE DESPÉS DE MODIFICACIONS\n---");
            Console.WriteLine("SALDO PRIMER COMPTE: " + c1.Saldo);
            Console.WriteLine("SALDO SEGON COMPTE: " + c2.Saldo);

            // Tranferir 150$ del primer compte al segon.
            CompteBancari.Transaccio(c1, c2, 150);

            Console.WriteLine("\nSALDO DE CADA COMPTE DESPÉS DE TRANSFERÈNCIA\n---");
            Console.WriteLine("SALDO PRIMER COMPTE (DESPRÉS TRASPÀS): " + c1.Saldo);
            Console.WriteLine("SALDO SEGON COMPTE (DESPRÉS TRASPÀS): " + c2.Saldo);

            // Realitzar diverses transaccions
            CompteBancari.Transaccio(c1, c2, 50);
            CompteBancari.Transaccio(c2, c1, 50);
            CompteBancari.Transaccio(c1, c2, 100);

            //Mostrar els comptes despés de les transaccions
            Console.WriteLine("\nSALDO DE CADA COMPTE DESPRÉS DE DIVERSES TRANSACCIONS\n---");
            Console.WriteLine("COMPTES DESPRÉS ");
            Console.WriteLine(c1);
            Console.WriteLine(c2);

            Console.WriteLine("\nCONSULTA DEL TIPUS D'INTERÈS ANUAL\n---");
            Console.WriteLine("Tipus interès anual: " + CompteBancari.TipusInteresAnual);

            //c3.Ingressar(50); //no existeix l'objecte c3



            CompteBancari cb1 = new CompteBancari("C100-83492483", "Anna", 1000);
            CompteBancari cb2 = new CompteBancari("C100-83492483", "Anna", 100);
            CompteBancari cb3 = cb1;


            /*
             * Mètode Equals
             */

            // COMPARACIONS AMB ==

            Console.WriteLine("\nCOMPARACIONS AMB ==\n---");

            if (cb1 == cb1) Console.WriteLine("cb1 == cb1 és CERT");
            else Console.WriteLine("cb1 == cb1 és FALS");

            if (cb1 == cb2) Console.WriteLine("cb1 == cb2 és CERT");
            else Console.WriteLine("cb1 == cb2 és FALS");

            if (cb1 == cb3) Console.WriteLine("cb1 == cb3 és CERT");
            else Console.WriteLine("cb1 == cb3 és FALS");

            // COMPARACIONS AMB Equals

            Console.WriteLine("\nCOMPARACIONS AMB Equals\n---");

            if (cb1.Equals(cb1)) Console.WriteLine("cb1.Equals(cb1) és CERT");
            else Console.WriteLine("cb1.Equals(cb1) és FALS");

            if (cb1.Equals(cb2)) Console.WriteLine("cb1.Equals(cb2) és CERT");
            else Console.WriteLine("cb1.Equals(cb2) és FALS");

            if (cb1.Equals(cb3)) Console.WriteLine("cb1.Equals(cb3) és CERT");
            else Console.WriteLine("cb1.Equals(cb3) és FALS");

        }
    }
}

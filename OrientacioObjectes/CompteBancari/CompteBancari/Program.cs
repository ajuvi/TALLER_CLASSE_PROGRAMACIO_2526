namespace DemoCompteBancari
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * Demo inicial
             */
            CompteBancari cb1 = new CompteBancari("C100-83492483", "Anna", 1000);
            CompteBancari cb2 = new CompteBancari("C100-83492483", "Anna", 100);
            CompteBancari cb3 = cb1;


            //COMPARACIONS AMB ==
            if (cb1 == cb1)
                Console.WriteLine("cb1 és == a cb1");
            else
                Console.WriteLine("cb1 és != a cb1");

            if (cb1 == cb2)
                Console.WriteLine("cb1 és == a cb2");
            else
                Console.WriteLine("cb1 és != a cb2");

            if (cb1 == cb3)
                Console.WriteLine("cb1 és == a cb3");
            else
                Console.WriteLine("cb1 és != a cb3");

            //COMPARACIONS AMB Equals
            if (cb1.Equals(cb1))
                Console.WriteLine("cb1 és Equals a cb1");
            else
                Console.WriteLine("cb1 no és Equals a cb1");

            if (cb1.Equals(cb2))
                Console.WriteLine("cb1 és Equals a cb2");
            else
                Console.WriteLine("cb1 no és Equals a cb2");

            if (cb1.Equals(cb3))
                Console.WriteLine("cb1 és Equals a cb3");
            else
                Console.WriteLine("cb1 no és Equals a cb3");


            /*
             * Demo inicial
             */
            CompteBancari c1 = new CompteBancari("C100-83492483", "Anna", 1000);
            CompteBancari c2 = new CompteBancari("C101-83492909","Marc", 500);

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            c1.Ingressar(200);
            c2.Retirar(100);
            Console.WriteLine(c1.Saldo);
            Console.WriteLine(c2.Saldo);

            CompteBancari.Transaccio(c1, c2, 150);

            Console.WriteLine(c1.Saldo);
            Console.WriteLine(c2.Saldo);

            CompteBancari.Transaccio(c1, c2, 50);
            CompteBancari.Transaccio(c2, c1, 50);
            CompteBancari.Transaccio(c1, c2, 100);
            Console.WriteLine("Tipus interès anual: " + CompteBancari.TipusInteresAnual);
            //c3.Ingressar(50); //no existeix l'objecte c3

            Console.WriteLine(c1);
            Console.WriteLine(c2);
        }
    }
}

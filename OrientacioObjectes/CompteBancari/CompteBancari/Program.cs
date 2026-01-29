namespace CompteBancari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompteBancari c1 = new CompteBancari("Anna", 1000);
            CompteBancari c2 = new CompteBancari("Marc", 500);

            c1.Ingressar(200);
            c2.Retirar(100);
            Console.WriteLine(c1.Saldo());
            Console.WriteLine(c2.Saldo());

            c1.Transaccio(c1, c2, 150);

            Console.WriteLine(c1.GetSaldo());
            Console.WriteLine(c2.GetSaldo());

            Console.WriteLine(c1.saldo);
            c2.Transaccio(c1, c2, 50);
            CompteBancari.Transaccio(1000, c2, 50);
            CompteBancari.Transaccio(c1, c2, "100");
            Console.WriteLine(CompteBancari.origen);
            c3.Ingressar(50);
        }
    }
}

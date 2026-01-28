namespace DemoEmpleats
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //CREAR UN EMPLEAT
            Employee e1 = new Employee(100, "Steven", "King", 24000, 0.05, new DateTime(1987, 06, 17));

            //MOSTRAR PER PANTALLA L'EMPLEAT
            Console.WriteLine(e1.ToString());
            Console.WriteLine(e1);

            //MOSTRAR EL SALARI TOTAL
            Console.WriteLine($"Salari total: {e1.SalariTotal}$");
        }
    }
}

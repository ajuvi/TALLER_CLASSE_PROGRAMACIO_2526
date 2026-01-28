namespace DemoCadenaDeCaracters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CREAR UNA CADENA DE CARACTERS
            Console.WriteLine("CREAR UNA CADENA DE CARÀCTERS\n---");
            CadenaCaracters frase = new CadenaCaracters("Bon dia");
            Console.WriteLine($"FRASE: {frase}");

            // UTILITZAR L'INDEXADOR DE LA CLASSE CADENA DE CARÀCTERS
            char primerCaracter = frase[0];
            Console.WriteLine($"PRIMER CARÀCTER: {primerCaracter}");

            // CREAR UNA CADENA MOT DE PAS
            Console.WriteLine("CREAR UNA CADENA MOT DE PAS\n---");
            CadenaCaracters password = new CadenaCaracters("12345", true);
            Console.WriteLine($"PASSWORD: {password}");
        }
    }
}

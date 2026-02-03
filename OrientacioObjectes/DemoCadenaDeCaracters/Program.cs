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
            Console.WriteLine("UTILITZAR L'INDEXADOR\n---");
            char primerCaracter = frase[0];
            char ultimCaracter = frase[frase.Mida-1];
            Console.WriteLine($"PRIMER CARÀCTER: {primerCaracter}");
            Console.WriteLine($"ULTIM CARÀCTER: {ultimCaracter}");

            // CREAR UNA CADENA MOT DE PAS
            Console.WriteLine("CREAR UNA CADENA MOT DE PAS\n---");
            CadenaCaracters password = new CadenaCaracters("12345", true);
            Console.WriteLine($"PASSWORD: {password}");

            // COMPARAR CADENES
            Console.WriteLine("COMPARAR CADENES\n---");
            CadenaCaracters c1 = new CadenaCaracters("Hola Girona");
            CadenaCaracters c2 = new CadenaCaracters("12345", true);
            CadenaCaracters c3 = new CadenaCaracters("12345");
            CadenaCaracters c4 = c1;

            Console.WriteLine($"c1==c2: {c1 == c2}");
            Console.WriteLine($"c1==c2: {c1 == c3}");
            Console.WriteLine($"c1==c2: {c1 == c4}");
            Console.WriteLine($"c1==c2: {c2 == c3}");

            Console.WriteLine($"c1.Equals(c2): {c1.Equals(c2)}");
            Console.WriteLine($"c1.Equals(c3): {c1.Equals(c3)}");
            Console.WriteLine($"c1.Equals(c4): {c1.Equals(c4)}");
            Console.WriteLine($"c2.Equals(c3): {c2.Equals(c3)}");
        }
    }
}

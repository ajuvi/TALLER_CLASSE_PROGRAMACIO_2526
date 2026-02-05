namespace DemoCadenaDeCaracters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CREAR UNA CADENA DE CARACTERS
            Console.WriteLine("CREAR UNA CADENA DE CARÀCTERS\n---");
            CadenaDeCaracters frase = new CadenaDeCaracters("Bon dia");
            Console.WriteLine($"FRASE: {frase}");

            // UTILITZAR L'INDEXADOR DE LA CLASSE CADENA DE CARÀCTERS
            Console.WriteLine("UTILITZAR L'INDEXADOR\n---");
            char primerCaracter = frase[0];
            char ultimCaracter = frase[frase.Mida-1];
            Console.WriteLine($"PRIMER CARÀCTER: {primerCaracter}");
            Console.WriteLine($"ULTIM CARÀCTER: {ultimCaracter}");

            // CREAR UNA CADENA MOT DE PAS
            Console.WriteLine("CREAR UNA CADENA MOT DE PAS\n---");
            CadenaDeCaracters password = new CadenaDeCaracters("12345", true);
            Console.WriteLine($"PASSWORD: {password}");

            // COMPARAR CADENES
            Console.WriteLine("COMPARAR CADENES\n---");
            CadenaDeCaracters c1 = new CadenaDeCaracters("Hola Girona");
            CadenaDeCaracters c2 = new CadenaDeCaracters("12345", true);
            CadenaDeCaracters c3 = new CadenaDeCaracters("12345");
            CadenaDeCaracters c4 = c1;

            Console.WriteLine($"c1==c2: {c1 == c2}");
            Console.WriteLine($"c1==c2: {c1 == c3}");
            Console.WriteLine($"c1==c2: {c1 == c4}");
            Console.WriteLine($"c1==c2: {c2 == c3}");

            Console.WriteLine($"c1.Equals(c2): {c1.Equals(c2)}");
            Console.WriteLine($"c1.Equals(c3): {c1.Equals(c3)}");
            Console.WriteLine($"c1.Equals(c4): {c1.Equals(c4)}");
            Console.WriteLine($"c2.Equals(c3): {c2.Equals(c3)}");


            // OPERADOR DE SUMA CadenaCaracters + CadenaCaracters
            Console.WriteLine("OPERADOR SUMA CadenaCaracters + CadenaCaracters\n---");
            CadenaDeCaracters a = new CadenaDeCaracters("Hola ");
            CadenaDeCaracters b = new CadenaDeCaracters("Girona");
            CadenaDeCaracters d = a + b;
            Console.WriteLine($"\"{a}\" + \"{b}\" = \"{d}\"");

            // OPERADOR DE SUMA CadenaCaracters + caracter
            Console.WriteLine("OPERADOR SUMA CadenaCaracters + caracter\n---");
            CadenaDeCaracters cad1 = new CadenaDeCaracters("abcde");
            CadenaDeCaracters cad2 = cad1 + 'f';
            Console.WriteLine("cad1: " + cad1);
            Console.WriteLine("cad2: " + cad2);

            // OPERADOR DE SUMA caracter + CadenaCaracters
            Console.WriteLine("OPERADOR SUMA caracter + CadenaCaracters \n---");
            CadenaDeCaracters cad3 = new CadenaDeCaracters("abcde");
            CadenaDeCaracters cad4 = 'f' + cad3;
            Console.WriteLine("cad3: " + cad3);
            Console.WriteLine("cad4: " + cad4);

            // CONVERSIÓ IMPLICITA de string a CadenaDeCaracter
            Console.WriteLine("CONVERSIÓ IMPLICITA de string a CadenaCaracter \n---");
            CadenaDeCaracters cad5 = "Hola Girona";
            Console.WriteLine("cad5: " + cad5);


        }
    }
}

namespace Grafics
{
    public class Program
    {
        const int N = 20;

        static void Main(string[] args)
        {
            /*
             * Demo Cercle
             */

            // CONSTRUCTOR AMB TOTS ELS PARÀMETRES
            Console.WriteLine("CONSTRUCTOR AMB TOTS ELS PARÀMETRES\n---");
            Cercle c1 = new Cercle(new Punt2D(0, 0), 20);
            Console.WriteLine($"RADI: {c1.Radi}");
            c1.Radi = 10;
            Console.WriteLine($"RADI: {c1.Radi}");
            //c1.Radi = -5; // donarà error doncs no s'accepten valors de radi negatius.
            //Console.WriteLine($"RADI: {c1.Radi}");

            Console.WriteLine();

            // CONSTRUCTOR AMB RADI
            Console.WriteLine("CONSTRUCTOR AMB RADI\n---");
            Cercle c2 = new Cercle(10);
            Console.WriteLine($"RADI: {c2.Radi}");
            Console.WriteLine($"CENTRE: {c2.Centre}");
            Console.WriteLine($"AREA CERCLE: { c2.Area}");

            Console.WriteLine();

            // CONSTRUCTOR SENSE PARAMETRES
            Console.WriteLine("CONSTRUCTOR SENSE PARAMETRES\n---");
            Cercle c3 = new Cercle();
            Console.WriteLine($"RADI: {c3.Radi}");
            Console.WriteLine($"CENTRE: {c3.Centre}");
            Console.WriteLine($"AREA CERCLE: {c3.Area}");

            Console.WriteLine();

            // CONSTRUCTOR AMB X, Y i RADI
            Console.WriteLine("CONSTRUCTOR AMB X, Y i RADI\n---");
            Cercle c4 = new Cercle(2, 2, 100);
            Console.WriteLine($"RADI: {c4.Radi}");
            Console.WriteLine($"CENTRE: {c4.Centre}");
            Console.WriteLine($"AREA CERCLE: {c4.Area}");

            Console.WriteLine();

            // CONSTRUCTOR AMB X i Y
            Console.WriteLine("CONSTRUCTOR AMB X i Y\n---");
            Cercle c5 = new Cercle(4, 4);
            Console.WriteLine($"RADI: {c5.Radi}");
            Console.WriteLine($"CENTRE: {c5.Centre}");
            Console.WriteLine($"AREA CERCLE: {c5.Area}");

            Console.WriteLine();

            // PROPIETATS X i Y del Cercle
            Console.WriteLine("PROPIETATS X i Y del Cercle\n---");
            Cercle c6 = new Cercle();
            c6.X = 9;
            //c1.Centre.X = 9; //equivalent
            c6.Y = 11;
            //c6.Centre.Y = 11; //equivalent
            Console.WriteLine($"CENTRE: {c6.Centre}");

            Console.WriteLine();

            // MÈTODE ToString del Cercle
            Console.WriteLine("MÈTODE ToString()\n---");
            Cercle c7 = new Cercle(2,2,10);
            Console.WriteLine(c7);
            Console.WriteLine(c7.ToString()); //equivalents

            /*
             * Demo punts
             */

            //Generar una llista de N numeros de -100 a 100
            List<int> nums = GenerarLlistaEnters(N);

            Console.WriteLine();

            //Generar una llisa de N punts [x,y] on les coordenades
            // poden tenir valors de -100 a 100.
            List<Punt2D> punts = GenerarLlistaDePunts(N);
        }

        /// <summary>
        /// Genera una llista d'enters de [-100,100] i de la longitud indicada 
        /// en el paràmetre n.
        /// </summary>
        /// <param name="n">La longitud de la llista a generar</param>
        /// <returns>Retorna una llista d'enters de longitud n</returns>
        public static List<int> GenerarLlistaEnters(int n)
        {
            Random rand = new Random();
            List<int> nums = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int num = rand.Next(-100, 101);
                nums.Add(num);

                //mostrar informació dels números afegits
                Console.WriteLine($"AFEGIT EL NÚMERO {num}");
            }

            return nums;
        }

        /// <summary>
        /// Genera una llista de punts amb valors de "x" i de "y" dins 
        /// l'interval [-100,100].
        /// La llista de punts té la longitud indicada en el paràmetre n.
        /// </summary>
        /// <param name="n">La longitud de la llista a generar</param>
        /// <returns>Retorna una llista de punts de longitud n</returns>
        public static List<Punt2D> GenerarLlistaDePunts(int n)
        {
            Random rand = new Random();
            List<Punt2D> nums = new List<Punt2D>();

            for (int i = 0; i < n; i++)
            {
                int x = rand.Next(-100, 101);
                int y = rand.Next(-100, 101);
                Punt2D p = new Punt2D(x, y);
                nums.Add(p);

                //mostrar informació dels punts afegits
                Console.WriteLine($"AFEGIT EL PUNT {p}");
            }

            return nums;
        }

    }
}

using System;

namespace Zvierata
{
    class Program
    {
        static void Main(string[] args)
        {
            Zviera velkeZviera = new Zviera("zviera", "biela", 50, 120.4f, true, 2);
            velkeZviera.VypisVlastnosti();
            velkeZviera.VydajZvuk();

            Macka maciatko = new Macka("Siamska macka", "siva", 1, 5.3f, false, 4, "mlieko");
            maciatko.VypisVlastnosti();
            maciatko.VydajZvuk();

            Pes pitbul = new Pes("Pitbul", "hneda", 6, 60.5f, true, 4, true);
            pitbul.VypisVlastnosti();
            pitbul.VydajZvuk();

            Console.ReadKey();

        }
    }
}

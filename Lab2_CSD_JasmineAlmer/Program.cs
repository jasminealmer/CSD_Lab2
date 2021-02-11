using System;

namespace Lab2_CSD_JasmineAlmer
{
    class Program
    {
        static void Main(string[] args)
        {
            Parse parse = new Parse();
            PaperSystem startSystem = new PaperSystem();

            Console.WriteLine(startSystem.PointScore(parse.CreateCoordinates(args[0]), parse.CreateShapes(args[1])));

        }
    }
}

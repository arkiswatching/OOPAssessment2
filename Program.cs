using System;
using System.IO;

namespace OOPAssessment2
{
    class Program
    {
        static void Main()
        {
            //First file input
            Console.Write("Please input the first file you would wish to compare: ");
            string selectionA = Console.ReadLine();
            string fileA = File.ReadAllText(selectionA);
            //Second file input
            Console.Write("Please input the second file you would wish to compare: ");
            string selectionB = Console.ReadLine();
            string fileB = File.ReadAllText(selectionB);
            //File Comparison
            //files are not the same
            if (fileB != fileA)
            {
                Console.WriteLine("The files are not the same.");
            }
            //Files are the same
            else if (fileB == fileA)
            {
                Console.WriteLine("The files are the same.");
            }
            //restart the process
            Main();
        }
    }
}

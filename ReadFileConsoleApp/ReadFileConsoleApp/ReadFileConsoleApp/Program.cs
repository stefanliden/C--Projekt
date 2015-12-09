using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReadFileConsoleApp.localhost1;


namespace ReadFileConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;

            Console.WriteLine("*********************************************");
            Console.WriteLine("Choose a file to read from below:");

            System.IO.DirectoryInfo dirI = new System.IO.DirectoryInfo(@"C:\test");
            foreach (var fi in dirI.GetFiles())
            {
                Console.WriteLine(fi.Name);
            }
            Console.WriteLine("*********************************************");

            answer = Console.ReadLine();

            Console.WriteLine("*********************************************");

            WebService ws = new WebService();
            string[] lines = ws.filePath(answer);

            Console.WriteLine("Contents of " + answer + ":");

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}

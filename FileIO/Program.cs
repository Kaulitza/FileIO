using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //string dataPath = "Data\\Data.txt";
            string dataPath = @"Data\Data.txt";

            string newLine = "\n";

            string students;

            string student1 = "Bonzo";
            string student2 = "Lucy";

            File.WriteAllText(dataPath, student1 + newLine);
            File.AppendAllText(dataPath, student2);

            students = File.ReadAllText(dataPath);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilecSharp
{
    class Program
    {
        static void Main(string[] args)
        {
           ///DirectoryInfo dir = new DirectoryInfo("C:\\SampleDirectory");
           //dir.Create();
           //FileInfo file = new FileInfo("C:\\SampleDirectory\\sample.txt");
           //file.Create();

            //Console.WriteLine("Adhu Panni Mudichachu");

            FileStream fs = new FileStream("C:\\SampleDirectory\\sample.txt", FileMode. OpenOrCreate, FileAccess. Write);

            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("this text has been written to the file by using I/O Manipulation");

            sw.Close();
            fs.Close();

            Console.WriteLine("Jinchu Jinchak chak chak");

            fs = new FileStream("C:\\SampleDirectory\\sample.txt", FileMode. OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            //var content = sr.ReadToEnd();
            //Console.WriteLine("the File content:{0},content);

            string lineByLine;

            while((lineByLine=sr.ReadLine())!=null)
            {
                Console.WriteLine("\nthe file content:{0}",lineByLine);
            }

            sr.Close();
            fs.Close();

            Console.ReadKey();
        }
    }
}

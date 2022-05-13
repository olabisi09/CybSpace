using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberspace.Starter
{
    public class Program
    {
        static void Main()
        {
            goto label1;
            var x = new DirectoryInfo(".");
            var dir = new DirectoryInfo(@"C:\Users\DELL\Pictures\testingDocument");
            Console.WriteLine(x.Name);
            Console.WriteLine(dir.Name);
            Console.WriteLine(dir.FullName);
            Console.WriteLine(dir.Parent);
            Console.WriteLine(dir.CreationTime);

            string[] words = { "Aule the smith", "Yavanna of the trees", "Manwe of the air", "Mandos" };
            string path = @"C:\Users\DELL\Pictures\testingDocument";

            //File.AppendAllLines(path, words);
            //foreach (var line in File.ReadAllLines(path))
            //{
            //    Console.WriteLine(line);
            //}

            var textFile = dir.GetFiles("*.txt", SearchOption.AllDirectories);
            foreach (var text in textFile)
            {
                Console.WriteLine(text.FullName);
                Console.WriteLine(text.CreationTime);
            }

            WriteStuff();
            ReadStuff();
        label1:
            UseFileStreamWrite();
            
        }

        static void UseFileStreamWrite()
        {
            string path = @"C:\Users\DELL\Pictures\testingDocument\testing.txt";
            var fileStream = File.Open(path, FileMode.Create);
            string word = "Ainulindale: the first book in the Silmarillion";

            byte[] list = Encoding.Default.GetBytes(word);
            fileStream.Write(list, 0, list.Length);

            fileStream.Position = 0;
            byte[] fileList = new byte[list.Length];
            for(int i = 0; i < list.Length; i++)
            {
                fileList[i] = (byte)fileStream.ReadByte();
            }
            Console.WriteLine(Encoding.Default.GetString(fileList));
            fileStream.Close();
        }

        static void WriteStuff()
        {
            var streamWriter = new StreamWriter(@"C:\Users\DELL\Pictures\testingDocument\testing.txt");
            streamWriter.WriteLine("Behold the Valar!");
            streamWriter.WriteLine("Manwe");
            streamWriter.Close();
        }

        static void ReadStuff()
        {
            var streamWriter = new StreamReader(@"C:\Users\DELL\Pictures\testingDocument\testing.txt");
            Console.WriteLine(streamWriter.ReadToEnd());
            streamWriter.Close();
        }
    }

    public class StudentData
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Class { get; set; }
        public decimal Grade { get; set; }

        public List<StudentData> Students()
        {
            return new List<StudentData>
            {
                new StudentData { Name = "Phoebe", Age = 31, Class = "400 level", Grade = 95 },
                new StudentData { Name = "Ross", Age = 28, Class = "200 level", Grade = 70 },
                new StudentData { Name = "Monica", Age = 30, Class = "500 level", Grade = 82 },
                new StudentData { Name = "Chandler", Age = 25, Class = "100 level", Grade = 95 },
                new StudentData { Name = "Joey", Age = 26, Class = "300 level", Grade = 63 },
                new StudentData { Name = "Rachel", Age = 25, Class = "100 level", Grade = 56 }
            };
        }
    }
}




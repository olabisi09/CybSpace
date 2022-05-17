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
            var students = StudentData.Students();
            string path = @"C:\Users\DELL\Pictures\testingDocument\StudentData.txt";

            //WriteToFile(students, path);
            //ReadFromFile(path);
        }

        static void WriteToFile(List<StudentData> students, string path)
        {
            var fileStream = new FileStream(path, FileMode.Open);
            string stuffToWrite = "";

            foreach (var student in students)
            {
                stuffToWrite = $"Name: {student.Name}, Age: {student.Age}, Class: {student.Class}, Grade: {student.Grade}\n";
                byte[] stuffInBytes = Encoding.Default.GetBytes(stuffToWrite);
                fileStream.Write(stuffInBytes, 0, stuffInBytes.Length);
            }

            fileStream.Close();
        }

        static void ReadFromFile(string path)
        {
            var fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);

            byte[] buffer = new byte[fileStream.Length];
            var byteRead = fileStream.Read(buffer, 0, buffer.Length);

            var stringResult = Encoding.Default.GetString(buffer, 0, byteRead);

            Console.WriteLine(stringResult);
            fileStream.Close();
        }
    }

    public class StudentData
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Class { get; set; }
        public decimal Grade { get; set; }

        public static List<StudentData> Students()
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




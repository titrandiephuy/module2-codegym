using System;
using System.IO;
using System.Linq;

namespace LessonFile
{
    class Pratice01
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string path = @"/Users/titrandiephuy/Library/Mobile Documents/com~apple~CloudDocs/Desktop/CodeGym/Module 2 - C#/Module 2 - Exercise/ReadWriteFile1/Data";
            string fileInput = "InputData.txt";
            Directory.CreateDirectory(@"/Users/titrandiephuy/Library/Mobile Documents/com~apple~CloudDocs/Desktop/CodeGym/Module 2 - C#/Module 2 - Exercise/ReadWriteFile1/Data/OutputData.txt");
            
            using (StreamReader sr = new StreamReader(Path.Combine(path, fileInput)))
            {
                string line = sr.ReadLine();
                string[] 
            }
        }
    }
}
using System;
using System.IO;
using System.Linq;

namespace LessonFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string path = @"/Users/titrandiephuy/Library/Mobile Documents/com~apple~CloudDocs/Desktop/CodeGym/Module 2 - C#/Module 2 - Exercise/ReadWriteFile1/Data";
            string fileInput = "InputData.txt";
            Directory.CreateDirectory(@"/Users/titrandiephuy/Library/Mobile Documents/com~apple~CloudDocs/Desktop/CodeGym/Module 2 - C#/Module 2 - Exercise/ReadWriteFile1/Data/OutputData.txt");
            string fileOutput = "OutputData.txt";
            static int[,] GenerateMatrix(int row, int column, int min, int max)
            {
                int[,] matrix = new int[row, column];
                Random rnd = new Random();
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        matrix[i, j] = rnd.Next(min, max);
                    }
                }
                return matrix;
            }


            int[,] matrix1 = GenerateMatrix(10, 5, 10, 90);
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    Console.Write(matrix1[i, j] + " ");
                }
                Console.WriteLine();
            }
            using (StreamWriter sw1 = File.CreateText(Path.Combine(path, fileInput)))
            {
                sw1.WriteLine(10);
                sw1.WriteLine(5);
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix1.GetLength(1); j++)
                    {
                        sw1.Write(matrix1[i, j] + " ");
                    }
                    sw1.WriteLine();
                }
            }

            int[,] matrix;
            int row;
            int column;
            using (StreamReader sr = File.OpenText(Path.Combine(path,fileInput)))
            {
                string firstLine = sr.ReadLine();
                row = int.Parse(firstLine);
                string secondLine = sr.ReadLine();
                column = int.Parse(secondLine);
            }
        }
    }
}
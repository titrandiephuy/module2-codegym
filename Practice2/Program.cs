using System;
using System.IO;
using System.Linq;

namespace LessonFile
{
    class Pratice2
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string path = @"/Users/titrandiephuy/Library/Mobile Documents/com~apple~CloudDocs/Desktop/CodeGym/Module 2 - C#/Module 2 - Exercise/Practice2/Data";
            string fileinput = "data.txt";
            string fileoutput = "out.txt";
            // Directory.CreateDirectory(Path.Combine(path, fileinput));
            // Directory.CreateDirectory(Path.Combine(path, fileoutput));

            // Console.WriteLine("Enter n: ");
            // int row = Int32.Parse(Console.ReadLine());
            // Console.WriteLine("Enter m: ");
            // int column = Int32.Parse(Console.ReadLine());

            int[][] matrix1 = GenerateMatrix(5, 7, 10, 70);
            ShowMatrix(matrix1);

            // using (StreamWriter sw1 = File.CreateText(Path.Combine(path, fileinput)))
            // {
            //     int row = matrix1.Length;
            //     int column = matrix1[0].Length;
            //     sw1.WriteLine($"{row} {column}");
            //     for (int i = 0; i < matrix1.Length; i++)
            //     {
            //         for (int j = 0; j < matrix1[i].Length; j++)
            //         {
            //             sw1.Write(matrix1[i][j] + " ");
            //         }
            //         sw1.WriteLine();
            //     }
            // }
            int[][] matrix2 = ReadFile(path, fileinput);
            WriteFile(path, fileoutput, matrix2);
            // int[][] matrix2;
            // using (StreamReader sr = File.OpenText(Path.Combine(path, fileinput)))
            // {
            //     string[] firstLine = sr.ReadLine().Split(" ");
            //     int row = int.Parse(firstLine[0]);
            //     int col = int.Parse(firstLine[1]);
            //     matrix2 = new int[row][];
            //     string line = string.Empty;
            //     int i =0;
            //     int[] array = new int[col];
            //     while((line = sr.ReadLine())!= null){
            //         array = line.Split(" ").Select(v => int.Parse(v)).ToArray();
            //         matrix2[i] = array; 
            //         i++;
            //     }
            // }

            // using (StreamWriter sw = File.CreateText(Path.Combine(path,fileoutput)))
            // {
            //     sw.WriteLine("Tong so chan  trong ma tran:" + CountEven(matrix2));
            //     sw.WriteLine("Tong cac so la boi so cua 5 trong ma tran:" + BoiSo5(matrix2));
            // }
        }

        private static void ShowMatrix(int[][] matrix1)
        {
            for (int i = 0; i < matrix1.Length; i++)
            {
                for (int j = 0; j < matrix1[i].Length; j++)
                {
                    Console.Write(matrix1[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void WriteFile(string path, string fileoutput, int[][] maxtrix)
        {
            using (StreamWriter sw = File.CreateText(Path.Combine(path, fileoutput)))
            {
                sw.WriteLine($"Total even number in matrix : {CountEven(maxtrix)}");
                sw.WriteLine($"Total boi so cua 5 in matrix : {BoiSo5(maxtrix)}");
            }
        }

                private static int[][] ReadFile(string path, string fileinput)
                {
                    using (StreamReader sr = File.OpenText(Path.Combine(path, fileinput)))
                    {
                        string line = sr.ReadLine();
                        string[] rowcol = line.Split(" ");
                        int row = int.Parse(rowcol[0]);
                        int column = int.Parse(rowcol[1]);
                        int[][] matrix = new int[row][];
                        int i = 0;
                        while ((line = sr.ReadLine()) != null)
                        {
                            int[] arr = new int[column];
                            arr = line.Split(" ").Select(v => int.Parse(v)).ToArray();
                            matrix[i] = arr;
                            i++;
                        }
                        return matrix;
                    }
                }

                static int CountEven(int[][] matrix)
                {
                    int count = 0;
                    for (int i = 0; i < matrix.Length; i++)
                    {
                        for (int j = 0; j < matrix[i].Length; j++)
                        {
                            if (IsEven(matrix[i][j]))
                            {
                                count++;
                            }
                        }
                    }
                    return count;
                }
                static bool IsEven(int number)
                {
                    if (number % 2 == 0)
                    {
                        return true;
                    }
                    return false;
                }

                static int BoiSo5(int[][] matrix)
                {
                    int count = 0;
                    for (int i = 0; i < matrix.Length; i++)
                    {
                        for (int j = 0; j < matrix[i].Length; j++)
                        {
                            if (matrix[i][j] % 5 == 0)
                                count++;
                        }
                    }
                    return count;
                }
                static int[][] GenerateMatrix(int row, int column, int min, int max)
                {
                    int[][] matrix = new int[row][];
                    Random rnd = new Random();
                    for (int i = 0; i < row; i++)
                    {
                        int[] array = new int[column];
                        for (int j = 0; j < column; j++)
                        {
                            array[j] = rnd.Next(min, max);
                        }
                        matrix[i] = array;
                    }
                    return matrix;
                }
            }
        }
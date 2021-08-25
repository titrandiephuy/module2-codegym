using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace StudentsMana
{
    class StudentDemo
    {
        public static void Main(String[] args)
        {
            string path = @"/Users/titrandiephuy/Library/Mobile Documents/com~apple~CloudDocs/Desktop/CodeGym/Module 2 - C#/Module 2 - Exercise/JsonTest/Data";
            string file = @"student.json";
            var result = FileHelper.ReadFile<Root>(Path.Combine(path,file));
            foreach (Student item in result.students)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
    public class Score
    {
        public string name { get; set; }
        public double value { get; set; }
        public override string ToString()
        {
            return $"{name}:\t{value}\n";
        }
    }

    public class Student
    {
        public string name { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public List<Score> scores { get; set; }
        public override string ToString()
        {
            var info = $"{name}\t\t{gender}\t\t{age}\n";
            foreach (Score score in scores)
            {
                info += $"\t\t{score.ToString()}";
            }
            return info;
        }

    }

    public class Root
    {
        public List<Student> students { get; set; }
    }
}
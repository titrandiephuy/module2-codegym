using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = GenerateArray(100000, 10, 1000);
            StopWatch stw = new StopWatch();
            stw.Start();
            Array.Sort(array);
            stw.Stop();
            TimeSpan elapse = stw.GetElapsedTime();
            ShowArray(array);
            Console.WriteLine($"Elapse time to sort 100000 value: {elapse}");


        }
        static int[] GenerateArray(int size = 10, int min = 10, int max = 100){
            int[] array = new int[size];
            for (int i = 0; i < size; i++){
                Random rand = new Random();
                int random = rand.Next(min, max);
                array[i] = random;
            }
            return array;
        }

        static void ShowArray(int[] array){
            Console.WriteLine(string.Join("-", array));
        }
    }

    class StopWatch
    {
        private DateTime startTime;
        private DateTime endTime;
        public StopWatch()
        {
            startTime = DateTime.Now;
        }

        public StopWatch(DateTime startTime, DateTime endTime)
        {
            this.startTime = startTime;
            this.endTime = endTime;
        }

        public void Start()
        {
            this.startTime = DateTime.Now;
        }

        public void Stop()
        {
            this.endTime = DateTime.Now;
        }

        public TimeSpan GetElapsedTime()
        {
            TimeSpan interval = this.startTime - this.endTime;
            return interval;
        }


    }
}

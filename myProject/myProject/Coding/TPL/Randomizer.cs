using System;
using System.IO;

namespace myProject.Coding.TPL
{
    public class Randomizer:IDisposable
    {
        StreamWriter str;
        private static object _lock = new object();

        public Randomizer()
        {
            str = new StreamWriter(@"C:\Users\Krzyś\MyGitHub\myProject\myProject\Coding\TPL\txt\1.txt", true);
        }
        public int GetRandomNumber()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            return  r.Next(10000, 9999999);
            
        }

        public void Save()
        {
            lock (_lock)
            {
                str.WriteLine(GetRandomNumber());
            }
        }

        public void Dispose()
        {
            str.Close();
        }
    }
}
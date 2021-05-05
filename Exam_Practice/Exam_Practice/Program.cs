using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Exam_Practice
{
    class Program
    {
        public static List<int> TempFSort = new List<int>();
        public static List<int> Tmp2 = new List<int>();
        public static Dictionary<int, string> OfAll = new Dictionary<int, string>();
        static void Main(string[] args)
        {
            Read();
            faszomtudja();
        }
        public static void Read()
        {
            StreamReader ReadS = new StreamReader("sikeres.txt",Encoding.UTF8);
            StreamReader ReadU = new StreamReader("sikertelen.txt",Encoding.UTF8);

            ReadS.ReadLine();
            ReadU.ReadLine();
            
            while (!ReadS.EndOfStream)
            {
                string[] split = ReadS.ReadLine().Split(';');
                int x = 0;
                for (int i = 1; i < split.Length; i++)
                {
                    x = Convert.ToInt32(split[i]);
                    Tmp2.Add(x);
                }
            }
            int tmp = 0;
            while (!ReadU.EndOfStream)
            {
                string[] split = ReadU.ReadLine().Split(';');
                int x = 0;
                for (int i = 1; i < split.Length; i++)
                {
                    x = Convert.ToInt32(split[i]) + Tmp2[tmp];
                }
                OfAll.Add(x, split[0]);
                tmp++;
            }
            
        }
        public static void faszomtudja()
        {
            TempFSort = OfAll.Keys.ToList();
            TempFSort.Sort();
            TempFSort.Reverse();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Convert.ToString(TempFSort[i]));
            }
            Console.ReadLine();
        }
    }
}

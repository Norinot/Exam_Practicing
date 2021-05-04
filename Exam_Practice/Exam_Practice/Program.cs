using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Exam_Practice
{
    class Program
    {
        public static List<string> Unsuccessfull = new List<string>();
        public static List<string> Successfull = new List<string>();

        static void Main(string[] args)
        {
            ReadUnSuc();
            ReadSuc();
            SumUnSucc();
            SumSucc();
        }
        public static void SumSucc()
        {

            for (int i = 1; i < Successfull.Count; i++)
            {
                string[] SplitSuc = Successfull[i].Split(';');
                int Summed = 0;
                for (int j = 1; j < SplitSuc.Length; j++)
                {
                    Summed += Convert.ToInt32(SplitSuc[j]);
                }
                int TmpSum = Summed;
                Summed = 0;
                if (i == 1)
                {
                    Console.WriteLine("Angol:{0}", TmpSum);
                }
                else if (i == 2)
                {
                    Console.WriteLine("Arab:{0}", TmpSum);
                }
                else if (i == 3)
                {
                    Console.WriteLine("Bolgár:{0}", TmpSum);
                }
                else if (i == 4)
                {
                    Console.WriteLine("Cigány:{0}", TmpSum);
                }
            }
        }
        public static void SumUnSucc()
        {
            
            for (int i = 1; i < Unsuccessfull.Count; i++)
            {
                string[] SplitUnSuc = Unsuccessfull[i].Split(';');
                int Summed = 0;
                for (int j = 1; j < SplitUnSuc.Length; j++)
                {
                        Summed += Convert.ToInt32(SplitUnSuc[j]);
                }
                
                int TmpSum = Summed;
                Summed = 0;
                if (i == 1)
                {
                    Console.WriteLine("Angol:{0}", TmpSum);
                }
                else if (i == 2)
                {
                    Console.WriteLine("Arab:{0}", TmpSum);
                }
                else if (i == 3)
                {
                    Console.WriteLine("Bolgár:{0}", TmpSum);
                }
                else if (i == 4)
                {
                    Console.WriteLine("Cigány:{0}", TmpSum);
                }
            }
        }
        public static void ReadUnSuc()
        {
            StreamReader ReadIn = new StreamReader("sikertelen.txt", Encoding.UTF8);
            while (!ReadIn.EndOfStream)
            {
                Unsuccessfull.Add(ReadIn.ReadLine());
            }
            ReadIn.Close();
        }
        public static void ReadSuc()
        {
            StreamReader ReadIn = new StreamReader("sikeres.txt",Encoding.UTF8);
            while (!ReadIn.EndOfStream)
            {
                Successfull.Add(ReadIn.ReadLine());
            }
            ReadIn.Close();
        }
    }
}

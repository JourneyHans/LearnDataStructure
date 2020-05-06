using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SeqList<int> testSeq = new SeqList<int>(8);
            testSeq.Append(11);
            testSeq.Append(23);
            testSeq.Append(36);
            testSeq.Append(45);
            testSeq.Append(80);
            testSeq.Append(60);
            testSeq.Append(40);
            testSeq.Append(6);
            Console.WriteLine("Origin: ");
            for (int i = 0; i < testSeq.GetLength(); i++)
            {
                Console.WriteLine($"index: {i}, value: {testSeq[i]}");
            }
            Console.WriteLine("Reversed: ");
            testSeq.Reverse();
            for (int i = 0; i < testSeq.GetLength(); i++)
            {
                Console.WriteLine($"index: {i}, value: {testSeq[i]}");
            }
        }
    }
}

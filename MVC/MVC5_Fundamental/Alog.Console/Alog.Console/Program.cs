﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Alog.Con
{
    class Program
    {
        static void Main(string[] args)
        {
            #region "Longest Rising Seqence"
            int[] a = { 1, 2, 3, -1, -2, -3, 9, 4,6,7 };
            Console.WriteLine("Start Indexes & length of Rising Sequence of Array int[] a = { 1, 2, 3, -1, -2, -3, 9, 4,6,7 }");                
            Dictionary<int, int> result = new Dictionary<int, int>();

            if (GetStartIndex(a) != null)
            {
                result = GetStartIndex(a);

                Console.WriteLine("Result (Start Index, Length):");
                result.ToList().ForEach(i => Console.WriteLine($"Start Index : {i.Key} , Length : {i.Value}"));

                Console.WriteLine("------------------"); 

                Console.WriteLine("Longest Rising sequence:");
                int max = result.Values.Max();                
                Console.WriteLine($"Longest Length is : {max}");
                Console.Write($"Start Indexes are ");
                result.Where(x => max.Equals(x.Value)).Select(x => x.Key).ToList().ForEach(i => Console.Write(i + ","));
            }
            else
            {
                Console.WriteLine("No Result");

            }                      
            Console.Read();
            #endregion "Longest Rising Sequence"
        }

        /// <summary>
        /// Get Start Indexes, Length of Rising Sequence in the array 
        /// </summary>
        /// <returns></returns>
        public static Dictionary<int, int> GetStartIndex(int[] a)
        {
            //Save Start Indexes, Length of Rising Sequence
           Dictionary<int, int> result = new Dictionary<int, int>();                    
            for (int i = 0; i < a.Length; i++)
            {
                int nextroom = i + 1;
                if (nextroom != a.Length && (a[i] < a[i + 1]))
                {
                    int length = 1;
                    int j = i;
                    while (j < a.Length && j + 1 < a.Length && a[j] < a[j + 1])
                    {                      
                        length++;
                        j++;
                    }                    
                    result.Add(i, length);
                    i = j;
                }
            }
            
            return result;
        }
    }
}
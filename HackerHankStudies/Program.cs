using System;
using System.Collections.Generic;
using System.IO;

namespace HackerHankStudies
{
    internal class Program
    {
        public static void Main(string[] args)
        {

        }

        //Funcao para retornar o numero que não é repetido 
        public static int lonelyInteger(List<int> a)
        {
            int lonelyNumber = 0;

            foreach (int i in a)
            {
                var listInt = a.FindAll(x => x == i);
                if (listInt.Count == 1)
                {
                    lonelyNumber = listInt[0];
                }
            }
            return lonelyNumber;
        }

        //Funcao para retornar hora no Formato hh:MM:ss
        public static string TimeFormatConverter(string s)
        {
            var splits = s.Split(":");

            int hour1 = int.Parse(splits[0]);
            char p = 'P';
            char a = 'A';

            if (s[8] == p && hour1 == 12)
            {
                return hour1 + ":" + splits[1] + ":" + splits[2].Substring(0, 2);
            }

            if (s[8] == a && hour1 == 12)
            {
                return "00" + ":" + splits[1] + ":" + splits[2].Substring(0, 2);
            }

            if (s[8] == p && hour1 != 12)
            {
                hour1 = hour1 + 12;
                return hour1 + ":" + splits[1] + ":" + splits[2].Substring(0, 2);
            }

            if (s[8] == a && hour1 != 12)
            {
                string horaCerta;
                if(hour1 < 10)
                {
                    horaCerta = "0" + hour1;
                    return horaCerta + ":" + splits[1] + ":" + splits[2].Substring(0, 2);
                }
                return hour1 + ":" + splits[1] + ":" + splits[2].Substring(0, 2);
            }

            return null;

        }

        //Funcao para retornar os numero de strings que dao matches
        public static List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            List<int> numbers = new();
            List<string> test = new List<string> { "aba", "baba", "aba", "xzxb" };
            List<string> querie = new List<string> { "aba", "xzxb", "ab" };

            for(int i = 0; i < querie.Count; i++)
            {
                List<string> querieHelper = test.FindAll(x => x == queries[i]);
                numbers.Add(querieHelper.Count);
            }
            return numbers;
            
        }

        public void MixDeArrays()
        {
            List<int> arr = new List<int>() { 256741038, 623958417, 467905213, 714532089, 938071625 };

            int min = arr[0];
            int max = arr[0];

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }

            Console.WriteLine("{0} {1}", min, max);

            long totalSum = 0;

            foreach (int i in arr)
            {
                totalSum += i;
            }

            long maxSum = totalSum - min;
            long minSum = totalSum - max;

            Console.WriteLine(totalSum);
            Console.WriteLine("{0} {1}", minSum, maxSum);
        }
    }
}

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int sockMerchant(int n, List<int> ar)
    {
        /*
        Pseudocode
            Ask user for n
            int n = userAnswer;

            Ask user for arr[n]
            ar[i] = [10 10 20 10 20 40]

            =============

            DONE Sort in Ascending Order sort()

            take leftMost
                go through each for()
                if findMatch = add 1 to PairCounter
                else (SocksWithNoMatch = n)

                onceDone, arr[i+1] 

            output PairCounter = ?
        */
        // Console.WriteLine(ar);
        //ar.Sort();
        // Console.WriteLine(ar);
        // return 1;
        int PairCounter = 0;
        // ar.Sort();
        if (n >= 1 && n <= 100)
        {
            for (int i = 0; i < n; i++)                     // i runs from 0 to n
            {
                if (ar[i] >= 1 && ar[i] <= 100)
                {
                    int FirstSock = ar[i];
                    for (int j = i + 1; j < n; j++)         // j is ALWAYS after i while j < n
                    {
                        int SecondSock = ar[j];

                        if (SecondSock == FirstSock)
                        {
                            PairCounter = PairCounter + 1;
                            ar.RemoveAt(j);             // Remove j'th element sock
                            ar.RemoveAt(i);             // Remove i'th element sick
                            n = n - 2;                  // Subtract 2 from the total sock count
                            i = i - 1;
                            break;
                        }
                    }
                }
            }
            // n = Math.Abs(ar.Count());
            return PairCounter;
        }
        else return 0;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.sockMerchant(n, ar);

        Console.WriteLine(result);

        /*textWriter.Flush();
        textWriter.Close();*/
    }
}

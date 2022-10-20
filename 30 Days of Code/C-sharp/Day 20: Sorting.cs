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

class Solution
{
    static void Main(String[] args)
    {
        var a = int.Parse(Console.ReadLine());
        var ar = Console.ReadLine().Split(' ');
        var arr = Array.ConvertAll(ar, int.Parse);

        int numSwaps = 0;
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < a - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int tmp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = tmp;
                    numSwaps++;
                }
            }

            if (numSwaps == 0)
            {
                break;
            }
        }

        Console.WriteLine("Array is sorted in " + numSwaps + " swaps.");
        Console.WriteLine("First Element: " + arr[0]);
        Console.WriteLine("Last Element: " + arr[arr.Length - 1]);
    }
}

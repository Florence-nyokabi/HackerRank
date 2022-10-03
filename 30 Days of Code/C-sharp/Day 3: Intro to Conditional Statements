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
    public static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());

        Console.WriteLine(CheckValue(N));
    }
    public static string CheckValue(int N)
    {
        if (N % 2 == 1)
        {
            return "Weird";
        }
        else if (N % 2 == 0 && N > 2 && N < 5 )
        {
            return "Not Weird";
        }
        else if (N % 2 == 0 && N > 6 && N <= 20)
        {
            return "Weird";
        }
        else if (N % 2 == 0 && N > 20)
        {
            return "Not Weird";
        }
        else
        {
            return "";
        }
    }
}

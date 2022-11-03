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

class Solution {
    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < t; i++) {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);

            if (((k - 1) | k) > n && k % 2 == 0) {
                Console.WriteLine(k - 2);
            }
            else {
                Console.WriteLine(k - 1);
            }
        }
    }
}

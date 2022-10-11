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

    static void Main(string[] args) {
        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }
        int result = -9 * 7;
        int rowCount = arr.Length;
        int columnCount = arr[0].Length;

        for (int c = 0; c < columnCount - 2; c++) {
            for (int r = 0; r < rowCount - 2; r++) {
                int firstRowSum = arr[r][c] + arr[r][c + 1] + arr[r][c + 2];
                int secondRowSum = arr[r + 1][c + 1];
                int thirdRowSum = arr[r + 2][c] + arr[r + 2][c + 1] + arr[r + 2][c + 2];
                int totalHourGlass = firstRowSum + secondRowSum + thirdRowSum;

                result = Math.Max(result, totalHourGlass);
            }
        }

        Console.WriteLine(result);
    }
}

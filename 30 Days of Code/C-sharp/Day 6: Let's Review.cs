using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; ++i)
        {
            string line = Console.ReadLine();
            string even = "";
            string odd = "";
            
            // the condition is length - 1 because
            // if length in odd (i.e. 5) it will iterate 3 times: j = 0, 2, 4
            // in this case second line (j + 1) will cause
            // array index out of bound exception
            // when it is (length - 1) it will iterate 2 times: j = 0, 2
            // this last letter is added after the loop
            for (int j = 0; j < line.Length - 1; j += 2)
            {
                even += line[j];
                odd += line[j + 1];
            }

            // if line length is odd we need to add the last letter to result
            if (line.Length % 2 != 0)
            {
                even += line[line.Length - 1];    
            }
            
            Console.WriteLine("{0} {1}", even, odd);
        }
    }
}

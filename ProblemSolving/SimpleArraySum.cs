using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Challenge: Given an array of integers, find the sum of its elements.
     * Complete the simpleArraySum function below.
     */
    static int simpleArraySum(int[] ar) {
      int sum = 0, i = 0;
      for(i = 0; i < ar.Length; i++){
        sum = sum + ar[i];
      }
      return sum;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = simpleArraySum(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

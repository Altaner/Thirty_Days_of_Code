using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        
        // Declare second integer, double, and String variables.
        int sInt;
        double sDouble;
        string sString;
        // Read and save an integer, double, and String to your variables.
        sInt = Convert.ToInt32(Console.ReadLine());
        sDouble = Convert.ToDouble(Console.ReadLine());
        sString = Console.ReadLine();
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + sInt);
        // Print the sum of the double variables on a new line.
        double toplam = d + sDouble;
        Console.WriteLine("{0:R}", toplam);
        // Concatenate and print the String variables on a new line
        Console.WriteLine(s + sString);
        // The 's' variable above should be printed first.

    }
}
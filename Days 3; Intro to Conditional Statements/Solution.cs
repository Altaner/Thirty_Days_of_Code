using System;



class Solution
{
    public static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());
        if ((N%2) == 0 && 2<N && N<5)
            Console.Write("Not Weird");
        if ((N%2) == 0 && 6<N && N<=20)
            Console.Write("Weird");
        if ((N%2) == 0 && N>20)
            Console.Write("Not Weird");
        if ((N%2) != 0)
            Console.Write("Weird");
    }
}
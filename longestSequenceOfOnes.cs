using System;
using System.IO;
using System.Text;

class Solution
{
    static void Main(string[] args)
    {
        string b = Console.ReadLine();
        int currentOnes = 0;
        int finalOnes = 0;
        string[] words = b.Split('0');
            for (int i = 0; i < words.Length-1; i++)
            {
                currentOnes = words[i].Length + words[i+1].Length;
                if(currentOnes > finalOnes)
                {
                    finalOnes = currentOnes;
                }   
            }
            Console.WriteLine(finalOnes+1);
    }
}

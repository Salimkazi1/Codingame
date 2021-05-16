using System;

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int i = 0, j,k = 0;
        while(i*5 <= N)
        {
            j = 0;
            while(j <= i && (i*5 + j*2 <= N))
            {
                k = 0;
                while(i*5 + j*2 + k*3 <= N){
                    if(i*5 + j*2 + k*3 == N){
                        Console.WriteLine(i + " " + j + " " + k);
                    }
                k++;    
                }
            j++;    
            }
        i++;
        }
    }
}

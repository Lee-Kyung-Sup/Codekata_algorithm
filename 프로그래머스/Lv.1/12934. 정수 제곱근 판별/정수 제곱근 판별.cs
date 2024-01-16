using System;

public class Solution
{
    public long solution(long n) 
    {
        long answer = 0;
        long x = (long)Math.Sqrt(n);
        if(x*x==n)
        {
            answer = (long)Math.Pow(x+1,2);
        }
        else
        {
            answer = -1;
        }
        return answer;
    }
}
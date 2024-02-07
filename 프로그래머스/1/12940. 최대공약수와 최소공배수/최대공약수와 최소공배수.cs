using System;

public class Solution 
{
    public int[] solution(int n, int m) 
    {
        int gcd = GCD(n, m);
        int lcm = LCM(n, m);
        
        return new int[] { gcd, lcm };
    }

    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    private int LCM(int a, int b)
    {
        return Math.Abs(a * b) / GCD(a, b);
    }
}

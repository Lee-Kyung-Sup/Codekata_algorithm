using System;

public class Solution 
{
    public long solution(long n)
    {
        char[] num = n.ToString().ToCharArray();
        Array.Sort(num);
        Array.Reverse(num);
        return long.Parse(new string(num));
    }
}
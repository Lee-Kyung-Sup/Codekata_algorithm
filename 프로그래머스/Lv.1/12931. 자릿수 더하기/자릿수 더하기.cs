using System;

public class Solution 
{
    public int solution(int n) 
    {
        int numsum = 0;
        foreach(char tosum in n.ToString())
        {
           numsum += int.Parse(tosum.ToString());
        }
        return numsum;
    }
}
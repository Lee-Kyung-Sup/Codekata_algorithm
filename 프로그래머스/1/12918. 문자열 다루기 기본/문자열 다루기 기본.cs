using System;
using System.Linq;

public class Solution 
{
    public bool solution(string s)
    {
        if(s.Length == 4 || s.Length == 6)
        {
            return s.All(char.IsDigit);
        }
        else
        {
            return false;
        }
    }
}
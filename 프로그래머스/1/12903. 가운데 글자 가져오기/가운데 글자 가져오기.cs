using System;

public class Solution
{
    public string solution(string s) 
    {
        string answer = "";
        int n = (s.Length +1)%2;
        int l = (s.Length /2)-n;
        return answer = s.Substring(l, n+1);
    }
}
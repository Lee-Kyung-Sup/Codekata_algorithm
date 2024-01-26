using System;
using System.Text;

public class Solution 
{
    public string solution(int n)
    {
        StringBuilder wm = new StringBuilder();
        
        for(int i = 0; i<n/2;i++)
        {
            wm.Append("수박");
        }
        if(n % 2 == 1)
        {
            wm.Append("수");
        }
        return wm.ToString();
    }
}
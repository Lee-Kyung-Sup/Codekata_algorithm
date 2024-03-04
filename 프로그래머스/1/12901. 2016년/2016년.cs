using System;

public class Solution
{
    public string solution(int a, int b) 
    {
        string answer = "";
        
        DateTime date = new DateTime(2016, a, b);
        answer = date.DayOfWeek.ToString().Substring(0, 3).ToUpper();
        
        return answer;
    }
}
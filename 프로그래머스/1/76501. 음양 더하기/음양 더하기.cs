using System;

public class Solution 
{
    public int solution(int[] absolutes, bool[] signs)
    {
        int answer =0;
        for(int i = 0; i<absolutes.Length; i++)
        {
            int sign = signs[i] ? 1 : -1;
            answer += absolutes[i] * sign;
        }
        return answer;
    }
}
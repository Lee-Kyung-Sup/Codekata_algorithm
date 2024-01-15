using System.Collections.Generic;

public class Solution 
{
    public int[] solution(long n) 
    {
        List<int> answer = new List<int>();
        while(n>0)
        {
            int num = (int)(n%10);
            answer.Add(num);
            n /= 10;
        }
        return answer.ToArray();
    }
}
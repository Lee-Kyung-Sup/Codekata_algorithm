using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] arr, int divisor) 
    {
        List<int> answerlist = new List<int>();
        for(int i = 0; i<arr.Length; i++)
        {
            if(arr[i]%divisor == 0)
            {
                answerlist.Add(arr[i]);
            }
        }
        
        if(answerlist.Count ==0)
        {
            return new int[] {-1};
        }
        
        int[] answer = answerlist.ToArray();
        Array.Sort(answer);
        return answer;
    }
}
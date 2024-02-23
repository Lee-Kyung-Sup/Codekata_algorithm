using System;
using System.Linq;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] numbers) 
    {
        List<int> list = new List<int>();
        for(int i=0; i<numbers.Length-1; i++)
        {
            for(int j=i+1; j<numbers.Length; j++)
            {
                list.Add(numbers[i] + numbers[j]); 
            }
        }
        list.Sort();
        int[] answer = new int[list.Count];
        answer = list.Distinct().ToArray();
        return answer;
    }
}
using System;
using System.Linq;

public class Solution 
{
    public int[] solution(int k, int[] score) 
    {
        int[] answer = new int[score.Length];
        for (int i = 0; i < score.Length; i++)
        {
            int[] record = score.Take(i + 1).OrderBy(n => n).Skip(i + 1 - k).ToArray();
            answer[i] = record.Min();
        }
        return answer;
    }
}
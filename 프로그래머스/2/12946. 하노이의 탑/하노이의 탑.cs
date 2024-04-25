using System;
using System.Collections.Generic;

public class Solution 
{
    public int[,] solution(int n)
    {
        List<(int, int)> answer = new List<(int, int)> ();
        Hanoi(n, 1, 3, 2, answer);

        int[,] array = new int[answer.Count, 2];

        for (int i = 0; i < answer.Count; i++)
        {
            array[i, 0] = answer[i].Item1;
            array[i, 1] = answer[i].Item2;
        }

        return array;
    }

    public void Hanoi(int n, int start, int target, int middle, List<(int, int)> answer)
    {
        if (n == 1)
        {
            answer.Add((start, target));
            return;
        }

        Hanoi(n - 1, start, middle, target, answer);
        answer.Add((start, target));
        Hanoi(n - 1, middle, target, start, answer);
    }
}
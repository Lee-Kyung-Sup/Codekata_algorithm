using System;
using System.Linq;

public class Solution
{
    public string solution(string X, string Y)
    {
        string answer = "";

        int[] xArray = new int[10];
        int[] yArray = new int[10];

        for (int i = 0; i < X.Length; i++)
        {
            xArray[int.Parse(X[i].ToString())]++;
        }
        for (int i = 0; i < Y.Length; i++)
        {
            yArray[int.Parse(Y[i].ToString())]++;
        }

        for (int i = 9; i >= 0; i--)
        {
            if (xArray[i] == 0 || yArray[i] == 0)
                continue;

            int min = Math.Min(xArray[i], yArray[i]);

            answer += string.Concat(Enumerable.Repeat(i, min));
        }

        if (answer.Length == 0)
            answer = "-1";
        else if (answer[0] == '0')
            answer = "0";

        return answer;
    }
}
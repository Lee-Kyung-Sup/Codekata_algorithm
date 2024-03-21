using System;

public class Solution
{
    public string solution(string s, string skip, int index)
    {
       string answer = "";

        foreach (char ch in s)
        {
            char temp = ch;
            int count = 0;

            while (count < index)
            {
                temp = (char)(temp + 1);

                if (temp > 'z')
                    temp = 'a';

                if (skip.Contains(temp))
                    continue;

                count++;
            }
            answer += temp;
        }

        return answer;
    }
}
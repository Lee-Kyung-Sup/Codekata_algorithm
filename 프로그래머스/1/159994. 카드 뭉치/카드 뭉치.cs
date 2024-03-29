using System;

public class Solution
{
    public string solution(string[] cards1, string[] cards2, string[] goal)
    {
        string answer = "Yes";

        int idx1 = 0;
        int idx2 = 0;
        for (int i = 0; i < goal.Length; i++)
        {
            if (idx1 < cards1.Length && goal[i] == cards1[idx1])
            {
                idx1++;
                continue;
            }
            else if (idx2 < cards2.Length && goal[i] == cards2[idx2])
            {
                idx2++;
                continue;
            }
            else
            {
                answer = "No";
            }
        }
        return answer;
    }
}
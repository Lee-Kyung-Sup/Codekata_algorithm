using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int storey)
    {
        int answer = 0;
        while (storey > 0)
        {
            int num = storey % 10;

            if (num > 5)
            {
                answer += 10 - num;
                storey = storey / 10;
                storey++;
            }
            else if (num == 5)
            {
                answer += 5;
                storey = storey / 10;

                if (storey % 10 > 4)
                {
                     storey++;
                }
            }
            else
            {
                answer += num;
                storey = storey / 10;
            }
        }
        return answer;
    }
}
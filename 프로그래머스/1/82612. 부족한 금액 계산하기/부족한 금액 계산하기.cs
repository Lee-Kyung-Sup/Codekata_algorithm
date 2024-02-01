using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long sum = 0;
        long result =0;
        for(int i = 1; i<=count; i++)
        {
            sum += price*i;
        }
        if(sum>money)
            {
                result = sum - money;
            }
            else
            {
                result = 0;
            }
        return result;
    }
}
using System;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] lottos, int[] win_nums)
    {
        int right = 0;
        int zeroCount =0;
        for(int i=0; i<lottos.Length; i++)
        {
            if(lottos[i]==0) 
            { 
                zeroCount++; 
            }
            if(lottos.Contains(win_nums[i])) 
            {
                right++; 
            }
        }
        
        int MaxRank = zeroCount+right;
        int MinRank = right;
        
        if(MinRank == 0)
        { 
            MinRank++; 
        }
        if(MaxRank == 0)
        { 
            MaxRank++; 
        }
        
        int[] answer = new int[] { 7-MaxRank, 7-MinRank };
        return answer;
    }
}
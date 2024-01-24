using System;

public class Solution
{
    public int[] solution(int[] arr)
    {
        int min = 0;
        for(int i =1; i<arr.Length; i++)
        {
            if(arr[i]<arr[min])
            {
                min = i;
            }
        }
        
        int[] answer = new int[arr.Length -1]; 
        int ansindex = 0;
        for(int i = 0; i<arr.Length; i++)
        {
            if(i != min)
            {
                answer[ansindex] = arr[i];
                ansindex++;
            }
        }
       
        if(arr.Length<=1)
        {
            return new int[] {-1};
        }
        return answer;
    }
}
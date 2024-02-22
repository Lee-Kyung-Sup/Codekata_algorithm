using System;

public class Solution 
{
    public int[] solution(int[] array, int[,] commands)
    {        
        int[] answer = new int[commands.GetLength(0)];
        
        for (int index = 0; index < answer.Length; index++)
        {
            int i = commands[index, 0];
            int j = commands[index, 1];
            int k = commands[index, 2];
            
            int[] temp = new int[j - i + 1];
            
            int idx = 0;
            
            for (int arrayIndex = i - 1; arrayIndex < j; arrayIndex++)
            {
                temp[idx++] = array[arrayIndex];
            }
            
            Array.Sort(temp);
            
            answer[index] = temp[k - 1];
        }
        
        return answer;
    }
}
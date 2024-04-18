using System.Collections.Generic;
using System;
public class Solution
{
   public int[] solution(int n)
   {
     List<int> answer = new List<int>();
     int[,] arr = new int[n, n];
     int value = 1;
     int x = -1;
     int y = 0;
        
     for (int i = 0; i < n; i++)
     {
         for (int j = i; j < n; j++)
         {
             if (i % 3 == 0)
             {
                 x++;     
             }
             else if (i % 3 == 1) 
             {
                 y++;
             }
             else if (i % 3 == 2) 
             {
                 x --; y --;
             }
             arr[x, y] = value++;

         }
     }
    
     for (int i = 0; i < n; i++)
     {
         for (int j = 0; j < n; j++)
         {
             if (arr[i, j] == 0)
             {   
                 break;
             }
             answer.Add(arr[i, j]);
         }
     }
     return answer.ToArray();
   }

}


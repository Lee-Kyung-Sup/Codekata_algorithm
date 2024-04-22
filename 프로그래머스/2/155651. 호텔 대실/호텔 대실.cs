using System;
using System.Collections.Generic; 
using System.Linq; 
 
public class Solution 
{
    public int solution(string[,] book_time) 
    {
         int answer = 0;
         int[] room = new int[1500]; 
 
            for (int i = 0; i < book_time.GetLength(0); i++) 
            {
                string[] startTimestring = book_time[i, 0].Split(':');
                string[] endTimestring = book_time[i, 1].Split(':');
 
                
                int startTime = int.Parse(startTimestring[0]) * 60 + int.Parse(startTimestring[1]);
                int endTime = int.Parse(endTimestring[0]) * 60 + int.Parse(endTimestring[1]) + 10;
 
               
                for (int j = startTime ; j < endTime; j++)
                {
                    room[j]++;
                }
            }
        
            for (int i = 0; i < 1500; i++)
            {
                if (answer < room[i]) 
                {
                    answer = room[i];
                }
            }
            return answer;
    }
}
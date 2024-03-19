using System;

public class Solution
{
    public int solution(string s) 
    {
         int answer = 0;
         int fCount = 0;
         int oCount = 0;
         char first;

         first = s[0];
         int i;

             
          for (i = 0; i < s.Length - 1; i++)
          {
              if (first == s[i])
              {
                  fCount++;
              }
              else       
              {
                  oCount++;
              }

             if (fCount == oCount) 
             {
                 fCount = 0;
                 oCount = 0;
                 answer++;

                 first = s[i + 1]; 
             }
         }
    
    
         if ((s = s.Substring(i)).Length != 0) 
         {
              answer++;
         }
            
         return answer;
    }
}
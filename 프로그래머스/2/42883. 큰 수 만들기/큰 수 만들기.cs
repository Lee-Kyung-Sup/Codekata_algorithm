using System;
using System.Text;

public class Solution
{
    public string solution(string number, int k) 
    {
        string answer = "";
        number = "9" + number;
        StringBuilder sb = new StringBuilder(number);
        int index = 0;
        
        for(int i = 0; i < k; i++)
        {
            while (true)
            {
                if(index + 1 == sb.Length)
                {
                    sb.Remove(index, 1);
                    index--;
                    break;
                }

                if(sb[index] < sb[index + 1])
                {
                    sb.Remove(index, 1);
                    index--;
                    break;
                }
                
                index++;
            }
        }

            return answer = sb.Remove(0,1).ToString();
    }
}

 
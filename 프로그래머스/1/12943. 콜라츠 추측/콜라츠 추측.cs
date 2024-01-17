public class Solution 
{
    public long solution(long num)
    {
        long count = 0;
        while(num != 1 && count < 500)
        {
            if(num%2==0)
            {
                num /= 2;
            }
            else
            {
                num = (num*3)+1; 
            }
            count++;
         }
    
        if(num == 1)
        {
            return count;
        }
        else
        {
            return -1;
        }
    }
}
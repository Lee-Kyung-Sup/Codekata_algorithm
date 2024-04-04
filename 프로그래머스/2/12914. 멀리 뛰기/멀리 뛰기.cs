public class Solution 
{
    long[] num = new long[2000];
    
    public long solution(int n)
    {
        num[0] = 1;
        num[1] = 2;
        
        for (int i = 2; i < n; i++)
        {
            num[i] = (num[i - 2] + num[i - 1]) % 1234567;
        }
            
        return num[n - 1];
    }
}
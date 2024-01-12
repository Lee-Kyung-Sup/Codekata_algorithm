public class Solution 
{
    public double solution(int[] arr)
    {
        int sum = 0;
        for(int i = 0; i<arr.Length; i++)
        {
            sum += arr[i];
        }
        double answer = (double)sum / arr.Length;
        return answer;
    }
}
public class Solution {
    public int solution(int n) {
        int[] temp = new int[n+1];
        temp[0]= 0;
        temp[1] =1;
        for(int i=2; i<=n;i++)
        {
            temp[i]=(temp[i-2]+temp[i-1])%1234567;
            
        }
        return temp[n];
    }
}
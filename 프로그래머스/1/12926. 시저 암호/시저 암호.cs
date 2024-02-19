public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        
        char[] temp = s.ToCharArray();
        
        for(int i=0; i<temp.Length; i++)
        {
            if(temp[i] == ' ')
            {
                answer += temp[i].ToString();
                continue;
            }
            for(int j = 1; j <= n; j++)
            {
                if (temp[i] == 'Z')
                {
                    temp[i] = 'A';
                }
                    
                else if (temp[i] == 'z')
                {
                    temp[i] = 'a';
                }
                   
                else
                {
                    temp[i] = (char)(temp[i] + 1);
                }
            }
            answer += temp[i].ToString();
        }
        return answer;
    }  
}
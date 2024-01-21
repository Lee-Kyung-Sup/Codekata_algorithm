public class Solution 
{
    public string solution(string phone_number) 
    {
       
        int numlength = phone_number.Length;
        string lastnum = phone_number.Substring(numlength-4);
        string answer = lastnum.PadLeft(numlength, '*');
        return answer;
    }
}
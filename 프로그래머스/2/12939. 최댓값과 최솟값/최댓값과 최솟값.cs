using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public string solution(string s) 
    {
        
        List<int> list= new List<int>();
        string[]strArr=s.Split(' ');
        
        for(int i=0; i<strArr.Length; i++)
        {
            list.Add(int.Parse(strArr[i]));
        }
        
        int max = list.Max();
        int min=list.Min();
        int[] arr = new int[] { min, max };
        string str=string.Join(" ", arr);
        
        return str;

    }
}
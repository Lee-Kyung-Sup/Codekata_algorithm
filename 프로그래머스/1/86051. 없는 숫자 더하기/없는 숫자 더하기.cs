using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int[] numbers) 
    {
       var arraynum = new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9};
       return arraynum.Except(numbers).Sum();
    }
}
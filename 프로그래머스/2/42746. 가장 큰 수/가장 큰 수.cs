using System;
using System.Linq;

public class Solution
{
        public string solution(int[] numbers)
        {
            Array.Sort(numbers, (x, y) =>
            {
                string XY = x.ToString() + y.ToString();
                string YX = y.ToString() + x.ToString();
                return YX.CompareTo(XY);
            });

            if (numbers.Where(x => x == 0).Count() == numbers.Length)
            {
                return "0";
            }
            else 
            {
                return string.Join("", numbers);
            }
        }
}
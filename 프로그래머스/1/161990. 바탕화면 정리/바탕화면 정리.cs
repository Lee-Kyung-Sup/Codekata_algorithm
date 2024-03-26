using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] wallpaper) {

        List<int> rowList = new List<int>();
        List<int> columnList= new List<int>();

        for (int i = 0; i < wallpaper.Length; i++)
        {
            for (int j = 0; j < wallpaper[i].Length; j++)
            {

                if (wallpaper[i][j].Equals('#'))
                {

                    rowList.Add(i);
                    columnList.Add(j);
                }
            }
        }

        int minRow = rowList.Min();
        int minColumn= columnList.Min(); 
        int maxRow= rowList.Max()+1;
        int maxColumn= columnList.Max()+1;

        int[]arr=new int[] { minRow, minColumn, maxRow, maxColumn };

        return arr;

    }
}
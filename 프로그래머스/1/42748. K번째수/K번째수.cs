using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        List<int> list = new List<int>();
        for(int i = 0; i < commands.GetLength(0); i++)
        {
            int[] a = array.ToList()
                .GetRange(commands[i, 0] - 1, commands[i, 1] - commands[i, 0] + 1)
                .ToArray();
            Array.Sort(a);
            list.Add(a[commands[i, 2] - 1]);
        }
        return list.ToArray();
    }
}
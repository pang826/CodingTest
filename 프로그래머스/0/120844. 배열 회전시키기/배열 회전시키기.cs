using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
        int length = numbers.Length;
        List<int> ilist = new List<int>();
        
        if(direction == "right")
        {
            ilist.Add(numbers[length - 1]);
            for(int i = 1; i < length; i++)
            {
                ilist.Add(numbers[i - 1]);
            }
        }
        else
        {
            for(int i = 0; i < length - 1; i++)
            {
                ilist.Add(numbers[i + 1]);
            }
            ilist.Add(numbers[0]);
        }
        return ilist.ToArray();
    }
}
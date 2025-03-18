using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr, int divisor) {
        Array.Sort(arr);
        List<int> list = new List<int>();
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] % divisor == 0)
            {
                list.Add(arr[i]);
            }
        }
        int[] answer;
        if(list.Count == 0)
        {
            return answer = new int[]{-1};
        }
        else
        {
            return answer = list.ToArray();
        }
        
    }
}
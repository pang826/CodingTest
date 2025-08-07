using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] num_list, int n) {
        List<int> answer = new List<int>();
        for(int i = n; i <= num_list.Length; i++)
        {
            if(answer.Count == num_list.Length)
                break;
            if(i == num_list.Length)
                i = 0;
            answer.Add(num_list[i]);
        }
        return answer.ToArray();
    }
}
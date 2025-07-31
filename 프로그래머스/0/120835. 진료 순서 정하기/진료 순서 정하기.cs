using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] emergency) {
        int[] answer = new int[emergency.Length];
        Dictionary<int, int> dic = new Dictionary<int, int>();
        int[] a = (int[])emergency.Clone();
        Array.Sort(a);
        Array.Reverse(a);
        for(int i = 0; i < emergency.Length; i++)
        {
            dic[a[i]] = i + 1;
        }
        for(int j = 0; j < emergency.Length; j++)
        {
            answer[j] = dic[emergency[j]];
        }
        return answer;
    }
}
using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        Dictionary<char, int> d = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++)
        {
            if(!d.TryGetValue(s[i], out int a))
            {
                d[s[i]] = i + 1;
                answer[i] = -1;
            }
            else if(d.TryGetValue(s[i], out int b))
            {
                answer[i] = i + 1 - b;
                d[s[i]] = i + 1;
            }
        }
        return answer;
    }
}
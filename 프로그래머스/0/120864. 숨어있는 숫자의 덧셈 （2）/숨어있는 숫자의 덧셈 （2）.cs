using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        string s = my_string.ToLower();
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] >= 'a')
                s = s.Replace(s[i], ' ');
        }
        string[] sArray = s.Split(" ");
        for(int j = 0; j < sArray.Length; j++)
        {
            if(sArray[j] != "")
            answer += int.Parse(sArray[j]);
        }
        return answer;
    }
}
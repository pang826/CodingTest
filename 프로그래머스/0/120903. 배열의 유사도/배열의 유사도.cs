using System;

public class Solution {
    public int solution(string[] s1, string[] s2) {
        int result = 0;
        for(int i = 0; i < s1.Length; i++)
        {
            foreach(string s in s2)
            {
                if(s == s1[i])
                {
                    result++;
                }
            }
        }
        return result;
    }
}
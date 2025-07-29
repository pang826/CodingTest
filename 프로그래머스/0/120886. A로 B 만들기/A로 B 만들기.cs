using System;

public class Solution {
    public int solution(string before, string after) {
        int answer = 0;
        char[] c = before.ToCharArray();
        char[] ch = after.ToCharArray();
        Array.Sort(c);
        Array.Sort(ch);
        for(int i = 0; i < c.Length; i++)
        {
            if(c[i] != ch[i])
                return 0;
        }
        return 1;
    }
}
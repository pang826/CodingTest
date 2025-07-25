using System;

public class Solution {
    public int solution(string t, string p) {
        int tLength = t.Length;
        int pLength = p.Length;
        int count = 0;
        long a = 0;
        string T = "";
        long P = long.Parse(p);
        for(int i = 0; i <= tLength - pLength; i++)
        {
            T = t.Substring(i , pLength);
            a = long.Parse(T);
            if(a <= P)
                count++;
        }
        return count;
    }
}
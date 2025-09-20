using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int t = brown + yellow;
        int h = 0;
        int w = 0;
        for(h = 3; h <= t; h++)
        {
            if(t % h != 0) continue;
            w = t / h;
            
            if((h - 2) * (w - 2) == yellow) return new int[]{w, h};
        }
        return new int[] {0, 0};
    }
}
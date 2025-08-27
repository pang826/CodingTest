using System;

public class Solution {
    public int solution(int[,] sizes) {
        int a = 0;
        int b = 0;
        
        for(int i = 0; i < sizes.GetLength(0); i++)
        {
            int w = Math.Max(sizes[i, 0], sizes[i, 1]);
            a = Math.Max(a, w);
            
            int h = Math.Min(sizes[i, 0], sizes[i, 1]);
            b = Math.Max(b, h);
        }
        
        return a * b;
    }
}
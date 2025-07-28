using System;

public class Solution {
    public int solution(int n) {
        int slice = 6;
        int multi = n * slice;
        int gcd = 0;
        int lcm = 0;
        while(slice != 0)
        {
            int t = slice;
            slice = n % slice;
            n = t; 
        }
        gcd = n;
        
        return (multi / gcd) / 6;
    }
}
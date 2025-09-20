using System.Collections.Generic;

public class Solution {
    public long solution(int n) {
        List<long> a = new List<long> { 0, 1 };
        long c = 0;
        for(int i = 2; i <= n; i++)
        {
            c = (a[i - 1] + a[i - 2]) % 1234567;
            a.Add(c);
        }
        
        return a[n];
    }
}
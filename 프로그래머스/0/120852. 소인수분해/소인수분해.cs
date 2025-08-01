using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int n) {
        List<int> a = new List<int>();
        
        for(int i = 2; i <= n; i++)
        {
            while(n % i == 0)
            {
                a.Add(i);
                n /= i;
            }
        }
        return a.Distinct().ToArray();
    }
}
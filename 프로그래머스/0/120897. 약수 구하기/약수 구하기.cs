using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int n) {
        List<int> ilist = new List<int>();
        for(int i = 1; i <= n; i++)
        {
            if(n % i == 0)
                ilist.Add(i);
        }
        ilist.Sort();
        return ilist.ToArray();
    }
}
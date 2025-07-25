using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        List<int> nList = new List<int>();
        int result = 0;
        while (n > 0) 
        {
            int a = n % 3;
            nList.Add(a);
            n /= 3;
        }
        nList.Reverse();
        for (int i = 0; i < nList.Count; i++) 
        {
            result += nList[i] * (int)Math.Pow(3, i);
        }

        return result;
    }
}
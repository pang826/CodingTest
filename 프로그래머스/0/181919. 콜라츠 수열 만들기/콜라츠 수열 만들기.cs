using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int n) {
        List<int> list = new List<int>();
        
        if(n <= 1000)
        {
            while(n != 1)
            {
                list.Add(n);
                if(n % 2 == 0)
                    n /= 2;
                else
                    n = n * 3 + 1;
            }
            list.Add(1);
        }
        
        return list.ToArray();
    }
}
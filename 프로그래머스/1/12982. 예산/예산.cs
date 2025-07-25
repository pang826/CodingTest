using System;

public class Solution {
    public int solution(int[] d, int budget) {
        int count = 0;
        Array.Sort(d);
        foreach(int x in d)
        {
            if(budget >= x)
            {
                budget -= x;
                count++;
            }
        }
        return count;
    }
}
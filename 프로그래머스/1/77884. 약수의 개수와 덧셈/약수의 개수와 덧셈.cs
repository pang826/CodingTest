using System;

public class Solution {
    public int solution(int left, int right) {
        int result = 0;
        int count = 0;
        for(int j = left; j <= right; j++)
        {
            for(int i = 1; i <= j; i++)
            {
                if(j % i == 0)  count++;
                if(i == j)
                {
                    if(count % 2 == 0)
                        result += j;
                    else
                        result -= j;
                    count = 0;
                }
            }
        }
        return result;
    }
}
using System;
public class Solution {
    public long solution(long n) {
        long answer = -1;
        
        for(long i = 1; i <= n; i++)
        {
            if(n / i == i && i * i == n)
            {
                answer = i;
                break;
            }
        }
        if(answer != -1)
        {
            return (long)Math.Pow(answer + 1, 2);
        }
        else
            return answer;
    }
}
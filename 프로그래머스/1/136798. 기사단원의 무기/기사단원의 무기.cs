using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        int count = 0;
        for(int i = 1; i <= number; i++)
        {
            count = 0;
            for(int j = 1; j * j <= i; j++)
            {
                if(i % j == 0)
                {
                    count++;
                    if(j != i / j)
                        count++;
                }
                
                if(count > limit)
                {
                    count = power;
                    break;
                }
            }
            answer += count;
        }
        return answer;
    }
}
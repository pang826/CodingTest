using System;

public class Solution {
    public int solution(int hp) {
        int answer = 0;
        
        int a = 5;
        int b = 3;
        int c = 1;
        if(hp / a >= 1)
        {
            answer = hp / a;
            if(hp % a >= 1)
            {
                int x = hp % a;
                answer += (x / b);
                if(x % b >= 1)
                {
                    int y = x % b;
                    answer += (y / c);
                }
            }
        }
        else if(hp / b >= 1)
        {
            answer = hp / b;
            if(hp % b >= 1)
            {
                answer += hp % b;
            }
        }
        else
        {
            answer = hp / c;
        }
        return answer;
    }
}
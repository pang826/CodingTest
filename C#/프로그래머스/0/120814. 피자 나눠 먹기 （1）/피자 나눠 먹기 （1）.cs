using System;

public class Solution {
    public int solution(int n) {
        int pizza = 0;
        
        if(n * 10 % 7 == 0)
        {
            pizza = n / 7;
        }
        else if(n % 7 != 0)
        {
            pizza = n / 7 + 1;
        }
        
        return pizza;
    }
}
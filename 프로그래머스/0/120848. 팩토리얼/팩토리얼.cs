using System;

public class Solution {
    public int solution(int n) {
        int mul = 1;
        int mount = 1;
        while(true)
        {
            for(int i = 1; i <= mul; i++)
            {
                mount *= i;
            }
            if(mount > n)
                break;
            else
            {
                mount = 1;
                mul++;
            }
        }
        return mul - 1;
    }
}
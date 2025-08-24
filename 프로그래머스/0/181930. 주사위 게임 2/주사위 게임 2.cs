using System;

public class Solution {
    public int solution(int a, int b, int c) {
        int check = CheckEqual(a, b, c);
        switch(check)
        {
            case 0:
                return a + b + c;
            case 1:
                return (a + b + c) * (a * a + b * b + c * c) * (a * a * a + b * b * b + c * c * c);
            case 2:
                return (a + b + c) * (a * a + b * b + c * c);
            default:
                return 0;
        }
    }
    
    private int CheckEqual(int i, int j, int k)
    {
        if(i != j && i != k && j != k)
            return 0;
        else if(i == j && j == k)
            return 1;
        else
            return 2;
    }
}
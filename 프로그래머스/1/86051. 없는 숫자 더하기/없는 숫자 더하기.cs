using System;

public class Solution {
    public int solution(int[] numbers) {
        int num = 0;
        
        foreach(int i in numbers)
        {
            num += i;
        }
        
        return 45 - num;
    }
}
using System;

public class Solution {
    public int solution(int num, int k) {
        int length = 0;
        int n = num;
        
        while(n > 0)
        {
            length++;
            n /= 10;
        }
        int[] array = new int[length];
        for(int i = 1; i <= length; i++)
        {
            array[i - 1] = num % 10;
            num /= 10;
        }
        Array.Reverse(array);
        int count = 0;
        foreach(var j in array)
        {
            count++;
            if(j == k)
                return count;
        }
            
        return -1;
    }
}
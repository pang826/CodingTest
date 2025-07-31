using System;

public class Solution {
    public int solution(int[] array, int n) {
        int past = 0;
        int next = 0;
        Array.Sort(array);
        if(array[0] > n)
            return array[0];
        for(int i = 0; i < array.Length; i++)
        {
            past = array[i];
            if(past > n)
            {
                past = array[i - 1];
                next = array[i];
                return Math.Abs(n - past) <= Math.Abs(n - next) ? past : next; 
            }
        }
        return array[array.Length - 1];
    }
}
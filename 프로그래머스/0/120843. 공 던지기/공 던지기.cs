using System;

public class Solution {
    public int solution(int[] numbers, int k) {
        int answer = 0;
        int length = numbers.Length;
        int index = 1;
        for(int i = 0; i < k - 1; i++)
        {
            index += 2;
            if(index > length)
                index -= length;
            answer = numbers[index - 1];
        }
        return answer;
    }
}
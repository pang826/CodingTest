using System;

public class Solution {
    public int solution(int[] numbers, int n) {
        int answer = 0;
        for(int i = 0; i < numbers.Length; i++)
        {
            if(answer <= n)
                answer += numbers[i];
            else
                return answer;
        }
        return answer;
    }
}
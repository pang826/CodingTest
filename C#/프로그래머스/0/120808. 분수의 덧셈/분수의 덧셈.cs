using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        int[] answer = new int[2];
        int resultNum = (numer1 * denom2) + (numer2 * denom1);
        int resultDen = denom1 * denom2;

        for(int i = resultNum; i > 1; i--)
            {
                if(resultNum % i == 0 && resultDen % i == 0)
                {
                    resultNum /= i;
                    resultDen /= i;
                }
            }

        answer[0] = resultNum;
        answer[1] = resultDen;
        
        return answer;
    }
}
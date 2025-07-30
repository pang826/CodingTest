using System;

public class Solution {
    public int solution(int i, int j, int k) {
        int answer = 0;
        string c = k.ToString();

        for (int num = i; num <= j; num++)  
        {
            string s = num.ToString();
            foreach (char ch in s) 
            {
                if (ch.ToString() == c)
                answer++;
            }
        }
        return answer;
    }
}
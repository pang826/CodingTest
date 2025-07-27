using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        char[] c = my_string.ToCharArray();
        
        // my_string의 숫자만 받아오기
        foreach(char ch in c)
        {
            if(ch >= 48 && ch <= 57)
            {
                answer += (int)ch - 48;
            }
        }
        
        return answer;
    }
}
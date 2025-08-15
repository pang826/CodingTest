using System;

public class Solution {
    public int solution(string my_string, string is_prefix) {
        int answer = 0;
        if(my_string.Length < is_prefix.Length || my_string[0] != is_prefix[0])
            return 0;
        for(int i = 0; i < is_prefix.Length; i++)
        {
            if(my_string[i] == is_prefix[i])
                answer = 1;
            else
                answer = 0;
        }
        return answer;
    }
}
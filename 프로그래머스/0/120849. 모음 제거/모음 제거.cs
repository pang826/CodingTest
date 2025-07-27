using System;

public class Solution {
    public string solution(string my_string) {
        string answer = my_string.Replace("a","");
        answer = answer.Replace("e","");
        answer = answer.Replace("i","");
        answer = answer.Replace("o","");
        answer = answer.Replace("u","");
        return answer;
    }
}
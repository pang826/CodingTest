using System;

public class Solution {
    public int solution(string message) {
        char[] a = message.ToCharArray();
        int answer = a.Length * 2;
        return answer;
    }
}
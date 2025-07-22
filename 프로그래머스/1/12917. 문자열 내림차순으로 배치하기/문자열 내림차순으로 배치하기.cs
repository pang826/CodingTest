using System;

public class Solution {
    public string solution(string s) {
        char[] c = s.ToCharArray();
        
        Array.Sort(c);
        Array.Reverse(c);
        
        string result = new String(c);
        return result;
    }
}
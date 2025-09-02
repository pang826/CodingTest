using System;

public class Solution {
    public string solution(string my_string, string alp) {
        char target = alp[0];
        char upper = char.ToUpper(target);
        
        return my_string.Replace(target, upper);
    }
}
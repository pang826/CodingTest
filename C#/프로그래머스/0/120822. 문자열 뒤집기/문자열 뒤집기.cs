using System;

public class Solution {
    public string solution(string my_string) {
        char[] myString = my_string.ToCharArray();
        Array.Reverse(myString);
        string newString = new string(myString);
        return newString;
    }
}
using System;
using System.Text;
public class Solution {
    public string solution(string my_string, int num1, int num2) {
        char[] c = my_string.ToCharArray();
        char t = c[num1];
        c[num1] = c[num2];
        c[num2] = t;
        StringBuilder sb = new StringBuilder();
        foreach(char ch in c)
        {
            sb.Append(ch);
        }
        
        return sb.ToString();
    }
}
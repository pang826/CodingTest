using System;
using System.Text;
public class Solution {
    public string solution(string my_string) {
        char[] c = my_string.ToCharArray();
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < c.Length; i++)
        {
            c[i] = char.ToLower(c[i]);
        }
        Array.Sort(c);
        foreach(char ch in c)
        {
            sb.Append(ch);
        }
        return sb.ToString();
    }
}
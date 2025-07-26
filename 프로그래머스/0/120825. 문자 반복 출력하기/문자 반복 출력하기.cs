using System;
using System.Text;

public class Solution {
    public string solution(string my_string, int n) {
        char[] c = my_string.ToCharArray();
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < c.Length; i++)
        {
            for(int j = 0; j < n; j++)
            {
                sb.Append(c[i]);
            }
        }
        return sb.ToString();
    }
}
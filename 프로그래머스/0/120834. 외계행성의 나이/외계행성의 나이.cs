using System;
using System.Text;
public class Solution {
    public string solution(int age) {
        char[] c = age.ToString().ToCharArray();
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < c.Length; i++)
        {
            c[i] = (char)((int)c[i] + 49);
            sb.Append(c[i]);
        }
        string answer = sb.ToString();
        return answer;
    }
}
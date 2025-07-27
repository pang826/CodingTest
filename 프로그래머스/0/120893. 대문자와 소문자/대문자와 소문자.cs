using System;
using System.Text;

public class Solution {
    public string solution(string my_string) {
        char[] c = my_string.ToCharArray();
        StringBuilder sb = new StringBuilder();
        
        foreach(char ch in c)
        {
            if(ch >= 65 && ch <= 90)
            {
                sb.Append(ch.ToString().ToLower());
            }
            else if(ch >= 97 && ch <= 122)
            {
                sb.Append(ch.ToString().ToUpper());
            }
        }
        
        string answer = sb.ToString();
        return answer;
    }
}
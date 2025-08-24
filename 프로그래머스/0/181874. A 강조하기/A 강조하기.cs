using System;
using System.Text;
public class Solution {
    public string solution(string myString) {
        StringBuilder sb = new StringBuilder();
        foreach(char c in myString)
        {
            if(c == 'a')
                sb.Append('A');
            else if(c == 'A')
                sb.Append('A');
            else if(Char.IsUpper(c))
                sb.Append(Char.ToLower(c));
            else
                sb.Append(c);
        }
        return sb.ToString();
    }
}
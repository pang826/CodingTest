using System;
using System.Text;
public class Solution {
    public string solution(string cipher, int code) {
        char[] c = cipher.ToCharArray();
        int multi = code;
        StringBuilder sb = new StringBuilder();
        while(c.Length >= code)
        {
            sb.Append(c[code - 1]);
            code += multi;
        }
        
        string answer = sb.ToString();
        return answer;
    }
}
using System.Text;
public class Solution {
    public string solution(string s, int n) {
        StringBuilder sb = new StringBuilder();
        // 65 A 90 Z
        // 97 a 122 z
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == ' ')
            {
                sb.Append(' ');
                continue;
            }
            if(s[i] <= 90)
            {
                if(s[i] + n > 90)
                    sb.Append((char)(s[i] - 25 + n - 1));
                else
                    sb.Append((char)(s[i] + n));
            }
            else
            {
                if(s[i] + n > 122)
                    sb.Append((char)(s[i] - 25 + n - 1));
                else
                    sb.Append((char)(s[i] + n));
            }
        }
        return sb.ToString();
    }
}
using System.Text;

public class Solution {
    public string solution(string s) {
        string answer = "";
        StringBuilder builder = new StringBuilder();
        char[] c = s.ToCharArray();
        
        if(c.Length % 2 == 0)
        {
            builder.Append(c[c.Length / 2 - 1]);
            builder.Append(c[c.Length / 2]);
        }
        else
        {
            builder.Append(c[(c.Length - 1) / 2]);
        }
        
        return builder.ToString();;
    }
}
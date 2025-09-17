using System.Text;
public class Solution {
    public string solution(string s) {
        StringBuilder answer = new StringBuilder();
        string[] ss = s.Split(" ");
        for(int i = 0; i < ss.Length; i++)
        {
            if(ss[i].Length > 0)
            {
                string a = char.ToUpper(ss[i][0]).ToString();
                answer.Append(a);
                string b = ss[i].Substring(1).ToLower();
                answer.Append(b);
            }
            if(i != ss.Length - 1)
                answer.Append(" ");
        }
        return answer.ToString();
    }
}
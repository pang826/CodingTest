using System.Text;
public class Solution {
    public string solution(int n) {
        StringBuilder answer = new StringBuilder();
        
        string a = "수";
        string b = "박";
        
        for(int i = 0; i < n; i++)
        {
            if(i % 2 == 0)
            {
                answer.Append(a);
            }
            else
            {
                answer.Append(b);
            }
        }
        return answer.ToString();
    }
}
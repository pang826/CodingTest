using System.Text;
public class Solution {
    public string solution(string s) {
        StringBuilder sb = new StringBuilder();
        string[] ss = s.Split(" ");
        int min = int.MaxValue;
        int max = int.MinValue;
        for(int i = 0; i < ss.Length; i++)
        {
            int a = int.Parse(ss[i]);
            if(min > a)
                min = a;
            else if(max < a)
                max = a;
            if(max < min)
                max = min;
        }
        sb.Append(min);
        sb.Append(" ");
        sb.Append(max);
        return sb.ToString();
    }
}
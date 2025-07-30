using System;
using System.Text;
using System.Linq;
public class Solution {
    public string solution(string s) {
        int count = 0;
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < s.Length; i++)
        {
            for(int j = 0; j < s.Length; j++)
            {
                if(s[i] == s[j])
                    count++;
            }
            if(count == 1)
                sb.Append(s[i]);
            count = 0;
        }
        return string.Concat(sb.ToString().OrderBy(x => x));
    }
}
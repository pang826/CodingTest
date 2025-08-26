using System;
using System.Text;

public class Solution {
    public string solution(string s) {
        StringBuilder sb = new StringBuilder();
        string[] sAr = s.Split(' ');
        for(int i = 0; i < sAr.Length; i++)
        {
            for(int j = 0; j < sAr[i].Length; j++)
            {
                if(j % 2 == 0)
                    sb.Append(Char.ToUpper(sAr[i][j]));
                else
                    sb.Append(Char.ToLower(sAr[i][j]));
            }
            if(i != sAr.Length - 1)
            sb.Append(' ');
        }
        return sb.ToString();
    }
}
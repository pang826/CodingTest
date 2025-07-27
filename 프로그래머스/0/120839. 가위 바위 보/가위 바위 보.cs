using System;
using System.Text;

public class Solution {
    public string solution(string rsp) {
        StringBuilder sb = new StringBuilder();
        char[] c = rsp.ToCharArray();
        
        for(int i = 0; i < c.Length; i++)
        {
            switch(c[i]){
                case '2':
                    sb.Append("0");
                    break;
                case '0' :
                    sb.Append("5");
                    break;
                case '5' :
                    sb.Append("2");
                    break;
            }
        }
        
        string answer = sb.ToString();
        return answer;
    }
}
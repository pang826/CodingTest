using System;
using System.Text;
public class Solution {
    public string solution(int[] numLog) {
        // numLog의 크기는 string 보다 1 큼(원래 숫자 포함)
        StringBuilder sb = new StringBuilder();
        int a = 0;
        for(int i = 0; i < numLog.Length - 1; i++)
        {
            a = numLog[i + 1] - numLog[i];
            switch(a)
            {
                case 1:
                    sb.Append('w');
                    break;
                case -1:
                    sb.Append('s');
                    break;
                case 10:
                    sb.Append('d');
                    break;
                case -10:
                    sb.Append('a');
                    break;
            }
        }
        return sb.ToString();
        
    }
}
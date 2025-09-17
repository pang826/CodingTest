using System;
public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[2];
        int count = 0;
        int save = 0;
        
        while(s != "1")
        {
            int originLength = s.Length;
            s = s.Replace("0","");
            save += originLength - s.Length;
            
            int length = s.Length;
            s = Convert.ToString(length, 2);
            count++;
        }
        answer[0] = count;
        answer[1] = save;
        return answer;
    }
}
using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        int past = 0;
        int mount = 0;
        string[] sArray = s.Split(' ');
        for(int i = 0; i < sArray.Length; i++)
        {
            if(int.TryParse(sArray[i], out past))
            {
                answer += past;
                mount = past;
            }
            else if(sArray[i] == "Z")
                answer -= mount;
        }
        return answer;
    }
}
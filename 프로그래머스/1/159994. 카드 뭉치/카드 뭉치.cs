using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        int fi = 0;
        int si = 0;
        
        for(int i = 0; i < goal.Length; i++)
        {
            if(cards1.Length > fi && goal[i] == cards1[fi])
                fi++;
            else if(cards2.Length > si && goal[i] == cards2[si])
                si++;
            else
                return "No";
        }
        
        return "Yes";
    }
}
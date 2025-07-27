using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string my_string) {
        
        char[] c = my_string.ToCharArray();
        Array.Sort(c);
        List<int> ilist = new List<int>();
        
        foreach(char ch in c)
        {
            if(ch <= 57 && ch >= 48)
            {
                ilist.Add((int)ch - 48);
            }
        }
        int[] answer = ilist.ToArray();
        return answer;
    }
}
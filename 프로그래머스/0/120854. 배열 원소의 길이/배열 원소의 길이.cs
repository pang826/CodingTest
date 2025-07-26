using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] strlist) {
        int[] answer = new int[] {};
        List<int> ilist = new List<int>();
        foreach(string s in strlist)
        {
            int count = s.ToCharArray().Length;
            ilist.Add(count);
        }
        answer = ilist.ToArray();
        return answer;
    }
}
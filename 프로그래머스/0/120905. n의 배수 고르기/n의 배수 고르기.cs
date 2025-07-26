using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int[] numlist) {
        int[] answer = new int[] {};
        List<int> ilist = new List<int>();
        foreach(int i in numlist)
        {
            if(i % n == 0)
                ilist.Add(i);
        }
        answer = ilist.ToArray();
        return answer;
    }
}
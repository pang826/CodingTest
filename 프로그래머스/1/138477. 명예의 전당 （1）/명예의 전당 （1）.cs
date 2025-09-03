using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int k, int[] score) {
        List<int> iList = new List<int>();
        List<int> answer = new List<int>();
        
        foreach(var i in score)
        {
            iList.Add(i);
            iList.Sort();
            if(iList.Count > k)
                iList.RemoveAt(0);
            answer.Add(iList[0]);
        }
        
        return answer.ToArray();
    }
}
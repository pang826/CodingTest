using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string[] names) {
        List<string> answer = new List<string>(); 
        for(int i = 1; i <= names.Length; i++)
        {
            if((i - 1) % 5 == 0)
                answer.Add(names[i - 1]);
        }
        return answer.ToArray();
    }
}
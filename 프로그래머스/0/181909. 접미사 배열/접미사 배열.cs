using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string my_string) {
        List<string> s = new List<string>();
        
        for(int i = 1; i <= my_string.Length; i++)
        {
            s.Add(my_string.Substring(my_string.Length - i, i));
        }
        string[] answer = s.ToArray();
        Array.Sort(answer);
        return answer;
    }
}
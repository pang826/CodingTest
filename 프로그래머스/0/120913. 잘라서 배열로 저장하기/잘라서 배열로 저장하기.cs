using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string my_str, int n) {
        List<string> s = new List<string>();
        for(int i = 0; i < my_str.Length; i += n)
        {
            if(i + n <= my_str.Length)
                s.Add(my_str.Substring(i, n));
            else
                s.Add(my_str.Substring(i));
        }
        return s.ToArray();
    }
}
using System;
using System.Collections.Generic;
public class Solution {
    public bool solution(string s) {
        Stack<char> ch = new Stack<char>();
        for(int i = 0; i < s.Length; i++)
        {
            if(s[0] == ')' || s.Length % 2 != 0) return false;
            
            if(s[i] == '(')
                ch.Push(s[i]);
            else
            {
                if(ch.Count == 0) return false;
                ch.Pop();
            }
        }
        if(ch.Count == 0) return true;
        else return false;
    }
}
using System;

public class Solution {
    public int solution(int order) {
        int count = 0;
        char[] c = order.ToString().ToCharArray();
        foreach(char ch in c)
        {
            if(ch == '3' || ch == '6' || ch == '9')
                count++;
        }
        return count;
    }
}